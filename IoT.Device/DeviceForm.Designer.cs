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
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRDesired = new System.Windows.Forms.Button();
            this.btnWReported = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbMsgsExample = new System.Windows.Forms.TextBox();
            this.btnGenStream = new System.Windows.Forms.Button();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.tbAssignedHub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIconDevice = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(108, 10);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(497, 23);
            this.tbMsg.TabIndex = 0;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(609, 9);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(82, 22);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send msg to IoT";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(14, 9);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(82, 22);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbStatus.Location = new System.Drawing.Point(14, 238);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(709, 310);
            this.lbStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 191);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.btnStartReceiving);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSendMsg);
            this.tabPage1.Controls.Add(this.tbMsg);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(708, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send to/Receive from IoT Hub";
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(20, 55);
            this.btnStartReceiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(82, 22);
            this.btnStartReceiving.TabIndex = 0;
            this.btnStartReceiving.Text = "Receive";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage3.Controls.Add(this.btnRDesired);
            this.tabPage3.Controls.Add(this.btnWReported);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(708, 163);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            // 
            // btnRDesired
            // 
            this.btnRDesired.Location = new System.Drawing.Point(54, 60);
            this.btnRDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRDesired.Name = "btnRDesired";
            this.btnRDesired.Size = new System.Drawing.Size(177, 22);
            this.btnRDesired.TabIndex = 1;
            this.btnRDesired.Text = "read Desired";
            this.btnRDesired.UseVisualStyleBackColor = true;
            this.btnRDesired.Click += new System.EventHandler(this.btnRDesired_Click);
            // 
            // btnWReported
            // 
            this.btnWReported.Location = new System.Drawing.Point(54, 8);
            this.btnWReported.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWReported.Name = "btnWReported";
            this.btnWReported.Size = new System.Drawing.Size(177, 22);
            this.btnWReported.TabIndex = 0;
            this.btnWReported.Text = "write Reported";
            this.btnWReported.UseVisualStyleBackColor = true;
            this.btnWReported.Click += new System.EventHandler(this.btnWReported_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.tbMsgsExample);
            this.tabPage4.Controls.Add(this.btnGenStream);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(708, 163);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generate stream";
            // 
            // tbMsgsExample
            // 
            this.tbMsgsExample.Location = new System.Drawing.Point(159, 8);
            this.tbMsgsExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMsgsExample.Multiline = true;
            this.tbMsgsExample.Name = "tbMsgsExample";
            this.tbMsgsExample.Size = new System.Drawing.Size(534, 157);
            this.tbMsgsExample.TabIndex = 1;
            this.tbMsgsExample.Text = resources.GetString("tbMsgsExample.Text");
            // 
            // btnGenStream
            // 
            this.btnGenStream.Location = new System.Drawing.Point(7, 8);
            this.btnGenStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenStream.Name = "btnGenStream";
            this.btnGenStream.Size = new System.Drawing.Size(147, 22);
            this.btnGenStream.TabIndex = 0;
            this.btnGenStream.Text = "Generate stream";
            this.btnGenStream.UseVisualStyleBackColor = true;
            this.btnGenStream.Click += new System.EventHandler(this.btnGenStream_Click);
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Location = new System.Drawing.Point(180, 11);
            this.tbDeviceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(159, 23);
            this.tbDeviceId.TabIndex = 0;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // tbAssignedHub
            // 
            this.tbAssignedHub.Location = new System.Drawing.Point(458, 11);
            this.tbAssignedHub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAssignedHub.Name = "tbAssignedHub";
            this.tbAssignedHub.ReadOnly = true;
            this.tbAssignedHub.Size = new System.Drawing.Size(266, 23);
            this.tbAssignedHub.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Device Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Hub";
            // 
            // notifyIconDevice
            // 
            this.notifyIconDevice.Text = "NotifyIconDevice";
            this.notifyIconDevice.Visible = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(681, 239);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(45, 23);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(737, 556);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbAssignedHub);
            this.Controls.Add(this.tbDeviceId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Device";
            this.Text = "Device";
            this.Load += new System.EventHandler(this.Device_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.TextBox tbAssignedHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRDesired;
        private System.Windows.Forms.Button btnWReported;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbMsgsExample;
        private System.Windows.Forms.Button btnGenStream;
        private System.Windows.Forms.NotifyIcon notifyIconDevice;
        private System.Windows.Forms.Button btnClean;
    }
}
