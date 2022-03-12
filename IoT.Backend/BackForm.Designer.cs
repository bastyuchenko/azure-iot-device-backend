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
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.lbEventsFromDevice = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbEventsToDevice = new System.Windows.Forms.TextBox();
            this.btnSendToDevice = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(5, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStartReceiving);
            this.tabPage1.Controls.Add(this.lbEventsFromDevice);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Receive from device";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(653, 22);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(94, 29);
            this.btnStartReceiving.TabIndex = 1;
            this.btnStartReceiving.Text = "Start";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // lbEventsFromDevice
            // 
            this.lbEventsFromDevice.Multiline = true;
            this.lbEventsFromDevice.Height = 20;
            this.lbEventsFromDevice.Location = new System.Drawing.Point(13, 59);
            this.lbEventsFromDevice.Name = "lbEventsFromDevice";
            this.lbEventsFromDevice.Size = new System.Drawing.Size(761, 584);
            this.lbEventsFromDevice.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbEventsToDevice);
            this.tabPage2.Controls.Add(this.btnSendToDevice);
            this.tabPage2.Controls.Add(this.tbMsg);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send to device";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbEventsToDevice
            // 
            this.lbEventsToDevice.Multiline = true;
            this.lbEventsToDevice.Height = 20;
            this.lbEventsToDevice.Location = new System.Drawing.Point(14, 66);
            this.lbEventsToDevice.Name = "lbEventsToDevice";
            this.lbEventsToDevice.Size = new System.Drawing.Size(760, 564);
            this.lbEventsToDevice.TabIndex = 2;
            // 
            // btnSendToDevice
            // 
            this.btnSendToDevice.Location = new System.Drawing.Point(12, 23);
            this.btnSendToDevice.Name = "btnSendToDevice";
            this.btnSendToDevice.Size = new System.Drawing.Size(150, 29);
            this.btnSendToDevice.TabIndex = 0;
            this.btnSendToDevice.Text = "Send To Device";
            this.btnSendToDevice.UseVisualStyleBackColor = true;
            this.btnSendToDevice.Click += new System.EventHandler(this.btnSendToDevice_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(180, 25);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(594, 27);
            this.tbMsg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
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
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tbDeviceId);
            this.Name = "BackForm";
            this.Text = "Backend";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox lbEventsFromDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.Button btnSendToDevice;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.TextBox lbEventsToDevice;
    }
}
