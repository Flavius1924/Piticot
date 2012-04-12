using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PiticotBusiness.Classes.Cells;
using PiticotBusiness.Classes;
using PiticotBusiness.Classes.Dice;
using PiticotApplication.Properties;
using System.Diagnostics;



namespace PiticotApplication
{
    public partial class Form1 : Form//, IPlayable
    {
        #region methods
        public Form1()
        {
            InitializeComponent();
            TABLE_WIDTH = panelPiticot.Width;
            TABLE_HEIGHT = panelPiticot.Height;
            CELL_WIDTH = TABLE_WIDTH / 10; // trebuie luat dupa numarul de celule
            CELL_HEIGHT = TABLE_HEIGHT / 5;
            buttons = new List<Button>();
        
        }
        //constructor ptr form1 ca sa poata sa pot da show si la form2 cand inchizi jocul
        public Form1(Forms.Form2 form2,string[] names, Color[] colors)
        {
            // TODO: Complete member initialization
            this.colors = colors;
            this.names = names;
            this.form2 = form2;
            InitializeComponent();
            TABLE_WIDTH = panelPiticot.Width;
            TABLE_HEIGHT = panelPiticot.Height;
            CELL_WIDTH = TABLE_WIDTH / 10; // trebuie luat dupa numarul de celule
            CELL_HEIGHT = TABLE_HEIGHT / 5;
            buttons = new List<Button>();
            for (int i = 0; i < 6; i++)
            {
                pics[i] = new PictureBox();
            }
            pics[0].Image = Resources._1;
            pics[1].Image = Resources._2;
            pics[2].Image = Resources._3;
            pics[3].Image = Resources._4;
            pics[4].Image = Resources._5;
            pics[5].Image = Resources._6;
        }

        private void PlaceCell(Cell cell, int x, int y)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            button.Name = cell.Number.ToString();
            button.Size = new System.Drawing.Size(CELL_WIDTH, CELL_HEIGHT);
            button.TabIndex = 0;
            button.Text = cell.Name;
            button.Tag = cell;
            button.UseVisualStyleBackColor = true;
            button.BackColor = System.Drawing.SystemColors.Control;
            this.panelPiticot.Controls.Add(button);
            buttons.Add(button);
        }

        private void InitializeView()
        {
            int x = 0;
            int y = 0;
            int xMax = TABLE_WIDTH / CELL_WIDTH;
            foreach (var item in game.Cells)
            {
                x = item.Number % xMax;
                y = item.Number / xMax;
                PlaceCell(item, x * CELL_WIDTH, y * CELL_HEIGHT);
            }
            game.game_Move += new EventHandler(game_Move);
            game.player_Changed += new EventHandler(player_Changed);
        }

        void player_Changed(object sender, EventArgs e)
        {
            Player player = (Player)sender;
            lblCurrentPlayer.Text = player.Name;
            buttons[player.CurrentCell.Number].BackColor = player.Color;
        }

        private void NewGame()
        {
           this.panelPiticot.Controls.Clear();
            buttons.Clear();
            List<Player> players = new List<Player>();
            for (int i = 0; i < names.Length; i++)
            {
                players.Add(new Player { Name = names[i], Color = colors[i], Number = 0 });

                switch (i)
                {
                    case 1:
                        this.color1.BackColor = colors[0];
                        this.color2.BackColor = colors[1];
                        this.Player1.Text = names[0];
                        this.Player2.Text = names[1];
                        break;
                    case 2:
                        this.Player3.Text = names[2];
                        this.color3.BackColor = colors[2];
                        break;
                    case 3:
                        this.Player4.Text = names[3];
                        this.color4.BackColor = colors[3];
                        break;
                }
            }
            //players.Add(new Player { Name = "mihai", Color = Color.Red, Number = 1 });
            //players.Add(new Player { Name = "gigi", Color = Color.Yellow, Number = 2 });
            game = new Game(players);
            InitializeView();
            game.NextPlayer();
        }
        /*public void ShuffleDice()
        {
            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
               
               Stopwatch  stopwatch = Stopwatch.StartNew();
                while (true)
                {
                    zarPictureBox.Image = pics[r.Next(0, 5) + 1].Image;
                    if (stopwatch.ElapsedMilliseconds >=500)
                    {
                        break;
                    }
                }
           }
        }*/

        #endregion

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonDice_Click(object sender, EventArgs e)
        {
           // ShuffleDice();
            int dice = game.ThrowDice();
            zarPictureBox.Image = pics[dice-1].Image;
            game.Move(dice);
            game.NextPlayer();
        }

        void game_Move(object sender, EventArgs e)
        {
            Game game = (Game)sender;
            Player playerCurrent = game.CurrentPlayer;
            if (!string.IsNullOrEmpty(playerCurrent.CurrentCell.Message))
            {
                MessageBox.Show(playerCurrent.CurrentCell.Message);
            }
            foreach (var button in buttons)
            {
                button.BackColor = System.Drawing.SystemColors.Control;
            }
            foreach (var player in game.PlayerList)
            {
                buttons[player.CurrentCell.Number].BackColor = player.Color;
            }
            // se redeseneaza nasol daca un jucator se muta dintr-un loc unde mai erau si alti jucatori

            if (game.IsFinished)
            {
                MessageBox.Show("Joc terminat");
                NewGame();
            }
        }

        #endregion

        #region members
        private Game game;
        private List<Button> buttons = null;
        private readonly int TABLE_WIDTH = 0;
        private readonly int TABLE_HEIGHT = 0;
        private readonly int CELL_HEIGHT = 0;
        private readonly int CELL_WIDTH = 0;
        private Forms.Form2 form2;
        private string[] names;
        private Color[] colors;
        PictureBox[] pics = new PictureBox[6];
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }

     

    }
}
