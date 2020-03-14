namespace YascTestApp
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
            this.components = new System.ComponentModel.Container();
            Yasc.OsdObject osdObject1 = new Yasc.OsdObject();
            Yasc.OsdObject osdObject2 = new Yasc.OsdObject();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.gbxSrc = new System.Windows.Forms.GroupBox();
            this.btnFilesrcBrowse = new System.Windows.Forms.Button();
            this.rbtnFileSrc = new System.Windows.Forms.RadioButton();
            this.btnDump = new System.Windows.Forms.Button();
            this.cmbUri = new System.Windows.Forms.ComboBox();
            this.nudTestSrc = new System.Windows.Forms.NumericUpDown();
            this.nudLocalIdx = new System.Windows.Forms.NumericUpDown();
            this.rbtnRtsp = new System.Windows.Forms.RadioButton();
            this.rbtnTest = new System.Windows.Forms.RadioButton();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.gbxOverlay = new System.Windows.Forms.GroupBox();
            this.btnAddOsd = new System.Windows.Forms.Button();
            this.btnRemoveOsd = new System.Windows.Forms.Button();
            this.flpOsd = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxSnapshot = new System.Windows.Forms.GroupBox();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.pbxSnapshot = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGstLaunch = new System.Windows.Forms.Button();
            this.yascControl1 = new Yasc.YascControl();
            this.chkDumpInter = new System.Windows.Forms.CheckBox();
            this.gbxSrc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalIdx)).BeginInit();
            this.gbxControl.SuspendLayout();
            this.gbxOverlay.SuspendLayout();
            this.gbxSnapshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnapshot)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 21);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(8, 52);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Checked = true;
            this.rbtnLocal.Location = new System.Drawing.Point(8, 25);
            this.rbtnLocal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(71, 21);
            this.rbtnLocal.TabIndex = 4;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "Local: ";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // gbxSrc
            // 
            this.gbxSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxSrc.Controls.Add(this.btnFilesrcBrowse);
            this.gbxSrc.Controls.Add(this.rbtnFileSrc);
            this.gbxSrc.Controls.Add(this.btnDump);
            this.gbxSrc.Controls.Add(this.cmbUri);
            this.gbxSrc.Controls.Add(this.nudTestSrc);
            this.gbxSrc.Controls.Add(this.nudLocalIdx);
            this.gbxSrc.Controls.Add(this.rbtnRtsp);
            this.gbxSrc.Controls.Add(this.rbtnTest);
            this.gbxSrc.Controls.Add(this.rbtnLocal);
            this.gbxSrc.Location = new System.Drawing.Point(16, 494);
            this.gbxSrc.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSrc.Name = "gbxSrc";
            this.gbxSrc.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSrc.Size = new System.Drawing.Size(496, 116);
            this.gbxSrc.TabIndex = 5;
            this.gbxSrc.TabStop = false;
            this.gbxSrc.Text = "Source";
            // 
            // btnFilesrcBrowse
            // 
            this.btnFilesrcBrowse.Enabled = false;
            this.btnFilesrcBrowse.Location = new System.Drawing.Point(287, 81);
            this.btnFilesrcBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilesrcBrowse.Name = "btnFilesrcBrowse";
            this.btnFilesrcBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnFilesrcBrowse.TabIndex = 10;
            this.btnFilesrcBrowse.Text = "Browse...";
            this.toolTip1.SetToolTip(this.btnFilesrcBrowse, "Open file to play.");
            this.btnFilesrcBrowse.UseVisualStyleBackColor = true;
            this.btnFilesrcBrowse.Click += new System.EventHandler(this.btnFilesrcBrowse_Click);
            // 
            // rbtnFileSrc
            // 
            this.rbtnFileSrc.AutoSize = true;
            this.rbtnFileSrc.Location = new System.Drawing.Point(205, 85);
            this.rbtnFileSrc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFileSrc.Name = "rbtnFileSrc";
            this.rbtnFileSrc.Size = new System.Drawing.Size(70, 21);
            this.rbtnFileSrc.TabIndex = 9;
            this.rbtnFileSrc.TabStop = true;
            this.rbtnFileSrc.Text = "Filesrc";
            this.rbtnFileSrc.UseVisualStyleBackColor = true;
            this.rbtnFileSrc.CheckedChanged += new System.EventHandler(this.rbtnFileSrc_CheckedChanged);
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(388, 16);
            this.btnDump.Margin = new System.Windows.Forms.Padding(4);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(100, 28);
            this.btnDump.TabIndex = 8;
            this.btnDump.Text = "Dump graph";
            this.toolTip1.SetToolTip(this.btnDump, "Create a .dot file of the current pipeline (for debugging).");
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // cmbUri
            // 
            this.cmbUri.Enabled = false;
            this.cmbUri.FormattingEnabled = true;
            this.cmbUri.Location = new System.Drawing.Point(95, 54);
            this.cmbUri.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUri.Name = "cmbUri";
            this.cmbUri.Size = new System.Drawing.Size(388, 24);
            this.cmbUri.TabIndex = 7;
            this.cmbUri.Text = "rtsp://admin:3@localhost:8554/test";
            this.cmbUri.SelectedIndexChanged += new System.EventHandler(this.cmbUri_SelectedIndexChanged);
            this.cmbUri.Leave += new System.EventHandler(this.cmbUri_Leave);
            // 
            // nudTestSrc
            // 
            this.nudTestSrc.Enabled = false;
            this.nudTestSrc.Location = new System.Drawing.Point(96, 84);
            this.nudTestSrc.Margin = new System.Windows.Forms.Padding(4);
            this.nudTestSrc.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudTestSrc.Name = "nudTestSrc";
            this.nudTestSrc.Size = new System.Drawing.Size(56, 22);
            this.nudTestSrc.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nudTestSrc, "TestSrc pattern (consult videotestsrc docs)");
            this.nudTestSrc.ValueChanged += new System.EventHandler(this.nudTestSrc_ValueChanged);
            // 
            // nudLocalIdx
            // 
            this.nudLocalIdx.Location = new System.Drawing.Point(96, 23);
            this.nudLocalIdx.Margin = new System.Windows.Forms.Padding(4);
            this.nudLocalIdx.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLocalIdx.Name = "nudLocalIdx";
            this.nudLocalIdx.Size = new System.Drawing.Size(56, 22);
            this.nudLocalIdx.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nudLocalIdx, "Local source index (usually 0 for built-in)");
            this.nudLocalIdx.ValueChanged += new System.EventHandler(this.nudIdx_ValueChanged);
            // 
            // rbtnRtsp
            // 
            this.rbtnRtsp.AutoSize = true;
            this.rbtnRtsp.Location = new System.Drawing.Point(8, 54);
            this.rbtnRtsp.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnRtsp.Name = "rbtnRtsp";
            this.rbtnRtsp.Size = new System.Drawing.Size(74, 21);
            this.rbtnRtsp.TabIndex = 4;
            this.rbtnRtsp.Text = "RTSP: ";
            this.rbtnRtsp.UseVisualStyleBackColor = true;
            this.rbtnRtsp.CheckedChanged += new System.EventHandler(this.rbtnRtsp_CheckedChanged);
            // 
            // rbtnTest
            // 
            this.rbtnTest.AutoSize = true;
            this.rbtnTest.Location = new System.Drawing.Point(8, 84);
            this.rbtnTest.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTest.Name = "rbtnTest";
            this.rbtnTest.Size = new System.Drawing.Size(84, 21);
            this.rbtnTest.TabIndex = 4;
            this.rbtnTest.Text = "Testsrc: ";
            this.rbtnTest.UseVisualStyleBackColor = true;
            this.rbtnTest.CheckedChanged += new System.EventHandler(this.rbtnTest_CheckedChanged);
            // 
            // gbxControl
            // 
            this.gbxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxControl.Controls.Add(this.btnBrowse);
            this.gbxControl.Controls.Add(this.btnRecord);
            this.gbxControl.Controls.Add(this.btnStop);
            this.gbxControl.Controls.Add(this.btnStart);
            this.gbxControl.Location = new System.Drawing.Point(908, 15);
            this.gbxControl.Margin = new System.Windows.Forms.Padding(4);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Padding = new System.Windows.Forms.Padding(4);
            this.gbxControl.Size = new System.Drawing.Size(179, 162);
            this.gbxControl.TabIndex = 6;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Controls";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(8, 122);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(159, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.toolTip1.SetToolTip(this.btnBrowse, "Choose recorded file save location. ");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(8, 90);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(159, 28);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // gbxOverlay
            // 
            this.gbxOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOverlay.Controls.Add(this.btnAddOsd);
            this.gbxOverlay.Controls.Add(this.btnRemoveOsd);
            this.gbxOverlay.Controls.Add(this.flpOsd);
            this.gbxOverlay.Location = new System.Drawing.Point(520, 494);
            this.gbxOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.gbxOverlay.Name = "gbxOverlay";
            this.gbxOverlay.Padding = new System.Windows.Forms.Padding(4);
            this.gbxOverlay.Size = new System.Drawing.Size(559, 116);
            this.gbxOverlay.TabIndex = 7;
            this.gbxOverlay.TabStop = false;
            this.gbxOverlay.Text = "Overlay";
            // 
            // btnAddOsd
            // 
            this.btnAddOsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOsd.Location = new System.Drawing.Point(72, 0);
            this.btnAddOsd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOsd.Name = "btnAddOsd";
            this.btnAddOsd.Size = new System.Drawing.Size(31, 28);
            this.btnAddOsd.TabIndex = 1;
            this.btnAddOsd.Text = "+";
            this.btnAddOsd.UseVisualStyleBackColor = true;
            this.btnAddOsd.Click += new System.EventHandler(this.btnAddOsd_Click);
            // 
            // btnRemoveOsd
            // 
            this.btnRemoveOsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOsd.Location = new System.Drawing.Point(104, 0);
            this.btnRemoveOsd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveOsd.Name = "btnRemoveOsd";
            this.btnRemoveOsd.Size = new System.Drawing.Size(31, 28);
            this.btnRemoveOsd.TabIndex = 2;
            this.btnRemoveOsd.Text = "-";
            this.btnRemoveOsd.UseVisualStyleBackColor = true;
            this.btnRemoveOsd.Click += new System.EventHandler(this.btnRemoveOsd_Click);
            // 
            // flpOsd
            // 
            this.flpOsd.AutoScroll = true;
            this.flpOsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOsd.Location = new System.Drawing.Point(4, 19);
            this.flpOsd.Margin = new System.Windows.Forms.Padding(4);
            this.flpOsd.Name = "flpOsd";
            this.flpOsd.Size = new System.Drawing.Size(551, 93);
            this.flpOsd.TabIndex = 0;
            // 
            // gbxSnapshot
            // 
            this.gbxSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSnapshot.Controls.Add(this.btnSnapshot);
            this.gbxSnapshot.Controls.Add(this.pbxSnapshot);
            this.gbxSnapshot.Location = new System.Drawing.Point(908, 185);
            this.gbxSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSnapshot.Name = "gbxSnapshot";
            this.gbxSnapshot.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSnapshot.Size = new System.Drawing.Size(179, 181);
            this.gbxSnapshot.TabIndex = 8;
            this.gbxSnapshot.TabStop = false;
            this.gbxSnapshot.Text = "Snapshot";
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(8, 140);
            this.btnSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(159, 28);
            this.btnSnapshot.TabIndex = 1;
            this.btnSnapshot.Text = "Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // pbxSnapshot
            // 
            this.pbxSnapshot.BackColor = System.Drawing.Color.Gray;
            this.pbxSnapshot.Location = new System.Drawing.Point(8, 23);
            this.pbxSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSnapshot.Name = "pbxSnapshot";
            this.pbxSnapshot.Size = new System.Drawing.Size(163, 110);
            this.pbxSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSnapshot.TabIndex = 0;
            this.pbxSnapshot.TabStop = false;
            this.pbxSnapshot.Click += new System.EventHandler(this.pbxSnapshot_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1091, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.Text = "Status";
            // 
            // btnGstLaunch
            // 
            this.btnGstLaunch.Location = new System.Drawing.Point(908, 406);
            this.btnGstLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnGstLaunch.Name = "btnGstLaunch";
            this.btnGstLaunch.Size = new System.Drawing.Size(167, 28);
            this.btnGstLaunch.TabIndex = 10;
            this.btnGstLaunch.Text = "Gst Launch Lines";
            this.btnGstLaunch.UseVisualStyleBackColor = true;
            this.btnGstLaunch.Visible = false;
            this.btnGstLaunch.Click += new System.EventHandler(this.btnGstLaunch_Click);
            // 
            // yascControl1
            // 
            this.yascControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yascControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yascControl1.CamType = Yasc.GstEnums.CamType.Local;
            this.yascControl1.CaptureFrameRate = 0;
            this.yascControl1.Connected = false;
            this.yascControl1.ConnectionUri = "";
            this.yascControl1.DeviceIndex = 0;
            this.yascControl1.Location = new System.Drawing.Point(16, 15);
            this.yascControl1.Margin = new System.Windows.Forms.Padding(4);
            this.yascControl1.Name = "yascControl1";
            osdObject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            osdObject1.FontDescription = "Arial, 12";
            osdObject1.FontSize = 15F;
            osdObject1.HorizontalAlignment = Yasc.GstEnums.TextOverlayHAlign.HALIGN_CENTER;
            osdObject1.Name = "";
            osdObject1.Text = "TopCenterTest";
            osdObject1.VerticalAlignment = Yasc.GstEnums.TextOverlayVAlign.VALIGN_TOP;
            osdObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            osdObject2.FontDescription = "Arial, 15.00";
            osdObject2.FontSize = 15F;
            osdObject2.HorizontalAlignment = Yasc.GstEnums.TextOverlayHAlign.HALIGN_LEFT;
            osdObject2.Name = "ttt";
            osdObject2.Text = "BottomLeftTest";
            osdObject2.VerticalAlignment = Yasc.GstEnums.TextOverlayVAlign.VALIGN_BOTTOM;
            this.yascControl1.OverlayObjects.Add(osdObject1);
            this.yascControl1.OverlayObjects.Add(osdObject2);
            this.yascControl1.Preview = false;
            this.yascControl1.Size = new System.Drawing.Size(884, 469);
            this.yascControl1.TabIndex = 3;
            this.yascControl1.UseCapsFilter = false;
            this.yascControl1.SnapshotReady += new System.EventHandler<System.Drawing.Image>(this.yascControl1_SnapshotReady);
            this.yascControl1.Load += new System.EventHandler(this.yascControl1_Load);
            this.yascControl1.DoubleClick += new System.EventHandler(this.yascControl1_DoubleClick);
            // 
            // chkDumpInter
            // 
            this.chkDumpInter.AutoSize = true;
            this.chkDumpInter.Location = new System.Drawing.Point(908, 378);
            this.chkDumpInter.Margin = new System.Windows.Forms.Padding(4);
            this.chkDumpInter.Name = "chkDumpInter";
            this.chkDumpInter.Size = new System.Drawing.Size(149, 21);
            this.chkDumpInter.TabIndex = 11;
            this.chkDumpInter.Text = "Dump Intermediate";
            this.chkDumpInter.UseVisualStyleBackColor = true;
            this.chkDumpInter.CheckedChanged += new System.EventHandler(this.chkDumpInter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 640);
            this.Controls.Add(this.chkDumpInter);
            this.Controls.Add(this.btnGstLaunch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxSnapshot);
            this.Controls.Add(this.gbxOverlay);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxSrc);
            this.Controls.Add(this.yascControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YASC - Yet Another Streaming Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSrc.ResumeLayout(false);
            this.gbxSrc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalIdx)).EndInit();
            this.gbxControl.ResumeLayout(false);
            this.gbxOverlay.ResumeLayout(false);
            this.gbxSnapshot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSnapshot)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private Yasc.YascControl yascControl1;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.GroupBox gbxSrc;
        private System.Windows.Forms.NumericUpDown nudLocalIdx;
        private System.Windows.Forms.RadioButton rbtnRtsp;
        private System.Windows.Forms.ComboBox cmbUri;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.NumericUpDown nudTestSrc;
        private System.Windows.Forms.RadioButton rbtnTest;
        private System.Windows.Forms.GroupBox gbxOverlay;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.GroupBox gbxSnapshot;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.PictureBox pbxSnapshot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flpOsd;
        private System.Windows.Forms.Button btnRemoveOsd;
        private System.Windows.Forms.Button btnAddOsd;
        private System.Windows.Forms.RadioButton rbtnFileSrc;
        private System.Windows.Forms.Button btnFilesrcBrowse;
        private System.Windows.Forms.Button btnGstLaunch;
        private System.Windows.Forms.CheckBox chkDumpInter;
    }
}

