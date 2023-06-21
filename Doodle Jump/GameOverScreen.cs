using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doodle_Jump
{
    public partial class GameOverScreen : UserControl
    {
        List<Highscore> highscoreDB = new List<Highscore>();
        public GameOverScreen()
        {
            InitializeComponent();
            loadDB();
            scoreLabel.Text += $"Your score was  {GameScreen.score} \nPlay Again?";
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            string name, score;
            name = highscoreTextBox.Text;
            score = Convert.ToString(GameScreen.score);

            Highscore newScore = new Highscore(name, score);

            highscoreDB.Add(newScore);

            ClearLabels();
        }
        private void ClearLabels()
        {
            highscoreTextBox.Text = "";
        }

        public void loadDB()
        {
            string name, score;

            XmlReader reader = XmlReader.Create("Resources/HighScoreXML.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    name = reader.ReadString();

                    reader.ReadToNextSibling("firstName");
                    score = reader.ReadString();

                    Highscore newScore = new Highscore(name, score);
                    highscoreDB.Add(newScore);
                }
            }

            reader.Close();
        }

        public void saveDB()
        {
            XmlWriter writer = XmlWriter.Create("Resources/HighScoreXML.xml", null);

            writer.WriteStartElement("HighScores");

            foreach (Highscore score in highscoreDB)
            {
                writer.WriteStartElement("HighScores");

                writer.WriteElementString("name", score.name);
                writer.WriteElementString("score", score.score);
              

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            viewHighScoreLabel.Text = "";
            foreach (Highscore score in highscoreDB)
            {
                viewHighScoreLabel.Text += $"{score.name} {score.score} \n";
            }
        }

        private void GameOverScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveDB();
        }
    }
}
