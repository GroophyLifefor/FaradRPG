namespace FaradRPG
{
    partial class dungeon
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
            this.character = new System.Windows.Forms.PictureBox();
            this.effectbox = new System.Windows.Forms.PictureBox();
            this.efftimer = new System.Windows.Forms.Timer(this.components);
            this.engine = new System.Windows.Forms.Timer(this.components);
            this.scoretable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backworld = new System.Windows.Forms.Timer(this.components);
            this.griddef = new System.Windows.Forms.Timer(this.components);
            this.logbox = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::FaradRPG.Properties.Resources.idlesag;
            this.character.Location = new System.Drawing.Point(0, 50);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(50, 50);
            this.character.TabIndex = 1;
            this.character.TabStop = false;
            this.character.Tag = "player";
            // 
            // effectbox
            // 
            this.effectbox.BackColor = System.Drawing.Color.Transparent;
            this.effectbox.Image = global::FaradRPG.Properties.Resources.attackeffect;
            this.effectbox.Location = new System.Drawing.Point(706, 96);
            this.effectbox.Name = "effectbox";
            this.effectbox.Size = new System.Drawing.Size(50, 50);
            this.effectbox.TabIndex = 7;
            this.effectbox.TabStop = false;
            this.effectbox.Visible = false;
            // 
            // efftimer
            // 
            this.efftimer.Tick += new System.EventHandler(this.efftimer_Tick);
            // 
            // engine
            // 
            this.engine.Enabled = true;
            this.engine.Interval = 200;
            this.engine.Tick += new System.EventHandler(this.engine_Tick);
            // 
            // scoretable
            // 
            this.scoretable.AutoSize = true;
            this.scoretable.Location = new System.Drawing.Point(1264, 9);
            this.scoretable.Name = "scoretable";
            this.scoretable.Size = new System.Drawing.Size(47, 13);
            this.scoretable.TabIndex = 9;
            this.scoretable.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FaradRPG.Properties.Resources.door;
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // backworld
            // 
            this.backworld.Enabled = true;
            this.backworld.Interval = 10;
            this.backworld.Tick += new System.EventHandler(this.backworld_Tick);
            // 
            // griddef
            // 
            this.griddef.Enabled = true;
            this.griddef.Interval = 1;
            this.griddef.Tick += new System.EventHandler(this.griddef_Tick);
            // 
            // logbox
            // 
            this.logbox.AutoSize = true;
            this.logbox.Location = new System.Drawing.Point(1103, 543);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(0, 13);
            this.logbox.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FaradRPG.Properties.Resources.box;
            this.pictureBox2.Location = new System.Drawing.Point(45, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaradRPG.Properties.Resources.yol;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoretable);
            this.Controls.Add(this.effectbox);
            this.Controls.Add(this.character);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dungeon";
            this.Text = "dungeon";
            this.Load += new System.EventHandler(this.dungeon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dungeon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox character;
        public System.Windows.Forms.PictureBox effectbox;
        private System.Windows.Forms.Timer efftimer;
        private System.Windows.Forms.Timer engine;
        private System.Windows.Forms.Label scoretable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer backworld;
        private System.Windows.Forms.Timer griddef;
        private System.Windows.Forms.Label logbox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}