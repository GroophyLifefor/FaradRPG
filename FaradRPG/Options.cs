using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaradRPG
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        public int nesw = 0;
        public int zmc = 2;
        
        private void btnstart_Click(object sender, EventArgs e)
        {
            this.Hide();
            zmc = Convert.ToInt32(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("soon");
            /*int nes = Convert.ToInt32(textBox1.Text);
            if (nes > 10)
            {
                textBox1.Text = "2";
            }
            else
            {
                nesw = nes;
            }*/
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBox1.Text = zmc.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mainform mf = new mainform();
            if (checkBox1.Checked==true)
            {
                mf.song("start");
            }
            else if(checkBox1.Checked==false)
            {
                mf.song("stop");
            }
        }
    }
}
