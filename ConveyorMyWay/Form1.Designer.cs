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
            this.rbDropOff = new System.Windows.Forms.RadioButton();
            this.rbConveyor = new System.Windows.Forms.RadioButton();
            this.rbCheckIn = new System.Windows.Forms.RadioButton();
            this.chBoxBuildMode = new System.Windows.Forms.CheckBox();
            this.grBoxTileInfo = new System.Windows.Forms.GroupBox();
            this.lblTileCoordinates = new System.Windows.Forms.Label();
            this.lblNextTile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animationBox)).BeginInit();
            this.grBoxBuildType.SuspendLayout();
            this.grBoxTileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationBox
            // 
            this.animationBox.Location = new System.Drawing.Point(193, 12);
            this.animationBox.Name = "animationBox";
            this.animationBox.Size = new System.Drawing.Size(884, 485);
            this.animationBox.TabIndex = 0;
            this.animationBox.TabStop = false;
            this.animationBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AnimationBox_Paint);
            this.animationBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseDown);
            this.animationBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseMove);
            this.animationBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnimationBox_MouseUp);
            // 
            // grBoxBuildType
            // 
            this.grBoxBuildType.Controls.Add(this.rbDropOff);
            this.grBoxBuildType.Controls.Add(this.rbConveyor);
            this.grBoxBuildType.Controls.Add(this.rbCheckIn);
            this.grBoxBuildType.Location = new System.Drawing.Point(12, 68);
            this.grBoxBuildType.Name = "grBoxBuildType";
            this.grBoxBuildType.Size = new System.Drawing.Size(175, 113);
            this.grBoxBuildType.TabIndex = 1;
            this.grBoxBuildType.TabStop = false;
            this.grBoxBuildType.Text = "BuildType";
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
            this.grBoxTileInfo.Controls.Add(this.lblNextTile);
            this.grBoxTileInfo.Controls.Add(this.lblTileCoordinates);
            this.grBoxTileInfo.Location = new System.Drawing.Point(3, 397);
            this.grBoxTileInfo.Name = "grBoxTileInfo";
            this.grBoxTileInfo.Size = new System.Drawing.Size(184, 100);
            this.grBoxTileInfo.TabIndex = 3;
            this.grBoxTileInfo.TabStop = false;
            this.grBoxTileInfo.Text = "TileInfo";
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
            // lblNextTile
            // 
            this.lblNextTile.AutoSize = true;
            this.lblNextTile.Location = new System.Drawing.Point(58, 51);
            this.lblNextTile.Name = "lblNextTile";
            this.lblNextTile.Size = new System.Drawing.Size(46, 17);
            this.lblNextTile.TabIndex = 5;
            this.lblNextTile.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 509);
            this.Controls.Add(this.grBoxTileInfo);
            this.Controls.Add(this.chBoxBuildMode);
            this.Controls.Add(this.grBoxBuildType);
            this.Controls.Add(this.animationBox);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

