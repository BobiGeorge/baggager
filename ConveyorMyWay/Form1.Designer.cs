namespace ConveyorMyWay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animationBox = new System.Windows.Forms.PictureBox();
            this.grBoxBuildType = new System.Windows.Forms.GroupBox();
            this.rbBranch = new System.Windows.Forms.RadioButton();
            this.rbDropOff = new System.Windows.Forms.RadioButton();
            this.rbConveyor = new System.Windows.Forms.RadioButton();
            this.rbCheckIn = new System.Windows.Forms.RadioButton();
            this.chBoxBuildMode = new System.Windows.Forms.CheckBox();
            this.grBoxTileInfo = new System.Windows.Forms.GroupBox();
            this.btnFlightToCheckIn = new System.Windows.Forms.Button();
            this.cmBoxNodeFlights = new System.Windows.Forms.ComboBox();
            this.lblNextTile = new System.Windows.Forms.Label();
            this.lblTileCoordinates = new System.Windows.Forms.Label();
            this.listBFlights = new System.Windows.Forms.ListBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.listBNodeInfoList = new System.Windows.Forms.ListBox();
            this.tbBaggageAmount = new System.Windows.Forms.TextBox();
            this.btnFlightToDropOff = new System.Windows.Forms.Button();
            this.lblDropOffFLID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animationBox)).BeginInit();
            this.grBoxBuildType.SuspendLayout();
            this.grBoxTileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationBox
            // 
            this.animationBox.Location = new System.Drawing.Point(287, 12);
            this.animationBox.Name = "animationBox";
            this.animationBox.Size = new System.Drawing.Size(884, 515);
            this.animationBox.TabIndex = 0;
            this.animationBox.TabStop = false;
            this.animationBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AnimationBox_Paint);
            this.animationBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseDown);
            this.animationBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseMove);
            this.animationBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseUp);
            // 
            // grBoxBuildType
            // 
            this.grBoxBuildType.Controls.Add(this.rbBranch);
            this.grBoxBuildType.Controls.Add(this.rbDropOff);
            this.grBoxBuildType.Controls.Add(this.rbConveyor);
            this.grBoxBuildType.Controls.Add(this.rbCheckIn);
            this.grBoxBuildType.Location = new System.Drawing.Point(12, 68);
            this.grBoxBuildType.Name = "grBoxBuildType";
            this.grBoxBuildType.Size = new System.Drawing.Size(175, 127);
            this.grBoxBuildType.TabIndex = 1;
            this.grBoxBuildType.TabStop = false;
            this.grBoxBuildType.Text = "BuildType";
            // 
            // rbBranch
            // 
            this.rbBranch.AutoSize = true;
            this.rbBranch.Location = new System.Drawing.Point(6, 100);
            this.rbBranch.Name = "rbBranch";
            this.rbBranch.Size = new System.Drawing.Size(74, 21);
            this.rbBranch.TabIndex = 4;
            this.rbBranch.TabStop = true;
            this.rbBranch.Text = "Branch";
            this.rbBranch.UseVisualStyleBackColor = true;
            this.rbBranch.CheckedChanged += new System.EventHandler(this.BuildTypeChanged);
            // 
            // rbDropOff
            // 
            this.rbDropOff.AutoSize = true;
            this.rbDropOff.Location = new System.Drawing.Point(6, 75);
            this.rbDropOff.Name = "rbDropOff";
            this.rbDropOff.Size = new System.Drawing.Size(79, 21);
            this.rbDropOff.TabIndex = 4;
            this.rbDropOff.TabStop = true;
            this.rbDropOff.Text = "DropOff";
            this.rbDropOff.UseVisualStyleBackColor = true;
            this.rbDropOff.CheckedChanged += new System.EventHandler(this.BuildTypeChanged);
            // 
            // rbConveyor
            // 
            this.rbConveyor.AutoSize = true;
            this.rbConveyor.Location = new System.Drawing.Point(6, 48);
            this.rbConveyor.Name = "rbConveyor";
            this.rbConveyor.Size = new System.Drawing.Size(89, 21);
            this.rbConveyor.TabIndex = 3;
            this.rbConveyor.TabStop = true;
            this.rbConveyor.Text = "Conveyor";
            this.rbConveyor.UseVisualStyleBackColor = true;
            this.rbConveyor.CheckedChanged += new System.EventHandler(this.BuildTypeChanged);
            // 
            // rbCheckIn
            // 
            this.rbCheckIn.AutoSize = true;
            this.rbCheckIn.Location = new System.Drawing.Point(6, 21);
            this.rbCheckIn.Name = "rbCheckIn";
            this.rbCheckIn.Size = new System.Drawing.Size(79, 21);
            this.rbCheckIn.TabIndex = 2;
            this.rbCheckIn.TabStop = true;
            this.rbCheckIn.Text = "CheckIn";
            this.rbCheckIn.UseVisualStyleBackColor = true;
            this.rbCheckIn.CheckedChanged += new System.EventHandler(this.BuildTypeChanged);
            // 
            // chBoxBuildMode
            // 
            this.chBoxBuildMode.AutoSize = true;
            this.chBoxBuildMode.Location = new System.Drawing.Point(18, 26);
            this.chBoxBuildMode.Name = "chBoxBuildMode";
            this.chBoxBuildMode.Size = new System.Drawing.Size(100, 21);
            this.chBoxBuildMode.TabIndex = 2;
            this.chBoxBuildMode.Text = "Build Mode";
            this.chBoxBuildMode.UseVisualStyleBackColor = true;
            this.chBoxBuildMode.CheckedChanged += new System.EventHandler(this.ChBoxBuildMode_CheckedChanged);
            // 
            // grBoxTileInfo
            // 
            this.grBoxTileInfo.Controls.Add(this.btnFlightToDropOff);
            this.grBoxTileInfo.Controls.Add(this.btnFlightToCheckIn);
            this.grBoxTileInfo.Controls.Add(this.cmBoxNodeFlights);
            this.grBoxTileInfo.Controls.Add(this.lblNextTile);
            this.grBoxTileInfo.Controls.Add(this.lblTileCoordinates);
            this.grBoxTileInfo.Location = new System.Drawing.Point(3, 362);
            this.grBoxTileInfo.Name = "grBoxTileInfo";
            this.grBoxTileInfo.Size = new System.Drawing.Size(143, 193);
            this.grBoxTileInfo.TabIndex = 3;
            this.grBoxTileInfo.TabStop = false;
            this.grBoxTileInfo.Text = "TileInfo";
            // 
            // btnFlightToCheckIn
            // 
            this.btnFlightToCheckIn.Location = new System.Drawing.Point(9, 109);
            this.btnFlightToCheckIn.Name = "btnFlightToCheckIn";
            this.btnFlightToCheckIn.Size = new System.Drawing.Size(128, 50);
            this.btnFlightToCheckIn.TabIndex = 7;
            this.btnFlightToCheckIn.Text = "Add flight to check in";
            this.btnFlightToCheckIn.UseVisualStyleBackColor = true;
            this.btnFlightToCheckIn.Click += new System.EventHandler(this.BtnFlightToCheckIn_Click);
            // 
            // cmBoxNodeFlights
            // 
            this.cmBoxNodeFlights.FormattingEnabled = true;
            this.cmBoxNodeFlights.Location = new System.Drawing.Point(9, 79);
            this.cmBoxNodeFlights.Name = "cmBoxNodeFlights";
            this.cmBoxNodeFlights.Size = new System.Drawing.Size(121, 24);
            this.cmBoxNodeFlights.TabIndex = 6;
            // 
            // lblNextTile
            // 
            this.lblNextTile.AutoSize = true;
            this.lblNextTile.Location = new System.Drawing.Point(58, 51);
            this.lblNextTile.Name = "lblNextTile";
            this.lblNextTile.Size = new System.Drawing.Size(46, 17);
            this.lblNextTile.TabIndex = 5;
            this.lblNextTile.Text = "label1";
            // 
            // lblTileCoordinates
            // 
            this.lblTileCoordinates.AutoSize = true;
            this.lblTileCoordinates.Location = new System.Drawing.Point(58, 34);
            this.lblTileCoordinates.Name = "lblTileCoordinates";
            this.lblTileCoordinates.Size = new System.Drawing.Size(46, 17);
            this.lblTileCoordinates.TabIndex = 4;
            this.lblTileCoordinates.Text = "label1";
            // 
            // listBFlights
            // 
            this.listBFlights.FormattingEnabled = true;
            this.listBFlights.ItemHeight = 16;
            this.listBFlights.Location = new System.Drawing.Point(12, 202);
            this.listBFlights.Name = "listBFlights";
            this.listBFlights.Size = new System.Drawing.Size(175, 84);
            this.listBFlights.TabIndex = 4;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(12, 331);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(85, 34);
            this.btnAddFlight.TabIndex = 5;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.BtnAddFlight_Click);
            // 
            // listBNodeInfoList
            // 
            this.listBNodeInfoList.FormattingEnabled = true;
            this.listBNodeInfoList.ItemHeight = 16;
            this.listBNodeInfoList.Location = new System.Drawing.Point(152, 443);
            this.listBNodeInfoList.Name = "listBNodeInfoList";
            this.listBNodeInfoList.Size = new System.Drawing.Size(120, 84);
            this.listBNodeInfoList.TabIndex = 6;
            // 
            // tbBaggageAmount
            // 
            this.tbBaggageAmount.Location = new System.Drawing.Point(46, 303);
            this.tbBaggageAmount.Name = "tbBaggageAmount";
            this.tbBaggageAmount.Size = new System.Drawing.Size(100, 22);
            this.tbBaggageAmount.TabIndex = 7;
            this.tbBaggageAmount.Text = "11";
            // 
            // btnFlightToDropOff
            // 
            this.btnFlightToDropOff.Location = new System.Drawing.Point(9, 146);
            this.btnFlightToDropOff.Name = "btnFlightToDropOff";
            this.btnFlightToDropOff.Size = new System.Drawing.Size(124, 47);
            this.btnFlightToDropOff.TabIndex = 8;
            this.btnFlightToDropOff.Text = "Set flight to drop off";
            this.btnFlightToDropOff.UseVisualStyleBackColor = true;
            this.btnFlightToDropOff.Click += new System.EventHandler(this.BtnFlightToDropOff_Click);
            // 
            // lblDropOffFLID
            // 
            this.lblDropOffFLID.AutoSize = true;
            this.lblDropOffFLID.Location = new System.Drawing.Point(164, 531);
            this.lblDropOffFLID.Name = "lblDropOffFLID";
            this.lblDropOffFLID.Size = new System.Drawing.Size(51, 17);
            this.lblDropOffFLID.TabIndex = 9;
            this.lblDropOffFLID.Text = "flightID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 557);
            this.Controls.Add(this.lblDropOffFLID);
            this.Controls.Add(this.tbBaggageAmount);
            this.Controls.Add(this.listBNodeInfoList);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.listBFlights);
            this.Controls.Add(this.grBoxTileInfo);
            this.Controls.Add(this.chBoxBuildMode);
            this.Controls.Add(this.grBoxBuildType);
            this.Controls.Add(this.animationBox);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.animationBox)).EndInit();
            this.grBoxBuildType.ResumeLayout(false);
            this.grBoxBuildType.PerformLayout();
            this.grBoxTileInfo.ResumeLayout(false);
            this.grBoxTileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox animationBox;
        private System.Windows.Forms.GroupBox grBoxBuildType;
        private System.Windows.Forms.RadioButton rbDropOff;
        private System.Windows.Forms.RadioButton rbConveyor;
        private System.Windows.Forms.RadioButton rbCheckIn;
        private System.Windows.Forms.CheckBox chBoxBuildMode;
        private System.Windows.Forms.GroupBox grBoxTileInfo;
        private System.Windows.Forms.Label lblNextTile;
        private System.Windows.Forms.Label lblTileCoordinates;
        private System.Windows.Forms.RadioButton rbBranch;
        private System.Windows.Forms.ListBox listBFlights;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.ComboBox cmBoxNodeFlights;
        private System.Windows.Forms.ListBox listBNodeInfoList;
        private System.Windows.Forms.Button btnFlightToCheckIn;
        private System.Windows.Forms.TextBox tbBaggageAmount;
        private System.Windows.Forms.Button btnFlightToDropOff;
        private System.Windows.Forms.Label lblDropOffFLID;
    }
}

