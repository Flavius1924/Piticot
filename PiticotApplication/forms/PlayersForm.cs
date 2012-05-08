using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiticotApplication.Forms
{
    public partial class PlayersForm : Form
    {
        private System.Windows.Forms.Label[] label;
        private System.Windows.Forms.TextBox[] textBox;
        private System.Windows.Forms.Button[] playerColor;
        public PlayersForm()
        {
            InitializeComponent();
            label = new Label[4];
            textBox = new TextBox[4];
            playerColor = new Button[4];

            for (int i = 0; i < label.Length; i++)
            {
                label[i] = new Label();
                label[i].AutoSize = true;
                label[i].Location = new System.Drawing.Point(25, 43 + i * 25);
                label[i].Name = "Jucator " + (i + 1).ToString();
                label[i].Size = new System.Drawing.Size(35, 13);
                label[i].TabIndex = i+3;
                label[i].Text = "Jucator " + (i + 1).ToString();
                label[i].Visible = false;
                this.Controls.Add(label[i]);

                textBox[i] = new TextBox();
                textBox[i].Location = new System.Drawing.Point(82, 40 + i * 25);
                textBox[i].Name = "textBox" + (i + 1).ToString();
                textBox[i].Size = new System.Drawing.Size(100, 20);
                textBox[i].TabIndex = i + 4;
                textBox[i].Visible = false;
                this.Controls.Add(textBox[i]);

                playerColor[i] = new Button();
                playerColor[i].Location = new System.Drawing.Point(197, 40 + i * 25);
                playerColor[i].Name = "color";
                playerColor[i].Size = new System.Drawing.Size(21, 21);
                playerColor[i].TabIndex = i+5;
                playerColor[i].Visible = false;
                playerColor[i].Tag = i;
                playerColor[i].BackColor = System.Drawing.SystemColors.ButtonFace;
                playerColor[i].Click += new EventHandler(btnColor_Click);
                this.Controls.Add(this.playerColor[i]);
                toolTip1.SetToolTip(playerColor[i], "Alege culoarea");
            }
        }

        void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Button btn = (Button)sender;
                btn.BackColor = colorDialog1.Color;
                int playerNo = (int)btn.Tag;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int playerNumber = int.Parse(nrPlayers.Text);

            switch (int.Parse(nrPlayers.Text))
            {
                case 2:
                    label[0].Visible = true;
                    label[1].Visible = true;
                    label[2].Visible = false;
                    label[3].Visible = false;
                    textBox[0].Visible = true;
                    textBox[1].Visible = true;
                    textBox[2].Visible = false;
                    textBox[3].Visible = false;
                    playerColor[0].Visible = true;
                    playerColor[1].Visible = true;
                    playerColor[2].Visible = false;
                    playerColor[3].Visible = false;
                    break;
                case 3:
                    label[0].Visible = true;
                    label[1].Visible = true;
                    label[2].Visible = true;
                    label[3].Visible = false;
                    textBox[0].Visible = true;
                    textBox[1].Visible = true;
                    textBox[2].Visible = true;
                    textBox[3].Visible = false;
                    playerColor[0].Visible = true;
                    playerColor[1].Visible = true;
                    playerColor[2].Visible = true;
                    playerColor[3].Visible = false;
                    break;
                case 4:
                    label[0].Visible = true;
                    label[1].Visible = true;
                    label[2].Visible = true;
                    label[3].Visible = true;
                    textBox[0].Visible = true;
                    textBox[1].Visible = true;
                    textBox[2].Visible = true;
                    textBox[3].Visible = true;
                    playerColor[0].Visible = true;
                    playerColor[1].Visible = true;
                    playerColor[2].Visible = true;
                    playerColor[3].Visible = true;
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int numberOfPlayers = 0;
            int.TryParse(nrPlayers.Text, out numberOfPlayers);
            if (numberOfPlayers == 0)
            {
                MessageBox.Show("Alegeti numarul de jucatori!");
                return;
            }
            string[] names = new string[numberOfPlayers];
            Color[] colors = new Color[numberOfPlayers];
            for (int i = 0; i < int.Parse(nrPlayers.Text); i++)
            {
                names[i] = textBox[i].Text;
                if (names[i].Trim() == string.Empty)
                {
                    MessageBox.Show("Completati numele jucatorilor!");
                    return;
                }
                colors[i] = playerColor[i].BackColor;
            }
            //numarul de culori diferite trebuie sa fie egal cu numarul de jucatori
            var colorNo = colors.Select(p => p.Name).Distinct().Count();
            if (names.Count() != colorNo)
            {
                MessageBox.Show("Culorile nu pot fi la fel");
                return;
            }
            MainForm form = new MainForm(this, names, colors);
            form.Show();
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



       /* public void Color_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = (int)((ComboBox)sender).Tag;
            Console.WriteLine(((ComboBox)sender).Text);
            if (((ComboBox)sender).Text.Contains("Blue"))
            {
                label[i].BackColor = Color.Blue;
            }
            else if (((ComboBox)sender).Text.Contains("Red"))
            {
                label[i].BackColor = Color.Red;
            }
            else if (((ComboBox)sender).Text.Contains("Green"))
            {
                label[i].BackColor = Color.Green;
            }
            else if (((ComboBox)sender).Text.Contains("Yellow"))
            {
                label[i].BackColor = Color.Yellow;
            }

        }*/
    }
}
