using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace FaradRPG
{
    public partial class Gamemain : Form
    {
        public Gamemain()
        {
            InitializeComponent();
        }
        string facing = "up";
        
        int bloc=0;
        bool punch=false;
        int nullapp = 0;
        public int score = 0;
        public int oldcharacterpubX = 0;
        public int oldcharacterpubY = 0;
        bool doorpss = false;
        Random rnd = new Random();
        private void Gamemain_Load(object sender, EventArgs e)
        {
            
            StreamReader srdata = new StreamReader("faradrpgdata.txt");
            character.Location = new Point(0, 0);
            score = Convert.ToInt32(srdata.ReadLine());//readline 1
            srdata.Close();
        }

        private void Gamemain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newchary = charY - 50;
                character.Location = new Point(charX, newchary);
                if (facing=="right")
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                if (facing=="left")
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                else
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                facing = "up";
                logbox.Text = "character up" + Environment.NewLine + logbox.Text;
                

            }
            if (e.KeyCode == Keys.A)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newcharx = charX - 50;
                character.Location = new Point(newcharx, charY);
                facing = "left";
                character.Image = Properties.Resources.idlesol;
                logbox.Text = "character left" + Environment.NewLine + logbox.Text;
            }
            if (e.KeyCode == Keys.S)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newchary = charY + 50;
                character.Location = new Point(charX, newchary);
                if (facing == "right")
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                if (facing == "left")
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                else
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                facing = "down";
                logbox.Text = "character down" + Environment.NewLine + logbox.Text;
            }
            if (e.KeyCode == Keys.D)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int newcharx=0;
                newcharx = 0;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                newcharx = charX + 50;
                character.Location = new Point(newcharx, charY);
                facing = "right";
                character.Image = Properties.Resources.idlesag;
                logbox.Text = "character right" + Environment.NewLine + logbox.Text;
            }
            if (e.KeyCode == Keys.P)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.Escape)
            {
                mainform mainyer = new mainform();
                mainyer.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (character.Location.X == 450)
                {
                    if (character.Location.Y == 0)
                    {
                        Shop shops = new Shop();
                        shops.Show();
                        
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                shoot(facing);
                logbox.Text = "character shoot" + Environment.NewLine + logbox.Text;
            }
        }

        private void gridlimit_Tick(object sender, EventArgs e)
        {
            charxloc.Text = ("X: " + character.Location.X.ToString());
            charyloc.Text = ("Y: " + character.Location.Y.ToString());
            if (character.Location.X >= 1367)
            {
                character.Location = new Point(0, 0);
            }
            if (character.Location.X <= -1)
            {
                character.Location = new Point(0, 0);
            }
            if (character.Location.Y >= 769)
            {
                character.Location = new Point(0, 0);
            }
            if (character.Location.Y <= -1)
            {
                character.Location = new Point(0, 0);
            }
        }

        private void shoot(string direct)
        {
            int asdpkg = 0;
            if (facing=="up")
            {
                bloc=character.Location.Y;
                asdpkg = character.Location.Y - 50;
                effectbox.Visible = true;
                effectbox.Location = new Point(character.Location.X, asdpkg);
                efftimer.Enabled = true;
                
            }
            if (facing == "down")
            {
                bloc = character.Location.Y;
                asdpkg = character.Location.Y + 50;
                effectbox.Visible = true;
                effectbox.Location = new Point(character.Location.X, asdpkg);
                efftimer.Enabled = true;
                
            }
            if (facing == "left")
            {
                bloc = character.Location.X;
                asdpkg = character.Location.X - 50;
                effectbox.Visible = true;
                effectbox.Location = new Point(asdpkg, character.Location.Y);
                efftimer.Enabled = true;
                
            }
            if (facing == "right")
            {
                bloc = character.Location.X;
                asdpkg = character.Location.X + 50;
                effectbox.Visible = true;
                effectbox.Location = new Point(asdpkg, character.Location.Y);
                efftimer.Enabled = true;
                
            }

            bullet shoot = new bullet(); 
            shoot.direction = direct;
            shoot.bulletLeft = character.Left + (character.Width / 2);
            shoot.bulletTop = character.Top + (character.Height / 2);
            shoot.deneme(bloc);
            shoot.mkBullet(this);
            
        }

        private void shops_Tick(object sender, EventArgs e)
        {
            var fullold = new Point(oldcharacterpubX, oldcharacterpubY);
            var doorps = new Point(750, 0);
            var box1 = new Point(700, 0);
            var box2 = new Point(800, 0);
            if (character.Location==box1)
            {
                character.Location = (fullold);
                logbox.Text = "character back location" + Environment.NewLine + logbox.Text;
            }
            if (character.Location == box2)
            {
                character.Location = (fullold);
                logbox.Text = "character back location" + Environment.NewLine + logbox.Text;
            }
            if (character.Location == doorps)
            {
                //logbox.Text = ("dungeon opening" + Environment.NewLine + logbox.Text);
                //dungeon
                if (doorpss == false)
                {
                    logbox.Text = ("dungeon opening" + Environment.NewLine + logbox.Text);
                    dungeon dng = new dungeon();
                    this.Hide();
                    dng.Show();
                    doorpss = true;
                    var nll=new Point(750, 50);
                    character.Location = nll;
                }
                else
                {

                }
            }
            if (character.Location.X==450)
            {
                if(character.Location.Y==0)
                {
                    msgboxtext.Visible = true;
                    shophome.BringToFront();

                }
                else
                {
                    msgboxtext.Visible = false;
                }
            }
            else
            {
                msgboxtext.Visible = false;
            }
        }

        private void makeZombies()
        {
            // when this function is called it will make zombies in the game
            int[] topss = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750};
            int[] leftss = {50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200,1250,1300};
            int topsss = rnd.Next(topss.Length);
            int leftsss = rnd.Next(leftss.Length);
            PictureBox zombie = new PictureBox(); // create a new picture box called zombie
            zombie.Tag = "zombie"; // add a tag to it called zombie
            zombie.Height = (50);
            zombie.Width = (50);
            zombie.BackColor = System.Drawing.Color.Transparent;
            zombie.Image = Properties.Resources.zdown; // the default picture for the zombie is zdown
            zombie.Left = rnd.Next(leftss[leftsss]); // generate a number between 0 and 900 and assignment that to the new zombies left 
            zombie.Top = rnd.Next(topss[topsss]); // generate a number between 0 and 800 and assignment that to the new zombies top
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; // set auto size for the new picture box
            this.Controls.Add(zombie); // add the picture box to the screen
            character.BringToFront(); // bring the player to the front
        }

        private void engine_Tick(object sender, EventArgs e)
        {
            
            scoretable.Text = ("Gold: " + score);
            foreach (Control x in this.Controls)
            {
                // if the X is a picture box and X has a tag AMMO

                if (x is PictureBox && x.Tag == "sword")
                {
                    MessageBox.Show("done");
                    Application.Exit();
                }

                foreach (Control j in this.Controls)
                {
                    // below is the selection thats identifying the bullet and zombie

                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                    {
                        // below is the if statement thats checking if bullet hits the zombie
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            
                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                            this.Controls.Remove(x); // this will remove the zombie from the screen
                            x.Dispose(); // this will dispose the zombie from the program
                            
                            makeZombies(); // this function will invoke the make zombies function to add another zombie to the game
                        }
                    }
                }
            }


        }

        private void effect_Tick(object sender, EventArgs e)
        {
            
        }

        private void efftimer_Tick(object sender, EventArgs e)
        {
            
            nullapp += 1;
            if (nullapp==2)
            {
                effectbox.Visible = false;
                efftimer.Enabled = false;
                nullapp = 0;
            }
        }

        private void Gamemain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("faradrpgdata.txt");
            sw.Write("");
            sw.WriteLine(score);
            sw.Close();
        }

        private void shophome_Click(object sender, EventArgs e)
        {
            Shop shops = new Shop();
            shops.Show();
        }

        private void clearlog_Tick(object sender, EventArgs e)
        {
            logbox.Text = "log cleared";
            doorpss = false;
        }

        private void walk_Tick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newchary = charY - 50;
                character.Location = new Point(charX, newchary);
                if (facing == "right")
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                if (facing == "left")
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                else
                {
                    character.Image = Properties.Resources.idlesagust;
                }
                facing = "up";


            }
            if (e.KeyCode == Keys.A)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newcharx = charX - 50;
                character.Location = new Point(newcharx, charY);
                facing = "left";
                character.Image = Properties.Resources.idlesol;
            }
            if (e.KeyCode == Keys.S)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                int newchary = charY + 50;
                character.Location = new Point(charX, newchary);
                if (facing == "right")
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                if (facing == "left")
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                else
                {
                    character.Image = Properties.Resources.idlesolalt;
                }
                facing = "down";
            }
            if (e.KeyCode == Keys.D)
            {
                oldcharacterpubX = character.Location.X;
                oldcharacterpubY = character.Location.Y;
                int newcharx = 0;
                newcharx = 0;
                int charX = character.Location.X;
                int charY = character.Location.Y;
                newcharx = charX + 50;
                character.Location = new Point(newcharx, charY);
                facing = "right";
                character.Image = Properties.Resources.idlesag;
            }
            if (e.KeyCode == Keys.P)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.Escape)
            {
                mainform mainyer = new mainform();
                mainyer.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (character.Location.X == 450)
                {
                    if (character.Location.Y == 0)
                    {
                        Shop shops = new Shop();
                        shops.Show();

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            if (e.KeyCode == Keys.Space)
            {
                shoot(facing);

            }
        }
    }
}
