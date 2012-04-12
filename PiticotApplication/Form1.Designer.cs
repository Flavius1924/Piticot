namespace PiticotApplication
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
            this.buttonDice = new System.Windows.Forms.Button();
            this.panelPiticot = new System.Windows.Forms.Panel();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.color3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.color4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDice
            // 
            this.buttonDice.Location = new System.Drawing.Point(12, 348);
            this.buttonDice.Name = "buttonDice";
            this.buttonDice.Size = new System.Drawing.Size(75, 23);
            this.buttonDice.TabIndex = 0;
            this.buttonDice.Text = "Arunca zar";
            this.buttonDice.UseVisualStyleBackColor = true;
            this.buttonDice.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // panelPiticot
            // 
            this.panelPiticot.Location = new System.Drawing.Point(12, 12);
            this.panelPiticot.Name = "panelPiticot";
            this.panelPiticot.Size = new System.Drawing.Size(768, 320);
            this.panelPiticot.TabIndex = 1;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(303, 348);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentPlayer.TabIndex = 2;
            this.lblCurrentPlayer.Text = "label1";
            // 
            // color1
            // 
            this.color1.AutoSize = true;
            this.color1.Location = new System.Drawing.Point(700, 348);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(13, 13);
            this.color1.TabIndex = 3;
            this.color1.Text = "  ";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(720, 348);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(0, 13);
            this.Player1.TabIndex = 4;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(720, 368);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(0, 13);
            this.Player2.TabIndex = 6;
            // 
            // color2
            // 
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(700, 368);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(13, 13);
            this.color2.TabIndex = 5;
            this.color2.Text = "  ";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(720, 388);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(0, 13);
            this.Player3.TabIndex = 8;
            // 
            // color3
            // 
            this.color3.AutoSize = true;
            this.color3.Location = new System.Drawing.Point(700, 388);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(13, 13);
            this.color3.TabIndex = 7;
            this.color3.Text = "  ";
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(720, 408);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(0, 13);
            this.Player4.TabIndex = 10;
            // 
            // color4
            // 
            this.color4.AutoSize = true;
            this.color4.Location = new System.Drawing.Point(700, 408);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(13, 13);
            this.color4.TabIndex = 9;
            this.color4.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Este randul tau:";
            // 
            // zarPictureBox
            // 
            this.zarPictureBox.Location = new System.Drawing.Point(555, 348);
            this.zarPictureBox.Name = "zarPictureBox";
            this.zarPictureBox.Size = new System.Drawing.Size(100, 100);
            this.zarPictureBox.TabIndex = 12;
            this.zarPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 464);
            this.Controls.Add(this.zarPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.panelPiticot);
            this.Controls.Add(this.buttonDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDice;
        private System.Windows.Forms.Panel panelPiticot;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label color1;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label color2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label color3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label color4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox zarPictureBox;



    }
}

