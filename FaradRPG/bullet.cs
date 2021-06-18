using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace FaradRPG
{
    class bullet
    {
        public string direction; // creating a public string called direction
        public int speed = 20; // creating a integer called speed and assigning a value of 20
        public int spead = 500;
        PictureBox Bullet = new PictureBox(); // create a picture box 
        Timer tm = new Timer(); // create a new timer called tm. 
        

        public int bulletLeft; // create a new public integer
        public int bulletTop; // create a new public integer
        int blloc;
        int limit=0;
        
        public void mkkbullet(dungeon form)
        {
            if (direction == "up")
            {
                limit = blloc - 100;
            }
            if (direction == "down")
            {
                limit = blloc + 100;
            }
            if (direction == "left")
            {
                limit = blloc - 100;
            }
            if (direction == "right")
            {
                limit = blloc + 100;
            }

            //MessageBox.Show(blloc.ToString());
            Bullet.BackColor = System.Drawing.Color.Transparent;
            /*Bullet.BringToFront();
            Bullet.Image = Properties.Resources.attackeffect;*/
            //Bullet.BackgroundImage = Properties.Resources.attackeffect;
            Bullet.Size = new Size(50, 50); // set the size to the bullet to 5 pixel by 5 pixel
            Bullet.Tag = "bullet"; // set the tag to bullet
            Bullet.Left = bulletLeft; // set bullet left 
            Bullet.Top = bulletTop; // set bullet right
            Bullet.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(Bullet); // add the bullet to the screen

            tm.Interval = speed; // set the timer interval to speed
            tm.Tick += new EventHandler(tm_Tick); // assignment the timer with an event
            tm.Start(); // start the timer

        }

        public void mkBullet(Gamemain form)

        {
            if (direction=="up")
            {
                limit = blloc - 100;
            }
            if (direction == "down")
            {
                limit = blloc + 100;
            }
            if (direction == "left")
            {
                limit = blloc - 100;
            }
            if (direction == "right")
            {
                limit = blloc + 100;
            }
            
            //MessageBox.Show(blloc.ToString());
            Bullet.BackColor = System.Drawing.Color.Transparent; 
            /*Bullet.BringToFront();
            Bullet.Image = Properties.Resources.attackeffect;*/
            //Bullet.BackgroundImage = Properties.Resources.attackeffect;
            Bullet.Size = new Size(50, 50); // set the size to the bullet to 5 pixel by 5 pixel
            Bullet.Tag = "bullet"; // set the tag to bullet
            Bullet.Left = bulletLeft; // set bullet left 
            Bullet.Top = bulletTop; // set bullet right
            Bullet.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(Bullet); // add the bullet to the screen

            tm.Interval = speed; // set the timer interval to speed
            tm.Tick += new EventHandler(tm_Tick); // assignment the timer with an event
            tm.Start(); // start the timer

            
        }

        public void deneme(int bloc)
        {
            blloc = bloc;
        }

        

        public void tm_Tick(object sender, EventArgs e)
        {
            // if direction equals to left
            if (direction == "left")
            {
                Bullet.Left -= speed; // move bullet towards the left of the screen
            }
            // if direction equals right
            if (direction == "right")
            {
                Bullet.Left += speed; // move bullet towards the right of the screen
            }
            // if direction is up
            if (direction == "up")
            {
                Bullet.Top -= speed; // move the bullet towards top of the screen
            }
            // if direction is down
            if (direction == "down")
            {
                Bullet.Top += speed; // move the bullet bottom of the screen
            }

            
            
            if (direction == "up" && Bullet.Location.Y <= limit )
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
            if (direction == "down" && Bullet.Location.Y >= limit)
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
            if (direction == "left" && Bullet.Location.X <= limit)
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
            if (direction == "right" && Bullet.Location.X >= limit)
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
        }



        
    }
}
