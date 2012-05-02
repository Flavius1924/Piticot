namespace PiticotApplication.Forms
{
    partial class PlayersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nrPlayers = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectati numarul de jucatori";
            // 
            // nrPlayers
            // 
            this.nrPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nrPlayers.FormattingEnabled = true;
            this.nrPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.nrPlayers.Location = new System.Drawing.Point(158, 13);
            this.nrPlayers.Name = "nrPlayers";
            this.nrPlayers.Size = new System.Drawing.Size(55, 21);
            this.nrPlayers.TabIndex = 1;
            this.nrPlayers.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(242, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(59, 21);
            this.startButton.TabIndex = 50;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.Color = System.Drawing.Color.Gray;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(313, 167);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nrPlayers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jucatori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nrPlayers;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}