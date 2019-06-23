using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorMyWay
{
    class DropOffTile : GridTile
    {
        public DropOffTile(int c, int r, int tileWidth, int tileHeight) : base(c, r, tileWidth, tileHeight)
        {
            fillBrush = Brushes.Purple;
        }
    }
}
