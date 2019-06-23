using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ConveyorMyWay
{
    public partial class Form1 : Form
    {
        Grid thisGrid;
        Engine thisEngine;

        string buildType;
        bool inBuildMode;
        bool isBuildingConveyor;
        bool isConnecting;

        GridTile selectedTile;
        public Form1()
        {
            InitializeComponent();
            grBoxBuildType.Visible = false;

            thisGrid = new Grid(animationBox.Width, animationBox.Height);
            thisEngine = new Engine();

            buildType = "Conveyor";
            isBuildingConveyor = false;
            isConnecting = false;

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimerSequence);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

            GridTile t = thisGrid.FindTileInRowColumnCoordinates(0, 0);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            t = thisGrid.FindTileInRowColumnCoordinates(0, 1);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            t = thisGrid.FindTileInRowColumnCoordinates(0, 2);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            t = thisGrid.FindTileInRowColumnCoordinates(0, 3);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            t = thisGrid.FindTileInRowColumnCoordinates(1, 3);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            t = thisGrid.FindTileInRowColumnCoordinates(2, 3);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
            Conveyor c = thisEngine.firstConveyor();
            c.baggageHeld = new Baggage();
            List<Conveyor> conveyors = thisEngine.GetConveyors();
            for(int i = 0; i < conveyors.Count - 1; i++)
            {
                thisEngine.ConnectNodes(conveyors[i], conveyors[i+1]);
            }
        }

        private void TimerSequence(object source, ElapsedEventArgs e)
        {
            thisEngine.MoveNodes();

            animationBox.Invalidate(); 
        }

        private void AnimationBox_Paint(object sender, PaintEventArgs e)
        {
            thisGrid.DrawGrid(e);
        }

        private void AnimationBox_MouseDown(object sender, MouseEventArgs e)
        {
            var mouseClick = e as MouseEventArgs;
            GridTile t = thisGrid.FindTileInPixelCoordinates(mouseClick.X, mouseClick.Y);

            if(inBuildMode && t is EmptyTile)
            {
                selectedTile = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
                if(selectedTile is ConveyorTile)
                    isBuildingConveyor = true;
                thisGrid.AutoConnect(selectedTile);
            }
            if(inBuildMode && !(t is EmptyTile))
            {
                selectedTile = t;
                isConnecting = true;
            }

            lblTileCoordinates.Text = "";
            lblNextTile.Text = "";

            if(inBuildMode == false)
            {
                lblTileCoordinates.Text = t.Column + " " + t.Row;
                if (t.nextTile != null)
                    lblNextTile.Text = t.nextTile.Column + " " + t.nextTile.Row;
                else
                    lblNextTile.Text = "";
            }

            animationBox.Invalidate();
        }

        private void AnimationBox_MouseMove(object sender, MouseEventArgs e)
        {
            var mouseClick = e as MouseEventArgs;
            GridTile t = thisGrid.FindTileInPixelCoordinates(mouseClick.X, mouseClick.Y);

            if (isBuildingConveyor && thisGrid.CheckIfNeighbours(selectedTile, t) && t is EmptyTile)
            {
                t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode(buildType), buildType);
                thisGrid.ConnectTiles(selectedTile, t);
                thisEngine.ConnectNodes(selectedTile.nodeInGrid, t.nodeInGrid);
                selectedTile = t;
            }
            if (isConnecting && thisGrid.CheckIfNeighbours(selectedTile, t) && !(t is EmptyTile))
            {
                thisGrid.ConnectTiles(selectedTile, t);
                thisEngine.ConnectNodes(selectedTile.nodeInGrid, t.nodeInGrid);
                selectedTile = t;
                isConnecting = false;
            }

            animationBox.Invalidate();
        }
        private void AnimationBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isBuildingConveyor)
                thisGrid.AutoConnect(selectedTile);

            isBuildingConveyor = false;
            isConnecting = false;

            animationBox.Invalidate();
        }
        private void ChBoxBuildMode_CheckedChanged(object sender, EventArgs e)
        {
            switch (chBoxBuildMode.Checked)
            {
                case true:
                    inBuildMode = true;
                    grBoxBuildType.Visible = true;
                    rbCheckIn.Checked = true;
                    break;
                case false:
                    inBuildMode = false;
                    grBoxBuildType.Visible = false;
                    break;
            }
        }
        public void BuildTypeChanged(object sender, EventArgs e)
        {
            if (rbCheckIn.Checked)
            {
                buildType = "CheckIn";
            }
            else if (rbConveyor.Checked)
            {
                buildType = "Conveyor";
            }
            else if (rbDropOff.Checked)
            {
                buildType = "DropOff";
            }
        }
    }
}
