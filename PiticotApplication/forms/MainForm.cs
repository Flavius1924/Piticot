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
using PiticotBusiness.Classes.Command;

namespace PiticotApplication.Forms
{
    public partial class MainForm : Form
    {
        #region methods
        public MainForm()
        {
            InitializeComponent();
            TABLE_WIDTH = panelPiticot.Width;
            TABLE_HEIGHT = panelPiticot.Height;
            CELL_WIDTH = TABLE_WIDTH / 10; // trebuie luat dupa numarul de celule
            CELL_HEIGHT = TABLE_HEIGHT / 6;
            buttons = new List<Button>();

        }
        //constructor ptr form1 ca sa poata sa pot da show si la form2 cand inchizi jocul
        public MainForm(Forms.PlayersForm form2, string[] names, Color[] colors)
        {
            this.colors = colors;
            this.names = names;
            this.form2 = form2;
            InitializeComponent();
            TABLE_WIDTH = panelPiticot.Width;
            TABLE_HEIGHT = panelPiticot.Height;
            CELL_WIDTH = TABLE_WIDTH / 10; 
            CELL_HEIGHT = TABLE_HEIGHT / 6;
            buttons = new List<Button>();
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
            button.BackColor = System.Drawing.Color.White;
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
            lblCurrentPlayer.BackColor = player.Color;
            buttons[player.CurrentCell.Number].BackColor = player.Color;
        }

        private void NewGame()
        {
            cmdManager = new CommandManager();
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
            game = new Game(players);
            InitializeView();
            game.NextPlayer();
        }
        #endregion

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonDice_Click(object sender, EventArgs e)
        {
            int dice = game.ThrowDice();
            cmdManager.ExecuteCommand(new MoveCommand(game, dice));
            //game.Move(dice);
            //game.NextPlayer();
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
                button.BackColor = System.Drawing.Color.White;
            }
            foreach (var player in game.PlayerList)
            {
                buttons[player.CurrentCell.Number].BackColor = player.Color;
            }

            if (game.IsFinished)
            {
                MessageBox.Show("Joc terminat");
                NewGame();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            cmdManager.Undo();
        }

        #endregion

        #region members
        private Game game;
        private List<Button> buttons = null;
        private readonly int TABLE_WIDTH = 0;
        private readonly int TABLE_HEIGHT = 0;
        private readonly int CELL_HEIGHT = 0;
        private readonly int CELL_WIDTH = 0;
        private Forms.PlayersForm form2;
        private string[] names;
        private Color[] colors;
        private CommandManager cmdManager;
        #endregion

    }
}
