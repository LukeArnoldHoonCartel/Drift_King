namespace Drift_King
{
    partial class Driftking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driftking));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.picgame = new System.Windows.Forms.PictureBox();
            this.tmrCar = new System.Windows.Forms.Timer(this.components);
            this.TmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrpic = new System.Windows.Forms.Timer(this.components);
            this.txtlives = new System.Windows.Forms.TextBox();
            this.reseatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitmmu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picgame)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.ForeColor = System.Drawing.Color.Transparent;
            this.pnlGame.Location = new System.Drawing.Point(250, 58);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(480, 480);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // picgame
            // 
            this.picgame.BackColor = System.Drawing.Color.Transparent;
            this.picgame.Location = new System.Drawing.Point(249, 58);
            this.picgame.Name = "picgame";
            this.picgame.Size = new System.Drawing.Size(480, 480);
            this.picgame.TabIndex = 0;
            this.picgame.TabStop = false;
            this.picgame.Click += new System.EventHandler(this.picgame_Click_1);
            // 
            // tmrCar
            // 
            this.tmrCar.Tick += new System.EventHandler(this.tmrCar_Tick);
            // 
            // TmrPlayer
            // 
            this.TmrPlayer.Interval = 1;
            this.TmrPlayer.Tick += new System.EventHandler(this.TmrPlayer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(735, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gray;
            this.txtName.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(740, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(78, 40);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(170, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScore.Location = new System.Drawing.Point(193, 95);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 26);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(170, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lives";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.reseatToolStripMenuItem,
            this.inToolStripMenuItem,
            this.quitmmu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 46);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStart
            // 
            this.mnuStart.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(101, 42);
            this.mnuStart.Text = "Start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Font = new System.Drawing.Font("Forte", 26.25F);
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(97, 42);
            this.mnuStop.Text = "Stop";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Font = new System.Drawing.Font("Forte", 26.25F);
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(212, 42);
            this.inToolStripMenuItem.Text = "Instructions";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // tmrpic
            // 
            this.tmrpic.Tick += new System.EventHandler(this.tmrpic_Tick);
            // 
            // txtlives
            // 
            this.txtlives.BackColor = System.Drawing.Color.Gray;
            this.txtlives.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtlives.Location = new System.Drawing.Point(183, 192);
            this.txtlives.Name = "txtlives";
            this.txtlives.Size = new System.Drawing.Size(35, 40);
            this.txtlives.TabIndex = 8;
            this.txtlives.TextChanged += new System.EventHandler(this.txtlives_TextChanged);
            // 
            // reseatToolStripMenuItem
            // 
            this.reseatToolStripMenuItem.Font = new System.Drawing.Font("Forte", 26.25F);
            this.reseatToolStripMenuItem.Name = "reseatToolStripMenuItem";
            this.reseatToolStripMenuItem.Size = new System.Drawing.Size(128, 42);
            this.reseatToolStripMenuItem.Text = "Reseat";
            this.reseatToolStripMenuItem.Click += new System.EventHandler(this.reseatToolStripMenuItem_Click);
            // 
            // quitmmu
            // 
            this.quitmmu.Font = new System.Drawing.Font("Forte", 26.25F);
            this.quitmmu.Name = "quitmmu";
            this.quitmmu.Size = new System.Drawing.Size(93, 42);
            this.quitmmu.Text = "Quit";
            this.quitmmu.Click += new System.EventHandler(this.quitmmu_Click);
            // 
            // Driftking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 586);
            this.Controls.Add(this.txtlives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.picgame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Driftking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Driftking_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Driftking_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Driftking_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picgame)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrCar;
        private System.Windows.Forms.Timer TmrPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.PictureBox picgame;
        private System.Windows.Forms.Timer tmrpic;
        private System.Windows.Forms.TextBox txtlives;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitmmu;
    }
}

