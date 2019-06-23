using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConveyorMyWay
{
    class GridTile
    {
        private int column;
        private int row;

        public Node nodeInGrid;
        public GridTile nextTile;

        public Brush fillBrush;

        public GridTile(int c, int r, int tileWidth, int tileHeight)
        {
            column = c;
            row = r;
        }

        public int Column
        {
            get { return column; }
        }
        public int Row
        {
            get { return row; }
        }

        public virtual void DrawTile(PaintEventArgs e, int tileWidth, int tileHeight)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red);
            Rectangle r = new Rectangle(column * tileWidth, row * tileHeight, tileWidth, tileHeight);

            g.FillRectangle(fillBrush, r);
            g.DrawRectangle(p, r);

            DrawBaggage(g, tileWidth, tileHeight);
            DrawArrowNext(g, p, tileWidth, tileHeight);
        }

        private void DrawBaggage(Graphics g, int tileWidth, int tileHeight)
        {
            if(nodeInGrid != null)
            {
                if(nodeInGrid.baggageHeld != null)
                {
                    RectangleF baggageRec = new RectangleF(column * tileWidth + 10, row * tileHeight + 10, tileWidth - 20, tileHeight - 20);
                    g.FillRectangle(Brushes.Brown, baggageRec);
                }
            }
        }

        private void DrawArrowNext(Graphics g, Pen p, int tileWidth, int tileHeight)
        {
            if(nextTile != null)
            {
                if (nextTile.Column < this.column)
                {                 
                    g.DrawLine(p, (column * tileWidth + tileWidth / 2), (row * tileHeight + tileHeight / 2), column * tileWidth, row * tileHeight + tileHeight / 2);
                }
                else if (nextTile.Column > this.column)
                {
                    g.DrawLine(p, (column * tileWidth + tileWidth / 2), (row * tileHeight + tileHeight / 2), column * tileWidth + tileWidth, row * tileHeight + tileHeight / 2);
                }
                else if (nextTile.Row < this.row)
                    g.DrawLine(p, (column * tileWidth + tileWidth / 2), (row * tileHeight + tileHeight / 2), column * tileWidth + tileWidth / 2, row * tileHeight);
                else if (nextTile.Row > this.row)
                    g.DrawLine(p, (column * tileWidth + tileWidth / 2), (row * tileHeight + tileHeight / 2), column * tileWidth + tileWidth / 2, row * tileHeight + tileHeight);
            }
        }
    }
}
