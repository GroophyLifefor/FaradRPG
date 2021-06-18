using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Media;

namespace FaradRPG
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        int pngtime = 0;
        
        public static string comed;
        private void button1_Click(object sender, EventArgs e)
        {
            Gamemain gamemains = new Gamemain();
            gamemains.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_MouseHover(object sender, EventArgs e)
        {
            btnexit.ForeColor = System.Drawing.Color.Red;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.ForeColor = System.Drawing.Color.Black;
        }

        private void btnoptions_MouseHover(object sender, EventArgs e)
        {
            btnoptions.ForeColor = System.Drawing.Color.Red;
        }

        private void btnoptions_MouseLeave(object sender, EventArgs e)
        {
            btnoptions.ForeColor = System.Drawing.Color.Black;
        }

        private void btnstart_MouseHover(object sender, EventArgs e)
        {
            btnstart.ForeColor = System.Drawing.Color.Red;
        }

        private void btnstart_MouseLeave(object sender, EventArgs e)
        {
            btnstart.ForeColor = System.Drawing.Color.Black;
        }

        private void btnoptions_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            
            if (Program.sng==false)
            {
                song("start");
                Program.sng = true;
            }

            try
            {
                StreamReader read = new StreamReader("faradrpgdata.txt");
                
                read.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("faradrpgdata.txt");
                sw.Close();
            }
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gamemain gm = new Gamemain();
            StreamWriter sws = new StreamWriter("faradrpgdata.txt");
            sws.Write("");
            sws.WriteLine(gm.score);
            sws.Close();
        }

        private void mainform_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Down)
            {
                if (btnstart.ForeColor == System.Drawing.Color.Red)
                {
                    btnstart.ForeColor = System.Drawing.Color.Black;
                    btnoptions.ForeColor = System.Drawing.Color.Red;
                }
                if (btnoptions.ForeColor == System.Drawing.Color.Red)
                {
                    btnoptions.ForeColor = System.Drawing.Color.Black;
                    btnexit.ForeColor = System.Drawing.Color.Red;
                }
                if (btnexit.ForeColor == System.Drawing.Color.Red)
                {
                    btnexit.ForeColor = System.Drawing.Color.Black;
                    btnstart.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
            //
                if (btnstart.ForeColor == System.Drawing.Color.Red)
                {
                    btnstart.ForeColor = System.Drawing.Color.Black;
                    btnoptions.ForeColor = System.Drawing.Color.Red;
                }
                if (btnoptions.ForeColor == System.Drawing.Color.Red)
                {
                    btnoptions.ForeColor = System.Drawing.Color.Black;
                    btnexit.ForeColor = System.Drawing.Color.Red;
                }
                if (btnexit.ForeColor == System.Drawing.Color.Red)
                {
                    btnexit.ForeColor = System.Drawing.Color.Black;
                    btnstart.ForeColor = System.Drawing.Color.Red;
                }
            }*/
            if (e.KeyCode == Keys.Enter)
            {
                if (btnstart.ForeColor == System.Drawing.Color.Red)
                {
                    btnstart.PerformClick();
                }
                if (btnoptions.ForeColor == System.Drawing.Color.Red)
                {
                    btnoptions.PerformClick();
                }
                if (btnexit.ForeColor == System.Drawing.Color.Red)
                {
                    btnexit.PerformClick();
                }
            }
        }

        private void png_Tick(object sender, EventArgs e)
        {
            pngtime++;
            if (pngtime>=5)
            {
                girişpng.Visible = false;
                png.Stop();
            }
        }

        private void girişpng_Click(object sender, EventArgs e)
        {

        }

        private void sound_Tick(object sender, EventArgs e)
        {
            song("start");
        }

        public void song(string comedstring)
        {
            comed = comedstring.ToString();
            /*foreach (string amk in comedstring)
            {
                comed = amk;
            }*/
            System.IO.Stream str = Properties.Resources.PederBHellandAlways;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (comed == "start")
            {
                
                snd.Play();
            }
            else if (comed == "stop")
            {
                snd.Stop();
            }
        }
    }
}
