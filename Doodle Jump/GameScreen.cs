using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doodle_Jump
{

    public partial class GameScreen : UserControl
    {
        //list all public variables
        public static Player hero;
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
        List<Platforms> platform = new List<Platforms>();
        Random randGen = new Random();
        public static int score = 0;
        Rectangle player;
        Boolean leftArrowDown, rightArrowDown;
        public string direction;
        int jumpCounter = 0;
        Bitmap joesephRight = new Bitmap(Properties.Resources.JoesphRight);
        Bitmap joesephLeft = new Bitmap(Properties.Resources.JoesphLeft);

        public GameScreen()
        {
            InitializeComponent();
           GameInitialize();


        }
        
        public void GameInitialize()
        {
            hero = new Player(200, 100);
            player = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            Random randGen = new Random();
            for (int i = 0; i < 10; i++) 
            {
                 Platforms Platform = new Platforms(randGen.Next(0, 200), randGen.Next(0, 400), randGen.Next(1,10));
                platform.Add(Platform);
            }

            gameTimer.Enabled = true;

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                   
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    
                    rightArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //update player position
            player = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            //gravity
            hero.y += hero.Yspeed;

            //player movement
            
            if (rightArrowDown ==  true && hero.x < this.Width - hero.width - 10)
            {
                hero.Move("right");
                
            }
            if (leftArrowDown && hero.x > 10)
            {
                hero.Move("left");
            }

            //PLatform movement and spawning code

            for (int i = 0; i < platform.Count(); i++)
            {
                if (platform.Count < 8)
                {
                    
                    int powerup = randGen.Next(0, 50);
                    if (powerup == 10) 
                    { 
                        Platforms springShoe = new Platforms(randGen.Next(0, this.Width), platform[i].y, randGen.Next(1,10));
                        platform.Add(springShoe);  
                    }
                    else if (powerup == 20)
                    {
                        Platforms jetPack = new Platforms(randGen.Next(0, this.Width), platform[i].y, randGen.Next(1, 10));
                        platform.Add(jetPack);
                    }
                    else if (powerup == 30)
                    {
                        Platforms hat = new Platforms(randGen.Next(0, this.Width), platform[i].y, randGen.Next(1, 10));
                        platform.Add(hat);
                    }
                    else if (powerup == 40)
                    {
                        Platforms monster = new Platforms(randGen.Next(0, this.Width), platform[i].y, randGen.Next(1, 10));
                        platform.Add(monster);
                    }

                    else
                    {
                        Platforms Platform = new Platforms(randGen.Next(0, this.Width), platform[i].y, randGen.Next(1, 10));
                        platform.Add(Platform);
                    }
                }
                if (platform[i].y >= 566)
                {
                    platform.RemoveAt(i);
                    Platforms Platform = new Platforms(randGen.Next(0, this.Width), 0, randGen.Next(1, 10));
                    platform.Add(Platform);
                }
            }

            foreach (Platforms p in platform)
            {
                p.Move(this.Width, this.Height);
            }

            

            for (int i = 0; i < platform.Count(); i++)
            {
                if (platform[i].Collison(hero) == true)
                {
                    hero.Yspeed = -8;
                    jumpCounter = 0;
                    
                }
                
            }
            

            jumpCounter++;

            if (jumpCounter == 15)
            {
                hero.Yspeed = 6;
                jumpCounter = 0;
                
            }
            

            if (player.Y > 570)
            {
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new GameOverScreen());
            }

            score++;

            
       

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // paint the hero hitbox
           
            if (rightArrowDown == true)
            {
                  e.Graphics.DrawImage(joesephRight, hero.x, hero.y, hero.width, hero.height);
            }
           else  
            {
                e.Graphics.DrawImage(joesephLeft, hero.x, hero.y, hero.width, hero.height);
            }

            //paint the obstacles
            foreach (Platforms p in platform)
            {
                e.Graphics.FillRectangle(redBrush, p.x, p.y, p.width, p.height);
            }
            
        }
    }
}
