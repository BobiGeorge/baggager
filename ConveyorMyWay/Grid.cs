using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConveyorMyWay
{
    class Grid
    {
        int tileWidth;
        int tileHeight;
        int tileHorizontalCount = 10;
        int tileVerticalCount = 10;
        float animBoxWidth;
        float animBoxHeigth;

        public List<GridTile> gridTiles;

        public Grid(int animBoxW, int animBoxH)
        {
            gridTiles = new List<GridTile>();

            animBoxWidth = animBoxW;
            animBoxHeigth = animBoxH;
            tileWidth = (int)(animBoxWidth - 1) / tileHorizontalCount;
            tileHeight = (int)(animBoxHeigth - 1) / tileVerticalCount;

            CreateGrid();
        }

        private void CreateGrid()
        {
            for (int c = 0; c < tileHorizontalCount; c++)
            {
                for (int r = 0; r < tileVerticalCount; r++)
                {
                    gridTiles.Add(new EmptyTile(c, r, tileWidth, tileHeight));
                }
            }
        }
        public void DrawGrid(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (GridTile n in gridTiles)
            {
                n.DrawTile(e, tileWidth, tileHeight);
            }
        }
        public GridTile FindTileInPixelCoordinates(float targetX, float targetY)
        {
            GridTile foundTile = new EmptyTile(-1, -1, tileWidth, tileHeight);
            foreach (GridTile n in gridTiles)
            {
                if ((n.Column * tileWidth) <= targetX && (n.Column * tileWidth) + tileWidth >= targetX && (n.Row * tileHeight) <= targetY && (n.Row * tileHeight) + tileHeight >= targetY)
                {
                    foundTile = n;
                    break;
                }
            }
            return foundTile;
        }
        public GridTile FindTileInRowColumnCoordinates(int targetColumn, int targetRow)
        {
            GridTile foundTile = new EmptyTile(targetColumn, targetRow, tileWidth, tileHeight);
            foreach (GridTile n in gridTiles)
            {
                if (n.Column == targetColumn && n.Row == targetRow)
                {
                    foundTile = n;
                    return foundTile;
                }
            }
            return foundTile;
        }
        public void ConnectTiles(GridTile selected, GridTile target)
        {
            selected.nextTile = target;
        }
        public bool CheckIfNeighbours(GridTile selected, GridTile target)
        {
            if((Math.Abs(target.Column - selected.Column) == 1 && Math.Abs(target.Row - selected.Row) == 0) || (Math.Abs(target.Column - selected.Column) == 0 && Math.Abs(target.Row - selected.Row) == 1))
            {
                return true;
            }
            return false;
        }

        public GridTile AddTileAtCoordinates(GridTile toReplace, Node newNode, string buildType)
        {
            GridTile t = null;
            switch (buildType)
            {
                case "Conveyor":
                    t = new ConveyorTile(toReplace.Column, toReplace.Row, tileWidth, tileHeight);
                    break;
                case "CheckIn":
                    t = new CheckInTile(toReplace.Column, toReplace.Row, tileWidth, tileHeight);
                    break;
                case "DropOff":
                    t = new DropOffTile(toReplace.Column, toReplace.Row, tileWidth, tileHeight);
                    break;
                case "Branch":
                    t = new BranchTile(toReplace.Column, toReplace.Row, tileWidth, tileHeight);
                    break;
            }
            gridTiles.Remove(toReplace);
            gridTiles.Add(t);
            t.nodeInGrid = newNode;
            return t;
        }

        //holy cow I just learned about tuples this is awesome!
        public (List<GridTile>, List<GridTile>) AutoConnect(GridTile selected)
        {
            List<GridTile> connectors = new List<GridTile>();
            List<GridTile> connectees = new List<GridTile>();

            if (selected is CheckInTile)
            {
                GridTile target = FindTileInRowColumnCoordinates(selected.Column, selected.Row + 1);
                if (!(target is EmptyTile))
                {
                    ConnectTiles(selected, target);
                    connectees.Add(target);
                }
            }
            else if(selected is DropOffTile)
            {
                GridTile target = FindTileInRowColumnCoordinates(selected.Column, selected.Row - 1);
                if (!(target is EmptyTile))
                {
                    ConnectTiles(target, selected);
                    connectors.Add(target);
                }
            }
            else if(selected != null)
            {
                List<GridTile> targets = GetNeighboursIn4Directions(selected); 
                foreach(GridTile target in targets)
                {
                    if (target.nextTile == null && !(target is EmptyTile) && !(target is DropOffTile))
                    {
                        ConnectTiles(target, selected);
                        connectors.Add(target);
                    }
                    else if (target is DropOffTile)
                    {
                        ConnectTiles(selected, target);
                        connectees.Add(target);
                    }
                    else if (target.nextTile != null && !(target is EmptyTile) && target.nextTile != selected)
                    {
                        ConnectTiles(selected, target);
                        connectees.Add(target);
                    }
                }
            }
            return (connectors, connectees);
        }
        public List<GridTile> GetNeighboursIn4Directions(GridTile c)
        {
            List<GridTile> tempTiles = new List<GridTile>();
            tempTiles.Add(FindTileInRowColumnCoordinates(c.Column, c.Row - 1));
            tempTiles.Add(FindTileInRowColumnCoordinates(c.Column, c.Row + 1));
            tempTiles.Add(FindTileInRowColumnCoordinates(c.Column + 1, c.Row));
            tempTiles.Add(FindTileInRowColumnCoordinates(c.Column - 1, c.Row));

            foreach (GridTile t in tempTiles.ToList())
            {
                if (t == null)
                {
                    tempTiles.Remove(t);
                }
            }
            return tempTiles;
        }
        public List<GridTile> GetTopNeighbour(GridTile c)
        {
            GridTile temp = FindTileInRowColumnCoordinates(c.Column, c.Row - 1);
            List<GridTile> tempList = new List<GridTile>();
            tempList.Add(temp);
            return tempList;
        }
        public List<GridTile> GetBottomNeighbour(GridTile c)
        {
            GridTile temp = FindTileInRowColumnCoordinates(c.Column, c.Row + 1);
            List<GridTile> tempList = new List<GridTile>();
            tempList.Add(temp);
            return tempList;
        }
    }
}
