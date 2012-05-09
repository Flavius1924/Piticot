namespace PiticotApplication.Forms
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.pictureBoxZar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDice
            // 
            this.buttonDice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDice.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonDice.ForeColor = System.Drawing.Color.Blue;
            this.buttonDice.Location = new System.Drawing.Point(786, 256);
            this.buttonDice.Name = "buttonDice";
            this.buttonDice.Size = new System.Drawing.Size(201, 43);
            this.buttonDice.TabIndex = 0;
            this.buttonDice.Text = "ARUNCA ZARUL";
            this.buttonDice.UseVisualStyleBackColor = false;
            this.buttonDice.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // panelPiticot
            // 
            this.panelPiticot.Location = new System.Drawing.Point(12, 12);
            this.panelPiticot.Name = "panelPiticot";
            this.panelPiticot.Size = new System.Drawing.Size(768, 440);
            this.panelPiticot.TabIndex = 1;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(89, 16);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentPlayer.TabIndex = 2;
            this.lblCurrentPlayer.Text = "label1";
            // 
            // color1
            // 
            this.color1.AutoSize = true;
            this.color1.Location = new System.Drawing.Point(10, 38);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(13, 13);
            this.color1.TabIndex = 3;
            this.color1.Text = "  ";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(31, 38);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(13, 13);
            this.Player1.TabIndex = 4;
            this.Player1.Text = "  ";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(31, 59);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(13, 13);
            this.Player2.TabIndex = 6;
            this.Player2.Text = "  ";
            // 
            // color2
            // 
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(10, 59);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(13, 13);
            this.color2.TabIndex = 5;
            this.color2.Text = "  ";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(31, 80);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(13, 13);
            this.Player3.TabIndex = 8;
            this.Player3.Text = "  ";
            // 
            // color3
            // 
            this.color3.AutoSize = true;
            this.color3.Location = new System.Drawing.Point(10, 80);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(13, 13);
            this.color3.TabIndex = 7;
            this.color3.Text = "  ";
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(31, 101);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(13, 13);
            this.Player4.TabIndex = 10;
            this.Player4.Text = "  ";
            // 
            // color4
            // 
            this.color4.AutoSize = true;
            this.color4.Location = new System.Drawing.Point(10, 101);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(13, 13);
            this.color4.TabIndex = 9;
            this.color4.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Este randul tau:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCurrentPlayer);
            this.groupBox1.Controls.Add(this.Player4);
            this.groupBox1.Controls.Add(this.color1);
            this.groupBox1.Controls.Add(this.color4);
            this.groupBox1.Controls.Add(this.Player1);
            this.groupBox1.Controls.Add(this.Player3);
            this.groupBox1.Controls.Add(this.color2);
            this.groupBox1.Controls.Add(this.color3);
            this.groupBox1.Controls.Add(this.Player2);
            this.groupBox1.Location = new System.Drawing.Point(786, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jucatorii";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(786, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "IESIRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Blue;
            this.buttonBack.Location = new System.Drawing.Point(786, 358);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(201, 43);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "INAPOI";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUndo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonUndo.ForeColor = System.Drawing.Color.Blue;
            this.buttonUndo.Location = new System.Drawing.Point(786, 307);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(201, 43);
            this.buttonUndo.TabIndex = 0;
            this.buttonUndo.Text = "UNDO";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // pictureBoxZar
            // 
            this.pictureBoxZar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxZar.Location = new System.Drawing.Point(877, 140);
            this.pictureBoxZar.Name = "pictureBoxZar";
            this.pictureBoxZar.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxZar.TabIndex = 13;
            this.pictureBoxZar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ai dat cu zarul:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(999, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxZar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelPiticot);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piticot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZar)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.PictureBox pictureBoxZar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;



    }
}

