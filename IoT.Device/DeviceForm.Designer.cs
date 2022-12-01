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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device));
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tbReceivedMsg = new System.Windows.Forms.TextBox();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbDTReport = new System.Windows.Forms.TextBox();
            this.tbDTRead = new System.Windows.Forms.TextBox();
            this.btnWReported = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadDT = new System.Windows.Forms.Button();
            this.btnDTReadDesired = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenStream = new System.Windows.Forms.Button();
            this.btnGenerateStreamStop = new System.Windows.Forms.Button();
            this.tbMsgsExample = new System.Windows.Forms.TextBox();
            this.tabModuleTwin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tbModuleTwinRepProps = new System.Windows.Forms.TextBox();
            this.btnModuleTwinDesiredPropsSubsr = new System.Windows.Forms.Button();
            this.btnModuleTwinRepProps = new System.Windows.Forms.Button();
            this.tbModuletwinDesProps = new System.Windows.Forms.TextBox();
            this.tbDeviceId = new System.Windows.Forms.TextBox();
            this.tbAssignedHub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tabModuleTwin.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Location = new System.Drawing.Point(3, 2);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 29);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbStatus.Location = new System.Drawing.Point(3, 2);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStatus.Multiline = true;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(667, 725);
            this.lbStatus.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabModuleTwin);
            this.tabControl.Location = new System.Drawing.Point(676, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(668, 725);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.tableLayoutPanel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(660, 697);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send to/Receive from IoT Hub";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.57407F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.42593F));
            this.tableLayoutPanel9.Controls.Add(this.btnSendMsg, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tbReceivedMsg, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.btnStartReceiving, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.tbMsg, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(654, 693);
            this.tableLayoutPanel9.TabIndex = 7;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(569, 2);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(81, 22);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send msg to IoT";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tbReceivedMsg
            // 
            this.tbReceivedMsg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbReceivedMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceivedMsg.Location = new System.Drawing.Point(3, 348);
            this.tbReceivedMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReceivedMsg.Multiline = true;
            this.tbReceivedMsg.Name = "tbReceivedMsg";
            this.tbReceivedMsg.ReadOnly = true;
            this.tbReceivedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReceivedMsg.Size = new System.Drawing.Size(560, 343);
            this.tbReceivedMsg.TabIndex = 6;
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(569, 348);
            this.btnStartReceiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(81, 22);
            this.btnStartReceiving.TabIndex = 0;
            this.btnStartReceiving.Text = "Receive";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMsg.Location = new System.Drawing.Point(3, 2);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(560, 342);
            this.tbMsg.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(660, 697);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeviceTwin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Controls.Add(this.tbDTReport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDTRead, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnWReported, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 697);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tbDTReport
            // 
            this.tbDTReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDTReport.Location = new System.Drawing.Point(3, 2);
            this.tbDTReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDTReport.Multiline = true;
            this.tbDTReport.Name = "tbDTReport";
            this.tbDTReport.Size = new System.Drawing.Size(561, 344);
            this.tbDTReport.TabIndex = 7;
            // 
            // tbDTRead
            // 
            this.tbDTRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDTRead.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDTRead.Location = new System.Drawing.Point(3, 350);
            this.tbDTRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDTRead.Multiline = true;
            this.tbDTRead.Name = "tbDTRead";
            this.tbDTRead.ReadOnly = true;
            this.tbDTRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDTRead.Size = new System.Drawing.Size(561, 345);
            this.tbDTRead.TabIndex = 8;
            this.tbDTRead.WordWrap = false;
            // 
            // btnWReported
            // 
            this.btnWReported.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWReported.Location = new System.Drawing.Point(584, 2);
            this.btnWReported.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWReported.Name = "btnWReported";
            this.btnWReported.Size = new System.Drawing.Size(73, 44);
            this.btnWReported.TabIndex = 0;
            this.btnWReported.Text = "write Reported";
            this.btnWReported.UseVisualStyleBackColor = true;
            this.btnWReported.Click += new System.EventHandler(this.btnWReported_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnReadDT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDTReadDesired, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(570, 351);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.27737F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.72263F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(86, 238);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnReadDT
            // 
            this.btnReadDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadDT.Location = new System.Drawing.Point(3, 2);
            this.btnReadDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadDT.Name = "btnReadDT";
            this.btnReadDT.Size = new System.Drawing.Size(80, 58);
            this.btnReadDT.TabIndex = 9;
            this.btnReadDT.Text = "read Device Twin";
            this.btnReadDT.UseVisualStyleBackColor = true;
            this.btnReadDT.Click += new System.EventHandler(this.btnReadDT_Click);
            // 
            // btnDTReadDesired
            // 
            this.btnDTReadDesired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDTReadDesired.Location = new System.Drawing.Point(3, 64);
            this.btnDTReadDesired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDTReadDesired.Name = "btnDTReadDesired";
            this.btnDTReadDesired.Size = new System.Drawing.Size(80, 104);
            this.btnDTReadDesired.TabIndex = 1;
            this.btnDTReadDesired.Text = "subscribe on Device Twin Desired Properties";
            this.btnDTReadDesired.UseVisualStyleBackColor = true;
            this.btnDTReadDesired.Click += new System.EventHandler(this.btnRDesired_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.tableLayoutPanel10);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(660, 697);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generate stream";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tbMsgsExample, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.604017F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.39598F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(660, 697);
            this.tableLayoutPanel10.TabIndex = 3;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.btnGenStream, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnGenerateStreamStop, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // btnGenStream
            // 
            this.btnGenStream.Location = new System.Drawing.Point(3, 2);
            this.btnGenStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenStream.Name = "btnGenStream";
            this.btnGenStream.Size = new System.Drawing.Size(94, 42);
            this.btnGenStream.TabIndex = 0;
            this.btnGenStream.Text = "Generate stream - Start";
            this.btnGenStream.UseVisualStyleBackColor = true;
            this.btnGenStream.Click += new System.EventHandler(this.btnGenStream_Click);
            // 
            // btnGenerateStreamStop
            // 
            this.btnGenerateStreamStop.Location = new System.Drawing.Point(103, 2);
            this.btnGenerateStreamStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateStreamStop.Name = "btnGenerateStreamStop";
            this.btnGenerateStreamStop.Size = new System.Drawing.Size(94, 42);
            this.btnGenerateStreamStop.TabIndex = 2;
            this.btnGenerateStreamStop.Text = "Generate stream - Stop";
            this.btnGenerateStreamStop.UseVisualStyleBackColor = true;
            this.btnGenerateStreamStop.Click += new System.EventHandler(this.btnGenerateStreamStop_Click);
            // 
            // tbMsgsExample
            // 
            this.tbMsgsExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMsgsExample.Location = new System.Drawing.Point(3, 54);
            this.tbMsgsExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMsgsExample.Multiline = true;
            this.tbMsgsExample.Name = "tbMsgsExample";
            this.tbMsgsExample.ReadOnly = true;
            this.tbMsgsExample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMsgsExample.Size = new System.Drawing.Size(654, 641);
            this.tbMsgsExample.TabIndex = 1;
            // 
            // tabModuleTwin
            // 
            this.tabModuleTwin.BackColor = System.Drawing.Color.Gray;
            this.tabModuleTwin.Controls.Add(this.tableLayoutPanel12);
            this.tabModuleTwin.Location = new System.Drawing.Point(4, 24);
            this.tabModuleTwin.Name = "tabModuleTwin";
            this.tabModuleTwin.Padding = new System.Windows.Forms.Padding(3);
            this.tabModuleTwin.Size = new System.Drawing.Size(660, 697);
            this.tabModuleTwin.TabIndex = 4;
            this.tabModuleTwin.Text = "ModuleTwin";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tbModuleTwinRepProps, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnModuleTwinDesiredPropsSubsr, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.btnModuleTwinRepProps, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.tbModuletwinDesProps, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(654, 691);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // tbModuleTwinRepProps
            // 
            this.tbModuleTwinRepProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModuleTwinRepProps.Location = new System.Drawing.Point(3, 3);
            this.tbModuleTwinRepProps.Multiline = true;
            this.tbModuleTwinRepProps.Name = "tbModuleTwinRepProps";
            this.tbModuleTwinRepProps.Size = new System.Drawing.Size(321, 339);
            this.tbModuleTwinRepProps.TabIndex = 0;
            // 
            // btnModuleTwinDesiredPropsSubsr
            // 
            this.btnModuleTwinDesiredPropsSubsr.Location = new System.Drawing.Point(330, 348);
            this.btnModuleTwinDesiredPropsSubsr.Name = "btnModuleTwinDesiredPropsSubsr";
            this.btnModuleTwinDesiredPropsSubsr.Size = new System.Drawing.Size(113, 64);
            this.btnModuleTwinDesiredPropsSubsr.TabIndex = 1;
            this.btnModuleTwinDesiredPropsSubsr.Text = "Subscribe module twin desired props";
            this.btnModuleTwinDesiredPropsSubsr.UseVisualStyleBackColor = true;
            this.btnModuleTwinDesiredPropsSubsr.Click += new System.EventHandler(this.btnModuleTwinDesiredPropsSubsr_Click);
            // 
            // btnModuleTwinRepProps
            // 
            this.btnModuleTwinRepProps.Location = new System.Drawing.Point(330, 3);
            this.btnModuleTwinRepProps.Name = "btnModuleTwinRepProps";
            this.btnModuleTwinRepProps.Size = new System.Drawing.Size(102, 51);
            this.btnModuleTwinRepProps.TabIndex = 2;
            this.btnModuleTwinRepProps.Text = "Set reported props";
            this.btnModuleTwinRepProps.UseVisualStyleBackColor = true;
            this.btnModuleTwinRepProps.Click += new System.EventHandler(this.btnModuleTwinRepProps_Click);
            // 
            // tbModuletwinDesProps
            // 
            this.tbModuletwinDesProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModuletwinDesProps.Location = new System.Drawing.Point(3, 348);
            this.tbModuletwinDesProps.Multiline = true;
            this.tbModuletwinDesProps.Name = "tbModuletwinDesProps";
            this.tbModuletwinDesProps.Size = new System.Drawing.Size(321, 340);
            this.tbModuletwinDesProps.TabIndex = 3;
            // 
            // tbDeviceId
            // 
            this.tbDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeviceId.Location = new System.Drawing.Point(226, 2);
            this.tbDeviceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeviceId.Name = "tbDeviceId";
            this.tbDeviceId.ReadOnly = true;
            this.tbDeviceId.Size = new System.Drawing.Size(120, 23);
            this.tbDeviceId.TabIndex = 0;
            this.tbDeviceId.Text = "iothubx509device1";
            // 
            // tbAssignedHub
            // 
            this.tbAssignedHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAssignedHub.Location = new System.Drawing.Point(439, 2);
            this.tbAssignedHub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAssignedHub.Name = "tbAssignedHub";
            this.tbAssignedHub.ReadOnly = true;
            this.tbAssignedHub.Size = new System.Drawing.Size(905, 23);
            this.tbAssignedHub.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Device Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Hub";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lbStatus, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1347, 729);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbAssignedHub, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbDeviceId, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1347, 75);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnRegister, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCreateClient, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(156, 69);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateClient.Location = new System.Drawing.Point(3, 36);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(150, 30);
            this.btnCreateClient.TabIndex = 3;
            this.btnCreateClient.Text = "Create Device Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1353, 816);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 344);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(3, 350);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(166, 345);
            this.textBox2.TabIndex = 8;
            this.textBox2.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(175, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "write Reported";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnWReported_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(117, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "read Device Twin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnReadDT_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(117, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 104);
            this.button3.TabIndex = 1;
            this.button3.Text = "subscribe on Device Twin Desired Properties";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnRDesired_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel7.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1353, 816);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Device";
            this.Text = "Device";
            this.Load += new System.EventHandler(this.Device_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tabModuleTwin.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox lbStatus;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbDeviceId;
        private System.Windows.Forms.TextBox tbAssignedHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDTReadDesired;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbMsgsExample;
        private System.Windows.Forms.Button btnGenStream;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbReceivedMsg;
        private System.Windows.Forms.Button btnReadDT;
        private System.Windows.Forms.Button btnGenerateStreamStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbDTReport;
        private System.Windows.Forms.TextBox tbDTRead;
        private System.Windows.Forms.Button btnWReported;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TabPage tabModuleTwin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox tbModuleTwinRepProps;
        private System.Windows.Forms.Button btnModuleTwinDesiredPropsSubsr;
        private System.Windows.Forms.Button btnModuleTwinRepProps;
        private System.Windows.Forms.TextBox tbModuletwinDesProps;
    }
}
