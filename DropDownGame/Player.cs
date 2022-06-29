using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownGame
{
    public class Player
    {
        public PictureBox player { get; set; }
        public int gravity { get; set; } = 6;
        public int score { get; set; } = 0;
        public int speed { get; set; } = 10;
        public bool moveLeft { get; set; } = false;
        public bool moveRight { get; set; } = false;

        public Player(PictureBox player)
        {
            this.player = player;
        }
    }
}
