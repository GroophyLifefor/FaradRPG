namespace FaradRPG
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.gamenametext = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnoptions = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.girişpng = new System.Windows.Forms.PictureBox();
            this.png = new System.Windows.Forms.Timer(this.components);
            this.sound = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.girişpng)).BeginInit();
            this.SuspendLayout();
            // 
            // gamenametext
            // 
            this.gamenametext.AutoSize = true;
            this.gamenametext.BackColor = System.Drawing.Color.Transparent;
            this.gamenametext.Font = new System.Drawing.Font("Hobo Std", 100F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamenametext.Location = new System.Drawing.Point(32, -1);
            this.gamenametext.Name = "gamenametext";
            this.gamenametext.Size = new System.Drawing.Size(712, 190);
            this.gamenametext.TabIndex = 0;
            this.gamenametext.Text = "FaradRPG";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Hobo Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(46, 281);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(204, 78);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.button1_Click);
            this.btnstart.MouseLeave += new System.EventHandler(this.btnstart_MouseLeave);
            this.btnstart.MouseHover += new System.EventHandler(this.btnstart_MouseHover);
            // 
            // btnoptions
            // 
            this.btnoptions.BackColor = System.Drawing.Color.Transparent;
            this.btnoptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnoptions.FlatAppearance.BorderSize = 0;
            this.btnoptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoptions.Font = new System.Drawing.Font("Hobo Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoptions.Location = new System.Drawing.Point(46, 366);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(204, 78);
            this.btnoptions.TabIndex = 2;
            this.btnoptions.Text = "Options";
            this.btnoptions.UseVisualStyleBackColor = false;
            this.btnoptions.Click += new System.EventHandler(this.btnoptions_Click);
            this.btnoptions.MouseLeave += new System.EventHandler(this.btnoptions_MouseLeave);
            this.btnoptions.MouseHover += new System.EventHandler(this.btnoptions_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Hobo Std", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(46, 449);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(204, 78);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // girişpng
            // 
            this.girişpng.Image = ((System.Drawing.Image)(resources.GetObject("girişpng.Image")));
            this.girişpng.Location = new System.Drawing.Point(0, 0);
            this.girişpng.Name = "girişpng";
            this.girişpng.Size = new System.Drawing.Size(1366, 768);
            this.girişpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girişpng.TabIndex = 4;
            this.girişpng.TabStop = false;
            this.girişpng.Click += new System.EventHandler(this.girişpng_Click);
            // 
            // png
            // 
            this.png.Enabled = true;
            this.png.Interval = 1000;
            this.png.Tick += new System.EventHandler(this.png_Tick);
            // 
            // sound
            // 
            this.sound.Enabled = true;
            this.sound.Interval = 403000;
            this.sound.Tick += new System.EventHandler(this.sound_Tick);
            // 
            // mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.girişpng);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnoptions);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.gamenametext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.girişpng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gamenametext;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnoptions;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox girişpng;
        private System.Windows.Forms.Timer png;
        private System.Windows.Forms.Timer sound;
    }
}

