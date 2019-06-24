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
        PathFinder pathFinder;
        FlightManager flightManager;

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
            pathFinder = new PathFinder();
            flightManager = new FlightManager();

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
            t = thisGrid.FindTileInRowColumnCoordinates(8, 8);
            t = thisGrid.AddTileAtCoordinates(t, thisEngine.AddNode("DropOff"), "DropOff");
            DropOffTile d = t as DropOffTile;
            DropOff dd = d.nodeInGrid as DropOff;
            dd.FlightID = 111;
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
            thisEngine.Move();

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

                List<GridTile> l1 = new List<GridTile>();
                List<GridTile> l2 = new List<GridTile>();
                (l1, l2) = thisGrid.AutoConnect(selectedTile);
                foreach(GridTile d in l1)
                {
                    thisEngine.ConnectNodes(d.nodeInGrid, selectedTile.nodeInGrid);
                }
                foreach(GridTile d in l2)
                {
                    thisEngine.ConnectNodes(selectedTile.nodeInGrid, d.nodeInGrid);
                }
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
                InfoDisplayer(t);
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
            {
                thisGrid.AutoConnect(selectedTile);
                List<GridTile> l1 = new List<GridTile>();
                List<GridTile> l2 = new List<GridTile>();
                (l1, l2) = thisGrid.AutoConnect(selectedTile);
                foreach (GridTile d in l1)
                {
                    thisEngine.ConnectNodes(d.nodeInGrid, selectedTile.nodeInGrid);
                }
                foreach (GridTile d in l2)
                {
                    thisEngine.ConnectNodes(selectedTile.nodeInGrid, d.nodeInGrid);
                }
            }

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
            else if (rbBranch.Checked)
            {
                buildType = "Branch";
            }
        }

        private void BtnAddFlight_Click(object sender, EventArgs e){

            Random rnd = new Random();
            int id = rnd.Next(1000, 2000);
            while(flightManager.AddFlight(id) == false)
            {
                 id = rnd.Next(1000, 2000);
            }
            listBFlights.Items.Add(flightManager.GetFlightByID(id));

            if (selectedTile != null)
            {
                InfoDisplayer(selectedTile);
            }
        }

        private void CheckInInfoDisplayer(CheckIn ch)
        {
            List<Flight> filter = flightManager.GetFlights().ToList();
            foreach(Flight look in filter.ToList())
            {
                foreach(Flight exist in ch.GetFlights())
                {
                    if(look.FlightID == exist.FlightID)
                    filter.Remove(look);
                }
            }
            listBNodeInfoList.Items.Clear();
            cmBoxCheckInFlights.Items.Clear();
            foreach (Flight f in ch.GetFlights())
            {
                listBNodeInfoList.Items.Add(f);
            }
            foreach(Flight f in filter)
            {
                cmBoxCheckInFlights.Items.Add(f);
            }
        }

        private void InfoDisplayer(GridTile t)
        {
            lblTileCoordinates.Text = t.Column + " " + t.Row;
            if (t.nextTile != null)
                lblNextTile.Text = t.nextTile.Column + " " + t.nextTile.Row;
            else
                lblNextTile.Text = "";

            if(t is CheckInTile)
            {
                CheckInInfoDisplayer(t.nodeInGrid as CheckIn);
            }
            //Console.WriteLine("nani " + pathFinder.FindFinalDropOff(t.nodeInGrid, 0));
        }

        private void BtnFlightToCheckIn_Click(object sender, EventArgs e)
        {
            if(cmBoxCheckInFlights.SelectedItem != null)
            {
                CheckIn ch = selectedTile.nodeInGrid as CheckIn;
                ch.AddFlights(cmBoxCheckInFlights.SelectedItem as Flight);
                MessageBox.Show(ch.GetFlights().Count() + "");
                InfoDisplayer(selectedTile);
            }
        }
    }
}
