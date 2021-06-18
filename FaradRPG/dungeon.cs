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
    public partial class dungeon : Form
    {
        public dungeon()
        {
            InitializeComponent();
        }
        string facing = "up";

        int bloc = 0;
        bool punch = false;
        int zombieSpeed = 5;
        int nullapp = 0;
        //score
        public int oldcharacterpubX = 0;
        public int oldcharacterpubY = 0;
        bool doorpss = false;
        int zc = 3;
        Random rnd = new Random();
        private void shoot(string direct)
        {
            int asdpkg = 0;
            if (facing == "up")
            {
                bloc = character.Location.Y;
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
            shoot.mkkbullet(this);
            

        }
        private void dungeon_KeyDown(object sender, KeyEventArgs e)
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
                int newcharx = 0;
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

        private void efftimer_Tick(object sender, EventArgs e)
        {
            nullapp += 1;
            if (nullapp == 2)
            {
                effectbox.Visible = false;
                efftimer.Enabled = false;
                nullapp = 0;
            }
        }

        private void engine_Tick(object sender, EventArgs e)
        {
            scoretable.Text = ("Gold: ");
            foreach (Control x in this.Controls)
            {
                // if the X is a picture box and X has a tag AMMO
                if (x is PictureBox && x.Tag == "zombie")
                {

                    // below is the if statament thats checking the bounds of the character and the zombie

                    /*if (((PictureBox)x).Bounds.IntersectsWith(character.Bounds))
                    {
                        characterHealth -= 0.5; // if the zombie hits the character then we decrease the health by 1
                    }*/

                    //move zombie towards the character picture box

                    if (((PictureBox)x).Left > character.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed; // move zombie towards the left of the character
                        ((PictureBox)x).Image = Properties.Resources.zleft; // change the zombie image to the left
                    }

                    if (((PictureBox)x).Top > character.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed; // move zombie upwards towards the characters top
                        ((PictureBox)x).Image = Properties.Resources.zup; // change the zombie picture to the top pointing image
                    }
                    if (((PictureBox)x).Left < character.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed; // move zombie towards the right of the character
                        ((PictureBox)x).Image = Properties.Resources.zright; // change the image to the right image
                    }
                    if (((PictureBox)x).Top < character.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed; // move the zombie towards the bottom of the character
                        ((PictureBox)x).Image = Properties.Resources.zdown; // change the image to the down zombie
                    }
                }
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
        private void makeZombies()
        {
            // when this function is called it will make zombies in the game
            if (zc <= 19)
            {
                int[] topss = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750 };
                int[] leftss = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300 };
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
                character.BringToFront(); // bring the character to the front
                zc++;
            }
            if (zc==20)
            {
                zc = 0;
                Gamemain gm = new Gamemain();
                gm.Show();
                this.Hide();
                //score += 20;
                scoretable.Text = ("Gold: ");
                MessageBox.Show("you won 20 Gold");
            }
        }

        private void backworld_Tick(object sender, EventArgs e)
        {
            var backloc = new Point(0, 0);
            var nl = new Point(50, 50); 
            var blls = new Point(750, 50);
            var box1 = new Point(50, 0);
            var fullold = new Point(oldcharacterpubX, oldcharacterpubY);
            if (character.Location==backloc)
            {
                this.Hide();
                zc = 0;
                Gamemain gm = new Gamemain();
                gm.Show();
                character.Location = nl;
                gm.character.Location = blls;
            }
            if (character.Location == box1)
            {
                character.Location = (fullold);
                logbox.Text = "character back location" + Environment.NewLine + logbox.Text;
            }
        }

        private void griddef_Tick(object sender, EventArgs e)
        {
            var fullold = new Point(oldcharacterpubX, oldcharacterpubY);
            if (character.Location.X >= 1367)
            {
                character.Location = new Point(0, 50);
            }
            if (character.Location.X <= -1)
            {
                character.Location = new Point(0, 50);
            }
            if (character.Location.Y >= 769)
            {
                character.Location = new Point(0, 50);
            }
            if (character.Location.Y <= -1)
            {
                character.Location = new Point(0, 50);
            }
        }

        private void dungeon_Load(object sender, EventArgs e)
        {
            var sada=new Point(0, 50);
            character.Location = sada;
            Options opt = new Options();
            //int veg = Convert.ToInt32(opt.textBox1.Text);
            int veg = opt.zmc;
            logbox.Text = veg + Environment.NewLine + logbox.Text;
            
            for (int i = 0; i < veg; i++)
            {
                
                logbox.Text = "zombie created" + Environment.NewLine + logbox.Text;
                makeZombies();
            }
        }
    }

}
