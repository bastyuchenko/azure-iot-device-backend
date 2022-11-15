namespace IoT.Device
{
    partial class Device
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device));
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbReceivedMsg = new System.Windows.Forms.TextBox();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReadDT = new System.Windows.Forms.Button();
            this.tbDTRead = new System.Windows.Forms.TextBox();
            this.btnDTReadDesired = new System.Windows.Forms.Button();
            this.btnWReported = new System.Windows.Forms.Button();
            this.tbDTReport = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGenerateStreamStop = new System.Windows.Forms.Button();
            this.tbMsgsExample = new System.Windows.Forms.TextBox();
            this.btnGenStream = new System.Windows.Forms.Button();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.tbAssignedHub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIconDevice = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelLoading = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbStatus.Location = new System.Drawing.Point(16, 68);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(387, 661);
            this.lbStatus.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(419, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 661);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.tbReceivedMsg);
            this.tabPage1.Controls.Add(this.btnStartReceiving);
            this.tabPage1.Controls.Add(this.tbMsg);
            this.tabPage1.Controls.Add(this.btnSendMsg);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send to/Receive from IoT Hub";
            // 
            // tbReceivedMsg
            // 
            this.tbReceivedMsg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbReceivedMsg.Location = new System.Drawing.Point(6, 316);
            this.tbReceivedMsg.Multiline = true;
            this.tbReceivedMsg.Name = "tbReceivedMsg";
            this.tbReceivedMsg.Size = new System.Drawing.Size(349, 309);
            this.tbReceivedMsg.TabIndex = 6;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(361, 316);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(94, 29);
            this.btnStartReceiving.TabIndex = 0;
            this.btnStartReceiving.Text = "Receive";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(6, 6);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(351, 298);
            this.tbMsg.TabIndex = 0;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(363, 20);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(94, 29);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send msg to IoT";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage3.Controls.Add(this.btnReadDT);
            this.tabPage3.Controls.Add(this.tbDTRead);
            this.tabPage3.Controls.Add(this.btnDTReadDesired);
            this.tabPage3.Controls.Add(this.btnWReported);
            this.tabPage3.Controls.Add(this.tbDTReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(461, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            // 
            // btnReadDT
            // 
            this.btnReadDT.Location = new System.Drawing.Point(360, 465);
            this.btnReadDT.Name = "btnReadDT";
            this.btnReadDT.Size = new System.Drawing.Size(98, 106);
            this.btnReadDT.TabIndex = 9;
            this.btnReadDT.Text = "read Device Twin";
            this.btnReadDT.UseVisualStyleBackColor = true;
            this.btnReadDT.Click += new System.EventHandler(this.btnReadDT_Click);
            // 
            // tbDTRead
            // 
            this.tbDTRead.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDTRead.Location = new System.Drawing.Point(3, 313);
            this.tbDTRead.Multiline = true;
            this.tbDTRead.Name = "tbDTRead";
            this.tbDTRead.Size = new System.Drawing.Size(349, 309);
            this.tbDTRead.TabIndex = 8;
            // 
            // btnDTReadDesired
            // 
            this.btnDTReadDesired.Location = new System.Drawing.Point(360, 312);
            this.btnDTReadDesired.Name = "btnDTReadDesired";
            this.btnDTReadDesired.Size = new System.Drawing.Size(98, 147);
            this.btnDTReadDesired.TabIndex = 1;
            this.btnDTReadDesired.Text = "subscribe on Device Twin Desired Properties";
            this.btnDTReadDesired.UseVisualStyleBackColor = true;
            this.btnDTReadDesired.Click += new System.EventHandler(this.btnRDesired_Click);
            // 
            // btnWReported
            // 
            this.btnWReported.Location = new System.Drawing.Point(360, 3);
            this.btnWReported.Name = "btnWReported";
            this.btnWReported.Size = new System.Drawing.Size(98, 58);
            this.btnWReported.TabIndex = 0;
            this.btnWReported.Text = "write Reported";
            this.btnWReported.UseVisualStyleBackColor = true;
            this.btnWReported.Click += new System.EventHandler(this.btnWReported_Click);
            // 
            // tbDTReport
            // 
            this.tbDTReport.Location = new System.Drawing.Point(3, 3);
            this.tbDTReport.Multiline = true;
            this.tbDTReport.Name = "tbDTReport";
            this.tbDTReport.Size = new System.Drawing.Size(351, 298);
            this.tbDTReport.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.btnGenerateStreamStop);
            this.tabPage4.Controls.Add(this.tbMsgsExample);
            this.tabPage4.Controls.Add(this.btnGenStream);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(461, 628);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generate stream";
            // 
            // btnGenerateStreamStop
            // 
            this.btnGenerateStreamStop.Location = new System.Drawing.Point(278, 11);
            this.btnGenerateStreamStop.Name = "btnGenerateStreamStop";
            this.btnGenerateStreamStop.Size = new System.Drawing.Size(168, 57);
            this.btnGenerateStreamStop.TabIndex = 2;
            this.btnGenerateStreamStop.Text = "Generate stream - Stop";
            this.btnGenerateStreamStop.UseVisualStyleBackColor = true;
            this.btnGenerateStreamStop.Click += new System.EventHandler(this.btnGenerateStreamStop_Click);
            // 
            // tbMsgsExample
            // 
            this.tbMsgsExample.Location = new System.Drawing.Point(8, 74);
            this.tbMsgsExample.Multiline = true;
            this.tbMsgsExample.Name = "tbMsgsExample";
            this.tbMsgsExample.ReadOnly = true;
            this.tbMsgsExample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMsgsExample.Size = new System.Drawing.Size(438, 535);
            this.tbMsgsExample.TabIndex = 1;
            // 
            // btnGenStream
            // 
            this.btnGenStream.Location = new System.Drawing.Point(8, 11);
            this.btnGenStream.Name = "btnGenStream";
            this.btnGenStream.Size = new System.Drawing.Size(168, 57);
            this.btnGenStream.TabIndex = 0;
            this.btnGenStream.Text = "Generate stream - Start";
            this.btnGenStream.UseVisualStyleBackColor = true;
            this.btnGenStream.Click += new System.EventHandler(this.btnGenStream_Click);
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(206, 15);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(181, 27);
            this.tbDeviceId.TabIndex = 0;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // tbAssignedHub
            // 
            this.tbAssignedHub.Location = new System.Drawing.Point(523, 15);
            this.tbAssignedHub.Name = "tbAssignedHub";
            this.tbAssignedHub.ReadOnly = true;
            this.tbAssignedHub.Size = new System.Drawing.Size(303, 27);
            this.tbAssignedHub.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Device Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Hub";
            // 
            // notifyIconDevice
            // 
            this.notifyIconDevice.Text = "NotifyIconDevice";
            this.notifyIconDevice.Visible = true;
            // 
            // panelLoading
            // 
            this.panelLoading.Location = new System.Drawing.Point(409, 57);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(486, 672);
            this.panelLoading.TabIndex = 6;
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbAssignedHub);
            this.Controls.Add(this.tbDeviceId);
            this.Controls.Add(this.panelLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Device";
            this.Text = "Device";
            this.Load += new System.EventHandler(this.Device_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox lbStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.TextBox tbAssignedHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDTReadDesired;
        private System.Windows.Forms.Button btnWReported;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbMsgsExample;
        private System.Windows.Forms.Button btnGenStream;
        private System.Windows.Forms.NotifyIcon notifyIconDevice;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbReceivedMsg;
        private System.Windows.Forms.TextBox tbDTRead;
        private System.Windows.Forms.TextBox tbDTReport;
        private System.Windows.Forms.Button btnReadDT;
        private System.Windows.Forms.Button btnGenerateStreamStop;
        private System.Windows.Forms.Panel panelLoading;
    }
}
