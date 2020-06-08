namespace TrafficSimulator
{
    partial class TrafficControl
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdjustSpeed = new System.Windows.Forms.Button();
            this.cmbArrival = new System.Windows.Forms.ComboBox();
            this.cmbQueue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExtention = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picRedLight4 = new System.Windows.Forms.PictureBox();
            this.picRedPedestrian4 = new System.Windows.Forms.PictureBox();
            this.picYellowLight4 = new System.Windows.Forms.PictureBox();
            this.picGreenLight4 = new System.Windows.Forms.PictureBox();
            this.picGreenPedestrian4 = new System.Windows.Forms.PictureBox();
            this.picRedLight3 = new System.Windows.Forms.PictureBox();
            this.picRedPedestrian3 = new System.Windows.Forms.PictureBox();
            this.picYellowLight3 = new System.Windows.Forms.PictureBox();
            this.picGreenPedestrian2 = new System.Windows.Forms.PictureBox();
            this.picRedPedestrian2 = new System.Windows.Forms.PictureBox();
            this.picGreenLight2 = new System.Windows.Forms.PictureBox();
            this.picYellowLight2 = new System.Windows.Forms.PictureBox();
            this.picRedLight2 = new System.Windows.Forms.PictureBox();
            this.picGreenPedestrian = new System.Windows.Forms.PictureBox();
            this.picRedPedestrian = new System.Windows.Forms.PictureBox();
            this.picGreenLight = new System.Windows.Forms.PictureBox();
            this.picYellowLight = new System.Windows.Forms.PictureBox();
            this.picRedLight = new System.Windows.Forms.PictureBox();
            this.picGreenLight3 = new System.Windows.Forms.PictureBox();
            this.picGreenPedestrian3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(9, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Snow;
            this.btnStop.Location = new System.Drawing.Point(866, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 60);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(871, 612);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdjustSpeed
            // 
            this.btnAdjustSpeed.BackColor = System.Drawing.Color.Maroon;
            this.btnAdjustSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjustSpeed.ForeColor = System.Drawing.Color.White;
            this.btnAdjustSpeed.Location = new System.Drawing.Point(3, 161);
            this.btnAdjustSpeed.Name = "btnAdjustSpeed";
            this.btnAdjustSpeed.Size = new System.Drawing.Size(185, 38);
            this.btnAdjustSpeed.TabIndex = 29;
            this.btnAdjustSpeed.Text = "<< ADJUST SPEED >>";
            this.btnAdjustSpeed.UseVisualStyleBackColor = false;
            this.btnAdjustSpeed.Click += new System.EventHandler(this.btnAdjustSpeed_Click);
            // 
            // cmbArrival
            // 
            this.cmbArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArrival.FormattingEnabled = true;
            this.cmbArrival.Items.AddRange(new object[] {
            "ALMOST",
            "FEW",
            "MANY",
            "TOO MANY"});
            this.cmbArrival.Location = new System.Drawing.Point(3, 45);
            this.cmbArrival.Name = "cmbArrival";
            this.cmbArrival.Size = new System.Drawing.Size(150, 23);
            this.cmbArrival.TabIndex = 28;
            this.cmbArrival.Text = "SELECT";
            this.cmbArrival.SelectedIndexChanged += new System.EventHandler(this.cmbArrival_SelectedIndexChanged);
            // 
            // cmbQueue
            // 
            this.cmbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQueue.FormattingEnabled = true;
            this.cmbQueue.Items.AddRange(new object[] {
            "VERY SMALL",
            "SMALL",
            "MEDIUM",
            "LARGE"});
            this.cmbQueue.Location = new System.Drawing.Point(7, 102);
            this.cmbQueue.Name = "cmbQueue";
            this.cmbQueue.Size = new System.Drawing.Size(150, 23);
            this.cmbQueue.TabIndex = 30;
            this.cmbQueue.Text = "SELECT";
            this.cmbQueue.SelectedIndexChanged += new System.EventHandler(this.cmbQueue_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(4, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "EXTENTION >>";
            // 
            // lblExtention
            // 
            this.lblExtention.AutoSize = true;
            this.lblExtention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtention.ForeColor = System.Drawing.Color.Maroon;
            this.lblExtention.Location = new System.Drawing.Point(114, 143);
            this.lblExtention.Name = "lblExtention";
            this.lblExtention.Size = new System.Drawing.Size(19, 15);
            this.lblExtention.TabIndex = 32;
            this.lblExtention.Text = "0 ";
            this.lblExtention.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(159, 48);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(17, 15);
            this.lblArrival.TabIndex = 33;
            this.lblArrival.Text = "0 ";
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(163, 105);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(17, 15);
            this.lblQueue.TabIndex = 34;
            this.lblQueue.Text = "0 ";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Maroon;
            this.txtTime.Location = new System.Drawing.Point(118, 46);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(176, 19);
            this.txtTime.TabIndex = 37;
            this.txtTime.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbArrival);
            this.panel1.Controls.Add(this.btnAdjustSpeed);
            this.panel1.Controls.Add(this.lblQueue);
            this.panel1.Controls.Add(this.cmbQueue);
            this.panel1.Controls.Add(this.lblArrival);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblExtention);
            this.panel1.Location = new System.Drawing.Point(2, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 201);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "QUEUE (East / West)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "ARRIVAL (North / South)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "TRAFFICE MODE SETTING";
            // 
            // picRedLight4
            // 
            this.picRedLight4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picRedLight4.Image = global::TrafficSimulator.Properties.Resources.red_light;
            this.picRedLight4.Location = new System.Drawing.Point(434, 477);
            this.picRedLight4.Name = "picRedLight4";
            this.picRedLight4.Size = new System.Drawing.Size(40, 80);
            this.picRedLight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedLight4.TabIndex = 21;
            this.picRedLight4.TabStop = false;
            // 
            // picRedPedestrian4
            // 
            this.picRedPedestrian4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picRedPedestrian4.Image = global::TrafficSimulator.Properties.Resources.red_walkStop;
            this.picRedPedestrian4.Location = new System.Drawing.Point(489, 478);
            this.picRedPedestrian4.Name = "picRedPedestrian4";
            this.picRedPedestrian4.Size = new System.Drawing.Size(40, 80);
            this.picRedPedestrian4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPedestrian4.TabIndex = 24;
            this.picRedPedestrian4.TabStop = false;
            // 
            // picYellowLight4
            // 
            this.picYellowLight4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picYellowLight4.Image = global::TrafficSimulator.Properties.Resources.yello_light;
            this.picYellowLight4.Location = new System.Drawing.Point(434, 477);
            this.picYellowLight4.Name = "picYellowLight4";
            this.picYellowLight4.Size = new System.Drawing.Size(40, 80);
            this.picYellowLight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYellowLight4.TabIndex = 22;
            this.picYellowLight4.TabStop = false;
            // 
            // picGreenLight4
            // 
            this.picGreenLight4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picGreenLight4.Image = global::TrafficSimulator.Properties.Resources.green_light;
            this.picGreenLight4.Location = new System.Drawing.Point(434, 477);
            this.picGreenLight4.Name = "picGreenLight4";
            this.picGreenLight4.Size = new System.Drawing.Size(40, 80);
            this.picGreenLight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenLight4.TabIndex = 23;
            this.picGreenLight4.TabStop = false;
            // 
            // picGreenPedestrian4
            // 
            this.picGreenPedestrian4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picGreenPedestrian4.Image = global::TrafficSimulator.Properties.Resources.green_walkStart;
            this.picGreenPedestrian4.Location = new System.Drawing.Point(489, 477);
            this.picGreenPedestrian4.Name = "picGreenPedestrian4";
            this.picGreenPedestrian4.Size = new System.Drawing.Size(40, 80);
            this.picGreenPedestrian4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenPedestrian4.TabIndex = 25;
            this.picGreenPedestrian4.TabStop = false;
            // 
            // picRedLight3
            // 
            this.picRedLight3.Image = global::TrafficSimulator.Properties.Resources.red_light;
            this.picRedLight3.Location = new System.Drawing.Point(443, 138);
            this.picRedLight3.Name = "picRedLight3";
            this.picRedLight3.Size = new System.Drawing.Size(40, 80);
            this.picRedLight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedLight3.TabIndex = 16;
            this.picRedLight3.TabStop = false;
            // 
            // picRedPedestrian3
            // 
            this.picRedPedestrian3.Image = global::TrafficSimulator.Properties.Resources.red_walkStop;
            this.picRedPedestrian3.Location = new System.Drawing.Point(498, 138);
            this.picRedPedestrian3.Name = "picRedPedestrian3";
            this.picRedPedestrian3.Size = new System.Drawing.Size(40, 80);
            this.picRedPedestrian3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPedestrian3.TabIndex = 19;
            this.picRedPedestrian3.TabStop = false;
            // 
            // picYellowLight3
            // 
            this.picYellowLight3.Image = global::TrafficSimulator.Properties.Resources.yello_light;
            this.picYellowLight3.Location = new System.Drawing.Point(443, 138);
            this.picYellowLight3.Name = "picYellowLight3";
            this.picYellowLight3.Size = new System.Drawing.Size(40, 80);
            this.picYellowLight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYellowLight3.TabIndex = 17;
            this.picYellowLight3.TabStop = false;
            // 
            // picGreenPedestrian2
            // 
            this.picGreenPedestrian2.Image = global::TrafficSimulator.Properties.Resources.green_walkStart;
            this.picGreenPedestrian2.Location = new System.Drawing.Point(706, 306);
            this.picGreenPedestrian2.Name = "picGreenPedestrian2";
            this.picGreenPedestrian2.Size = new System.Drawing.Size(40, 80);
            this.picGreenPedestrian2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenPedestrian2.TabIndex = 15;
            this.picGreenPedestrian2.TabStop = false;
            // 
            // picRedPedestrian2
            // 
            this.picRedPedestrian2.Image = global::TrafficSimulator.Properties.Resources.red_walkStop;
            this.picRedPedestrian2.Location = new System.Drawing.Point(706, 306);
            this.picRedPedestrian2.Name = "picRedPedestrian2";
            this.picRedPedestrian2.Size = new System.Drawing.Size(40, 80);
            this.picRedPedestrian2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPedestrian2.TabIndex = 14;
            this.picRedPedestrian2.TabStop = false;
            // 
            // picGreenLight2
            // 
            this.picGreenLight2.Image = global::TrafficSimulator.Properties.Resources.green_light;
            this.picGreenLight2.Location = new System.Drawing.Point(651, 306);
            this.picGreenLight2.Name = "picGreenLight2";
            this.picGreenLight2.Size = new System.Drawing.Size(40, 80);
            this.picGreenLight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenLight2.TabIndex = 13;
            this.picGreenLight2.TabStop = false;
            // 
            // picYellowLight2
            // 
            this.picYellowLight2.Image = global::TrafficSimulator.Properties.Resources.yello_light;
            this.picYellowLight2.Location = new System.Drawing.Point(651, 306);
            this.picYellowLight2.Name = "picYellowLight2";
            this.picYellowLight2.Size = new System.Drawing.Size(40, 80);
            this.picYellowLight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYellowLight2.TabIndex = 12;
            this.picYellowLight2.TabStop = false;
            // 
            // picRedLight2
            // 
            this.picRedLight2.Image = global::TrafficSimulator.Properties.Resources.red_light;
            this.picRedLight2.Location = new System.Drawing.Point(651, 306);
            this.picRedLight2.Name = "picRedLight2";
            this.picRedLight2.Size = new System.Drawing.Size(40, 80);
            this.picRedLight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedLight2.TabIndex = 11;
            this.picRedLight2.TabStop = false;
            // 
            // picGreenPedestrian
            // 
            this.picGreenPedestrian.Image = global::TrafficSimulator.Properties.Resources.green_walkStart;
            this.picGreenPedestrian.Location = new System.Drawing.Point(288, 306);
            this.picGreenPedestrian.Name = "picGreenPedestrian";
            this.picGreenPedestrian.Size = new System.Drawing.Size(40, 80);
            this.picGreenPedestrian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenPedestrian.TabIndex = 4;
            this.picGreenPedestrian.TabStop = false;
            // 
            // picRedPedestrian
            // 
            this.picRedPedestrian.Image = global::TrafficSimulator.Properties.Resources.red_walkStop;
            this.picRedPedestrian.Location = new System.Drawing.Point(288, 306);
            this.picRedPedestrian.Name = "picRedPedestrian";
            this.picRedPedestrian.Size = new System.Drawing.Size(40, 80);
            this.picRedPedestrian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPedestrian.TabIndex = 3;
            this.picRedPedestrian.TabStop = false;
            // 
            // picGreenLight
            // 
            this.picGreenLight.Image = global::TrafficSimulator.Properties.Resources.green_light;
            this.picGreenLight.Location = new System.Drawing.Point(233, 306);
            this.picGreenLight.Name = "picGreenLight";
            this.picGreenLight.Size = new System.Drawing.Size(40, 80);
            this.picGreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenLight.TabIndex = 2;
            this.picGreenLight.TabStop = false;
            // 
            // picYellowLight
            // 
            this.picYellowLight.Image = global::TrafficSimulator.Properties.Resources.yello_light;
            this.picYellowLight.Location = new System.Drawing.Point(233, 306);
            this.picYellowLight.Name = "picYellowLight";
            this.picYellowLight.Size = new System.Drawing.Size(40, 80);
            this.picYellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYellowLight.TabIndex = 1;
            this.picYellowLight.TabStop = false;
            // 
            // picRedLight
            // 
            this.picRedLight.Image = global::TrafficSimulator.Properties.Resources.red_light;
            this.picRedLight.Location = new System.Drawing.Point(233, 306);
            this.picRedLight.Name = "picRedLight";
            this.picRedLight.Size = new System.Drawing.Size(40, 80);
            this.picRedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedLight.TabIndex = 0;
            this.picRedLight.TabStop = false;
            // 
            // picGreenLight3
            // 
            this.picGreenLight3.Image = global::TrafficSimulator.Properties.Resources.green_light;
            this.picGreenLight3.Location = new System.Drawing.Point(443, 138);
            this.picGreenLight3.Name = "picGreenLight3";
            this.picGreenLight3.Size = new System.Drawing.Size(40, 80);
            this.picGreenLight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenLight3.TabIndex = 18;
            this.picGreenLight3.TabStop = false;
            // 
            // picGreenPedestrian3
            // 
            this.picGreenPedestrian3.Image = global::TrafficSimulator.Properties.Resources.green_walkStart;
            this.picGreenPedestrian3.Location = new System.Drawing.Point(498, 138);
            this.picGreenPedestrian3.Name = "picGreenPedestrian3";
            this.picGreenPedestrian3.Size = new System.Drawing.Size(40, 80);
            this.picGreenPedestrian3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenPedestrian3.TabIndex = 20;
            this.picGreenPedestrian3.TabStop = false;
            // 
            // TrafficControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::TrafficSimulator.Properties.Resources.croassroads1c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picRedLight4);
            this.Controls.Add(this.picRedPedestrian4);
            this.Controls.Add(this.picYellowLight4);
            this.Controls.Add(this.picGreenLight4);
            this.Controls.Add(this.picGreenPedestrian4);
            this.Controls.Add(this.picRedLight3);
            this.Controls.Add(this.picRedPedestrian3);
            this.Controls.Add(this.picYellowLight3);
            this.Controls.Add(this.picGreenPedestrian2);
            this.Controls.Add(this.picRedPedestrian2);
            this.Controls.Add(this.picGreenLight2);
            this.Controls.Add(this.picYellowLight2);
            this.Controls.Add(this.picRedLight2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picGreenPedestrian);
            this.Controls.Add(this.picRedPedestrian);
            this.Controls.Add(this.picGreenLight);
            this.Controls.Add(this.picYellowLight);
            this.Controls.Add(this.picRedLight);
            this.Controls.Add(this.picGreenLight3);
            this.Controls.Add(this.picGreenPedestrian3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrafficControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Control System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPedestrian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenPedestrian3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRedLight;
        private System.Windows.Forms.PictureBox picYellowLight;
        private System.Windows.Forms.PictureBox picGreenLight;
        private System.Windows.Forms.PictureBox picRedPedestrian;
        private System.Windows.Forms.PictureBox picGreenPedestrian;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picGreenPedestrian2;
        private System.Windows.Forms.PictureBox picRedPedestrian2;
        private System.Windows.Forms.PictureBox picGreenLight2;
        private System.Windows.Forms.PictureBox picYellowLight2;
        private System.Windows.Forms.PictureBox picRedLight2;
        private System.Windows.Forms.PictureBox picGreenPedestrian3;
        private System.Windows.Forms.PictureBox picRedPedestrian3;
        private System.Windows.Forms.PictureBox picGreenLight3;
        private System.Windows.Forms.PictureBox picYellowLight3;
        private System.Windows.Forms.PictureBox picRedLight3;
        private System.Windows.Forms.PictureBox picRedLight4;
        private System.Windows.Forms.PictureBox picRedPedestrian4;
        private System.Windows.Forms.PictureBox picYellowLight4;
        private System.Windows.Forms.PictureBox picGreenLight4;
        private System.Windows.Forms.PictureBox picGreenPedestrian4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdjustSpeed;
        private System.Windows.Forms.ComboBox cmbArrival;
        private System.Windows.Forms.ComboBox cmbQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExtention;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

