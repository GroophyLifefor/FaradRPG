namespace FaradRPG
{
    partial class Gamemain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridlimit = new System.Windows.Forms.Timer(this.components);
            this.charxloc = new System.Windows.Forms.Label();
            this.charyloc = new System.Windows.Forms.Label();
            this.character = new System.Windows.Forms.PictureBox();
            this.shophome = new System.Windows.Forms.PictureBox();
            this.shops = new System.Windows.Forms.Timer(this.components);
            this.msgboxtext = new System.Windows.Forms.Label();
            this.zombie = new System.Windows.Forms.PictureBox();
            this.engine = new System.Windows.Forms.Timer(this.components);
            this.effect = new System.Windows.Forms.Timer(this.components);
            this.effectbox = new System.Windows.Forms.PictureBox();
            this.efftimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scoretable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logbox = new System.Windows.Forms.Label();
            this.clearlog = new System.Windows.Forms.Timer(this.components);
            this.walk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shophome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridlimit
            // 
            this.gridlimit.Enabled = true;
            this.gridlimit.Interval = 1;
            this.gridlimit.Tick += new System.EventHandler(this.gridlimit_Tick);
            // 
            // charxloc
            // 
            this.charxloc.AutoSize = true;
            this.charxloc.Location = new System.Drawing.Point(1319, 11);
            this.charxloc.Name = "charxloc";
            this.charxloc.Size = new System.Drawing.Size(35, 13);
            this.charxloc.TabIndex = 1;
            this.charxloc.Text = "label1";
            // 
            // charyloc
            // 
            this.charyloc.AutoSize = true;
            this.charyloc.Location = new System.Drawing.Point(1319, 24);
            this.charyloc.Name = "charyloc";
            this.charyloc.Size = new System.Drawing.Size(35, 13);
            this.charyloc.TabIndex = 2;
            this.charyloc.Text = "label1";
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::FaradRPG.Properties.Resources.idlesag;
            this.character.Location = new System.Drawing.Point(0, 0);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(50, 50);
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            this.character.Tag = "player";
            // 
            // shophome
            // 
            this.shophome.BackColor = System.Drawing.Color.Transparent;
            this.shophome.Image = global::FaradRPG.Properties.Resources.shop;
            this.shophome.Location = new System.Drawing.Point(450, 0);
            this.shophome.Name = "shophome";
            this.shophome.Size = new System.Drawing.Size(50, 50);
            this.shophome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shophome.TabIndex = 3;
            this.shophome.TabStop = false;
            this.shophome.Click += new System.EventHandler(this.shophome_Click);
            // 
            // shops
            // 
            this.shops.Enabled = true;
            this.shops.Interval = 1;
            this.shops.Tick += new System.EventHandler(this.shops_Tick);
            // 
            // msgboxtext
            // 
            this.msgboxtext.AutoSize = true;
            this.msgboxtext.Location = new System.Drawing.Point(506, 11);
            this.msgboxtext.Name = "msgboxtext";
            this.msgboxtext.Size = new System.Drawing.Size(132, 13);
            this.msgboxtext.TabIndex = 4;
            this.msgboxtext.Text = "-Click Enter for open shop.";
            this.msgboxtext.Visible = false;
            // 
            // zombie
            // 
            this.zombie.BackColor = System.Drawing.Color.Transparent;
            this.zombie.Image = global::FaradRPG.Properties.Resources.zdown;
            this.zombie.Location = new System.Drawing.Point(300, 0);
            this.zombie.Name = "zombie";
            this.zombie.Size = new System.Drawing.Size(50, 50);
            this.zombie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zombie.TabIndex = 5;
            this.zombie.TabStop = false;
            this.zombie.Tag = "zombie";
            // 
            // engine
            // 
            this.engine.Enabled = true;
            this.engine.Interval = 10;
            this.engine.Tick += new System.EventHandler(this.engine_Tick);
            // 
            // effect
            // 
            this.effect.Tick += new System.EventHandler(this.effect_Tick);
            // 
            // effectbox
            // 
            this.effectbox.BackColor = System.Drawing.Color.Transparent;
            this.effectbox.Image = global::FaradRPG.Properties.Resources.attackeffect;
            this.effectbox.Location = new System.Drawing.Point(1000, 0);
            this.effectbox.Name = "effectbox";
            this.effectbox.Size = new System.Drawing.Size(50, 50);
            this.effectbox.TabIndex = 6;
            this.effectbox.TabStop = false;
            this.effectbox.Visible = false;
            // 
            // efftimer
            // 
            this.efftimer.Tick += new System.EventHandler(this.efftimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1241, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FaradRPG alpha beta ";
            // 
            // scoretable
            // 
            this.scoretable.AutoSize = true;
            this.scoretable.Location = new System.Drawing.Point(1241, 72);
            this.scoretable.Name = "scoretable";
            this.scoretable.Size = new System.Drawing.Size(47, 13);
            this.scoretable.TabIndex = 8;
            this.scoretable.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FaradRPG.Properties.Resources.door;
            this.pictureBox1.Location = new System.Drawing.Point(750, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FaradRPG.Properties.Resources.box;
            this.pictureBox2.Location = new System.Drawing.Point(700, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::FaradRPG.Properties.Resources.box;
            this.pictureBox3.Location = new System.Drawing.Point(800, -8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1113, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "logs";
            // 
            // logbox
            // 
            this.logbox.AutoSize = true;
            this.logbox.Location = new System.Drawing.Point(1113, 554);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(0, 13);
            this.logbox.TabIndex = 15;
            // 
            // clearlog
            // 
            this.clearlog.Enabled = true;
            this.clearlog.Interval = 10000;
            this.clearlog.Tick += new System.EventHandler(this.clearlog_Tick);
            // 
            // walk
            // 
            this.walk.Enabled = true;
            this.walk.Interval = 10;
            // 
            // Gamemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FaradRPG.Properties.Resources.yol2;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoretable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.effectbox);
            this.Controls.Add(this.zombie);
            this.Controls.Add(this.msgboxtext);
            this.Controls.Add(this.shophome);
            this.Controls.Add(this.character);
            this.Controls.Add(this.charyloc);
            this.Controls.Add(this.charxloc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gamemain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamemain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gamemain_FormClosing);
            this.Load += new System.EventHandler(this.Gamemain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamemain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shophome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gridlimit;
        private System.Windows.Forms.Label charxloc;
        private System.Windows.Forms.Label charyloc;
        private System.Windows.Forms.PictureBox shophome;
        private System.Windows.Forms.Timer shops;
        private System.Windows.Forms.Label msgboxtext;
        private System.Windows.Forms.PictureBox zombie;
        private System.Windows.Forms.Timer engine;
        private System.Windows.Forms.Timer effect;
        public System.Windows.Forms.PictureBox effectbox;
        private System.Windows.Forms.Timer efftimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logbox;
        private System.Windows.Forms.Timer clearlog;
        public System.Windows.Forms.Label scoretable;
        private System.Windows.Forms.Timer walk;
        public System.Windows.Forms.PictureBox character;
    }
}