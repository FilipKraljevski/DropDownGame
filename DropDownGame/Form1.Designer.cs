namespace DropDownGame
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.pbPurple = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblComments = new System.Windows.Forms.Label();
            this.readyTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.pbPurple);
            this.panel1.Controls.Add(this.pbGreen);
            this.panel1.Controls.Add(this.pbBlue);
            this.panel1.Controls.Add(this.pbRed);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 600);
            this.panel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(318, 155);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 40);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // pbPurple
            // 
            this.pbPurple.BackColor = System.Drawing.Color.Purple;
            this.pbPurple.Location = new System.Drawing.Point(290, 491);
            this.pbPurple.Name = "pbPurple";
            this.pbPurple.Size = new System.Drawing.Size(290, 50);
            this.pbPurple.TabIndex = 3;
            this.pbPurple.TabStop = false;
            this.pbPurple.Tag = "platform";
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Green;
            this.pbGreen.Location = new System.Drawing.Point(180, 267);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(400, 50);
            this.pbGreen.TabIndex = 2;
            this.pbGreen.TabStop = false;
            this.pbGreen.Tag = "platform";
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.Blue;
            this.pbBlue.Location = new System.Drawing.Point(0, 379);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(290, 50);
            this.pbBlue.TabIndex = 1;
            this.pbBlue.TabStop = false;
            this.pbBlue.Tag = "platform";
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.Location = new System.Drawing.Point(0, 155);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(290, 50);
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            this.pbRed.Tag = "platform";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(225, 654);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 32);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(12, 615);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(0, 25);
            this.lblComments.TabIndex = 2;
            // 
            // readyTimer
            // 
            this.readyTimer.Enabled = true;
            this.readyTimer.Interval = 1000;
            this.readyTimer.Tick += new System.EventHandler(this.readyTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 723);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "DropDownGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pbPurple;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Timer readyTimer;
    }
}

