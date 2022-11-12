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
            this.tbReceivedMsg = new System.Windows.Forms.TextBox();
            this.btnStopReceiving = new System.Windows.Forms.Button();
            this.btnSendToDevice = new System.Windows.Forms.Button();
            this.tbSentMsg = new System.Windows.Forms.TextBox();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbDTRead = new System.Windows.Forms.TextBox();
            this.btnReadDT = new System.Windows.Forms.Button();
            this.tbDTdesired = new System.Windows.Forms.TextBox();
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
            this.tabControl.Location = new System.Drawing.Point(408, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(597, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.tbReceivedMsg);
            this.tabPage1.Controls.Add(this.btnStopReceiving);
            this.tabPage1.Controls.Add(this.btnSendToDevice);
            this.tabPage1.Controls.Add(this.tbSentMsg);
            this.tabPage1.Controls.Add(this.btnStartReceiving);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receive from/Send to device";
            // 
            // tbReceivedMsg
            // 
            this.tbReceivedMsg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbReceivedMsg.Location = new System.Drawing.Point(3, 298);
            this.tbReceivedMsg.Multiline = true;
            this.tbReceivedMsg.Name = "tbReceivedMsg";
            this.tbReceivedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReceivedMsg.Size = new System.Drawing.Size(486, 356);
            this.tbReceivedMsg.TabIndex = 4;
            // 
            // btnStopReceiving
            // 
            this.btnStopReceiving.Location = new System.Drawing.Point(496, 360);
            this.btnStopReceiving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopReceiving.Name = "btnStopReceiving";
            this.btnStopReceiving.Size = new System.Drawing.Size(90, 57);
            this.btnStopReceiving.TabIndex = 2;
            this.btnStopReceiving.Text = "Stop receiving";
            this.btnStopReceiving.UseVisualStyleBackColor = true;
            this.btnStopReceiving.Click += new System.EventHandler(this.btnStopReceiving_Click);
            // 
            // btnSendToDevice
            // 
            this.btnSendToDevice.Location = new System.Drawing.Point(495, 6);
            this.btnSendToDevice.Name = "btnSendToDevice";
            this.btnSendToDevice.Size = new System.Drawing.Size(88, 59);
            this.btnSendToDevice.TabIndex = 0;
            this.btnSendToDevice.Text = "Send To Device";
            this.btnSendToDevice.UseVisualStyleBackColor = true;
            this.btnSendToDevice.Click += new System.EventHandler(this.btnSendToDevice_Click);
            // 
            // tbSentMsg
            // 
            this.tbSentMsg.Location = new System.Drawing.Point(3, 1);
            this.tbSentMsg.Multiline = true;
            this.tbSentMsg.Name = "tbSentMsg";
            this.tbSentMsg.Size = new System.Drawing.Size(486, 291);
            this.tbSentMsg.TabIndex = 1;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(495, 298);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(91, 55);
            this.btnStartReceiving.TabIndex = 1;
            this.btnStartReceiving.Text = "Start receiving";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbDTRead);
            this.tabPage3.Controls.Add(this.btnReadDT);
            this.tabPage3.Controls.Add(this.tbDTdesired);
            this.tabPage3.Controls.Add(this.btnWDesired);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(589, 657);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbDTRead
            // 
            this.tbDTRead.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDTRead.Location = new System.Drawing.Point(3, 304);
            this.tbDTRead.Multiline = true;
            this.tbDTRead.Name = "tbDTRead";
            this.tbDTRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDTRead.Size = new System.Drawing.Size(415, 356);
            this.tbDTRead.TabIndex = 6;
            // 
            // btnReadDT
            // 
            this.btnReadDT.Location = new System.Drawing.Point(424, 298);
            this.btnReadDT.Name = "btnReadDT";
            this.btnReadDT.Size = new System.Drawing.Size(162, 29);
            this.btnReadDT.TabIndex = 1;
            this.btnReadDT.Text = "read Device Twin";
            this.btnReadDT.UseVisualStyleBackColor = true;
            this.btnReadDT.Click += new System.EventHandler(this.btnRReported_Click);
            // 
            // tbDTdesired
            // 
            this.tbDTdesired.Location = new System.Drawing.Point(3, 3);
            this.tbDTdesired.Multiline = true;
            this.tbDTdesired.Name = "tbDTdesired";
            this.tbDTdesired.Size = new System.Drawing.Size(415, 291);
            this.tbDTdesired.TabIndex = 5;
            // 
            // btnWDesired
            // 
            this.btnWDesired.Location = new System.Drawing.Point(424, 3);
            this.btnWDesired.Name = "btnWDesired";
            this.btnWDesired.Size = new System.Drawing.Size(162, 29);
            this.btnWDesired.TabIndex = 0;
            this.btnWDesired.Text = "write Desired";
            this.btnWDesired.UseVisualStyleBackColor = true;
            this.btnWDesired.Click += new System.EventHandler(this.btnWDesired_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbStatus.Location = new System.Drawing.Point(9, 45);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbStatus.Size = new System.Drawing.Size(393, 685);
            this.lbStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(85, 12);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(225, 27);
            this.tbDeviceId.TabIndex = 1;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(321, 45);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(58, 31);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1013, 743);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tbDeviceId);
            this.Name = "BackForm";
            this.Text = "Backend";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox tbSentMsg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReadDT;
        private System.Windows.Forms.Button btnWDesired;
        private System.Windows.Forms.Button btnStopReceiving;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox tbReceivedMsg;
        private System.Windows.Forms.TextBox tbDTRead;
        private System.Windows.Forms.TextBox tbDTdesired;
    }
}
