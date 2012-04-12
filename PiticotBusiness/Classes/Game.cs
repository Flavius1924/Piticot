using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PiticotBusiness.Classes.Dice;
using PiticotBusiness.Classes.Cells;

namespace PiticotBusiness.Classes
{
    public class Game
    {
        #region members
        public List<Cell> Cells { get; set; }
        public Player CurrentPlayer { get; set; }
        private int TargetCellNumber { get; set; }
        public event EventHandler game_Move;
        public event EventHandler player_Changed;
        public bool IsFinished = false;
        private Queue<Player> PlayersQueue;
        public List<Player> PlayerList
        {
            get
            {
                return PlayersQueue.ToList();
            }
        }

        #endregion

        #region methods
        public Game(List<Player> playerList)
        {
            IsFinished = false;
            Cells = new List<Cell>();
            PlayersQueue = new Queue<Player>();
            //Console.WriteLine("Doriti sa definiti nr de celule? D/N");
            // if (console.readline() == "D") { InitializeGame(playerList, numberOfCells); }
            InitializeGame(playerList);
        }

        private void InitializeGame(List<Player> playerList, int cellNo = 50)
        {
            GenerateCells(cellNo);
            foreach (var player in playerList)
            {
                player.CurrentCell = Cells[0];
                PlayersQueue.Enqueue(player);
            }
        }

        private void GenerateCells(int cellNo)
        {
           /* char[] cells = readTable();

            for (int i = 0; i < cells.Length; i++)
            {
                switch (cells[i])
                {
                    case 'n':
                        PlaceCell(new NormalCell() { Number = i });
                        break;
                    case 'l':
                        PlaceCell(new WolfCell { Number = i });
                        break;
                }

            }*/
            for (int i = 0; i < cellNo; i++)
            {   
                if (i == 2)
                {
                    PlaceCell(new WolfCell { Number = i });
                }
                else
                {
                    PlaceCell(new NormalCell() { Number = i });
                }
            }
           
        }
       
        public void NextPlayer()
        {
            CurrentPlayer = PlayersQueue.Dequeue();
            PlayersQueue.Enqueue(CurrentPlayer);
            player_Changed(CurrentPlayer, EventArgs.Empty);
        }

        private void PlaceCell(Cell cell)
        {
            TargetCellNumber = cell.Number;
            Cells.Add(cell);
        }
        private char[] readTable()
        {
            string text = System.IO.File.ReadAllText(@".\GameTable\tabla1.txt");
            char[] cells = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                cells[i] = text[i];
            }
            return cells;

        }
        public int ThrowDice()
        {
            return GameDice.GetInstance().Throw();
        }

        #endregion

        #region GAME_LOGIC
        public void Move(int numberOfSteps)
        {
            int currentCellNumber = CurrentPlayer.CurrentCell.Number;
            CurrentPlayer.PreviousCellNumber = currentCellNumber;
            currentCellNumber += numberOfSteps;
            if (currentCellNumber >= TargetCellNumber)
            {
                currentCellNumber = TargetCellNumber;
                this.IsFinished = true;
                CurrentPlayer.HasWon = true;
            }
            CurrentPlayer.CurrentCell = Cells[currentCellNumber];
            game_Move(this, EventArgs.Empty);
            if (!this.IsFinished) Cells[currentCellNumber].Act(this);
        }

        #endregion
    }
}
