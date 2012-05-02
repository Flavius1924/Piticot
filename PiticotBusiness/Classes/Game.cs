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
            InitializeGame(playerList);
        }

        private void InitializeGame(List<Player> playerList, int cellNo = 60)
        {
            GenerateCells(cellNo);
            foreach (var player in playerList)
            {
                player.CurrentCell = Cells[0];
                PlayersQueue.Enqueue(player);
            }
        }

        private const string TABLE = @"N N N F D W N N N F
                                       N D W N N N F N W N
                                       N N N W N N D F N N
                                       N F N F f F N N N F
                                       D N N N W N N W N N
                                       D F N N N F W F W N";

        private void GenerateCells(int cellNo)
        {
            int cellIndex = 0;
            for (int i = 0; i < TABLE.Length; i++)
            {
                switch (TABLE[i])
                {
                    case 'N':
                        PlaceCell(new NormalCell { Number = cellIndex++ });
                        break;
                    case 'F':
                        PlaceCell(new FoxCell { Number = cellIndex++ });
                        break;
                    case 'W':
                        PlaceCell(new WolfCell { Number = cellIndex++ });
                        break;
                    case 'f':
                        PlaceCell(new FairyCell { Number = cellIndex++ });
                        break;
                    case 'D':
                        PlaceCell(new DwarfCell { Number = cellIndex++ });
                        break;
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
        internal void Move(int numberOfSteps)
        {
            int currentCellNumber = CurrentPlayer.CurrentCell.Number;
            CurrentPlayer.PreviousCellNumber = currentCellNumber;
            currentCellNumber += numberOfSteps;
            if (CurrentPlayer.HasWon)
            {
                currentCellNumber = TargetCellNumber;
                this.IsFinished = true;
            }
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
