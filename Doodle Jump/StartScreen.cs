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
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
            instructionsLabel.Text = "- Jump on platforms to stay alive\n - Hitting monsters or the bottom of the screen will kill you\n - Jump on monsters heads to kill them\n - Collect power-ups to get higherscores";
        }

       private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
