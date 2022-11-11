namespace IoT.Backend
{
    partial class BackForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStopReceiving = new System.Windows.Forms.Button();
            this.btnSendToDevice = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRReported = new System.Windows.Forms.Button();
            this.btnWDesired = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(4, 31);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(690, 116);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.btnStopReceiving);
            this.tabPage1.Controls.Add(this.btnSendToDevice);
            this.tabPage1.Controls.Add(this.tbMsg);
            this.tabPage1.Controls.Add(this.btnStartReceiving);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(682, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receive from/Send to device";
            // 
            // btnStopReceiving
            // 
            this.btnStopReceiving.Location = new System.Drawing.Point(6, 31);
            this.btnStopReceiving.Name = "btnStopReceiving";
            this.btnStopReceiving.Size = new System.Drawing.Size(123, 23);
            this.btnStopReceiving.TabIndex = 2;
            this.btnStopReceiving.Text = "Stop receiving";
            this.btnStopReceiving.UseVisualStyleBackColor = true;
            this.btnStopReceiving.Click += new System.EventHandler(this.btnStopReceiving_Click);
            // 
            // btnSendToDevice
            // 
            this.btnSendToDevice.Location = new System.Drawing.Point(318, 4);
            this.btnSendToDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendToDevice.Name = "btnSendToDevice";
            this.btnSendToDevice.Size = new System.Drawing.Size(131, 22);
            this.btnSendToDevice.TabIndex = 0;
            this.btnSendToDevice.Text = "Send To Device";
            this.btnSendToDevice.UseVisualStyleBackColor = true;
            this.btnSendToDevice.Click += new System.EventHandler(this.btnSendToDevice_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(318, 30);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(330, 23);
            this.tbMsg.TabIndex = 1;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(5, 4);
            this.btnStartReceiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(124, 22);
            this.btnStartReceiving.TabIndex = 1;
            this.btnStartReceiving.Text = "Start receiving";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRReported);
            this.tabPage3.Controls.Add(this.btnWDesired);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(682, 88);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRReported
            // 
            this.btnRReported.Location = new System.Drawing.Point(8, 51);
            this.btnRReported.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRReported.Name = "btnRReported";
            this.btnRReported.Size = new System.Drawing.Size(142, 22);
            this.btnRReported.TabIndex = 1;
            this.btnRReported.Text = "read Reported";
            this.btnRReported.UseVisualStyleBackColor = true;
            this.btnRReported.Click += new System.EventHandler(this.btnRReported_Click);
            // 
            // btnWDesired
            // 
            this.btnWDesired.Location = new System.Drawing.Point(8, 16);
            this.btnWDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWDesired.Name = "btnWDesired";
            this.btnWDesired.Size = new System.Drawing.Size(142, 22);
            this.btnWDesired.TabIndex = 0;
            this.btnWDesired.Text = "write Desired";
            this.btnWDesired.UseVisualStyleBackColor = true;
            this.btnWDesired.Click += new System.EventHandler(this.btnWDesired_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbStatus.Location = new System.Drawing.Point(8, 151);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbStatus.Size = new System.Drawing.Size(682, 398);
            this.lbStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(74, 9);
            this.tbDeviceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(197, 23);
            this.tbDeviceId.TabIndex = 1;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(619, 152);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(43, 23);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 557);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tbDeviceId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackForm";
            this.Text = "Backend";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.Button btnSendToDevice;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRReported;
        private System.Windows.Forms.Button btnWDesired;
        private System.Windows.Forms.Button btnStopReceiving;
        private System.Windows.Forms.Button btnClean;
    }
}
