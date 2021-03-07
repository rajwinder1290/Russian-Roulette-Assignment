namespace Russian_Roulette_Assignment
{
    partial class RouletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouletteForm));
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnShootOpponent = new System.Windows.Forms.Button();
            this.btnShootSelf = new System.Windows.Forms.Button();
            this.pbOpponent = new System.Windows.Forms.PictureBox();
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.cmbOpponent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnExitRoulette = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLuck = new System.Windows.Forms.Label();
            this.pbBulletHeader = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBulletHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.BackColor = System.Drawing.Color.Yellow;
            this.btnSpinChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChamber.Location = new System.Drawing.Point(13, 11);
            this.btnSpinChamber.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(206, 52);
            this.btnSpinChamber.TabIndex = 0;
            this.btnSpinChamber.Text = "Load && Spin Chamber";
            this.btnSpinChamber.UseVisualStyleBackColor = false;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnShootOpponent
            // 
            this.btnShootOpponent.BackColor = System.Drawing.Color.Yellow;
            this.btnShootOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootOpponent.Location = new System.Drawing.Point(13, 127);
            this.btnShootOpponent.Margin = new System.Windows.Forms.Padding(4);
            this.btnShootOpponent.Name = "btnShootOpponent";
            this.btnShootOpponent.Size = new System.Drawing.Size(206, 49);
            this.btnShootOpponent.TabIndex = 1;
            this.btnShootOpponent.Text = "Shoot Opponent";
            this.btnShootOpponent.UseVisualStyleBackColor = false;
            this.btnShootOpponent.Click += new System.EventHandler(this.btnFireOponent_Click);
            // 
            // btnShootSelf
            // 
            this.btnShootSelf.BackColor = System.Drawing.Color.Yellow;
            this.btnShootSelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootSelf.Location = new System.Drawing.Point(13, 71);
            this.btnShootSelf.Margin = new System.Windows.Forms.Padding(4);
            this.btnShootSelf.Name = "btnShootSelf";
            this.btnShootSelf.Size = new System.Drawing.Size(206, 48);
            this.btnShootSelf.TabIndex = 3;
            this.btnShootSelf.Text = "Shoot Yourself";
            this.btnShootSelf.UseVisualStyleBackColor = false;
            this.btnShootSelf.Click += new System.EventHandler(this.btnBiteBullet_Click);
            // 
            // pbOpponent
            // 
            this.pbOpponent.Location = new System.Drawing.Point(22, 244);
            this.pbOpponent.Margin = new System.Windows.Forms.Padding(4);
            this.pbOpponent.Name = "pbOpponent";
            this.pbOpponent.Size = new System.Drawing.Size(253, 215);
            this.pbOpponent.TabIndex = 4;
            this.pbOpponent.TabStop = false;
            // 
            // pbGun
            // 
            this.pbGun.Location = new System.Drawing.Point(321, 217);
            this.pbGun.Margin = new System.Windows.Forms.Padding(4);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(365, 324);
            this.pbGun.TabIndex = 5;
            this.pbGun.TabStop = false;
            // 
            // cmbOpponent
            // 
            this.cmbOpponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpponent.FormattingEnabled = true;
            this.cmbOpponent.Location = new System.Drawing.Point(22, 467);
            this.cmbOpponent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOpponent.Name = "cmbOpponent";
            this.cmbOpponent.Size = new System.Drawing.Size(252, 24);
            this.cmbOpponent.TabIndex = 6;
            this.cmbOpponent.SelectedIndexChanged += new System.EventHandler(this.cmbOponent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Your Opponent";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(741, 218);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(243, 258);
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(860, 11);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerName.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(773, 43);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 25);
            this.lblScore.TabIndex = 11;
            // 
            // btnExitRoulette
            // 
            this.btnExitRoulette.BackColor = System.Drawing.Color.Salmon;
            this.btnExitRoulette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitRoulette.Location = new System.Drawing.Point(781, 490);
            this.btnExitRoulette.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitRoulette.Name = "btnExitRoulette";
            this.btnExitRoulette.Size = new System.Drawing.Size(203, 51);
            this.btnExitRoulette.TabIndex = 12;
            this.btnExitRoulette.Text = "Exit";
            this.btnExitRoulette.UseVisualStyleBackColor = false;
            this.btnExitRoulette.Click += new System.EventHandler(this.btnExitRoulette_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuck.Location = new System.Drawing.Point(673, 77);
            this.lblLuck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(0, 25);
            this.lblLuck.TabIndex = 14;
            // 
            // pbBulletHeader
            // 
            this.pbBulletHeader.Location = new System.Drawing.Point(321, 217);
            this.pbBulletHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pbBulletHeader.Name = "pbBulletHeader";
            this.pbBulletHeader.Size = new System.Drawing.Size(365, 59);
            this.pbBulletHeader.TabIndex = 15;
            this.pbBulletHeader.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(283, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(377, 165);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // RouletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1012, 548);
            this.Controls.Add(this.pbBulletHeader);
            this.Controls.Add(this.lblLuck);
            this.Controls.Add(this.btnExitRoulette);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpponent);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.btnShootSelf);
            this.Controls.Add(this.btnShootOpponent);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.pbOpponent);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RouletteForm";
            this.Text = "Simple Game ";
            this.Load += new System.EventHandler(this.RouletteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBulletHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Button btnShootOpponent;
        private System.Windows.Forms.Button btnShootSelf;
        private System.Windows.Forms.PictureBox pbOpponent;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.ComboBox cmbOpponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnExitRoulette;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.PictureBox pbBulletHeader;
        private System.Windows.Forms.TextBox textBox1;
    }
}