using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BackgammonProject2
{
    class Player
    {
        private int playerNum;
        private string color;
        private bool eatenTools;
        private string playerName;
        private Image playerImg;

        public Player(int num, string color, bool eatenTools, string name, Image img)
        {
            this.PlayerNum = num;
            this.Color = color;
            this.EatenTools = eatenTools;
            this.playerName = name;
            this.playerImg = img;
         }

        public int PlayerNum { get => playerNum; set => playerNum = value; }
        public string Color { get => color; set => color = value; }
        public bool EatenTools { get => eatenTools; set => eatenTools = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public Image PlayerImg { get => playerImg; set => playerImg = value; }
    }
}
