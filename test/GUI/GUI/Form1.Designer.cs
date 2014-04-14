namespace GUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartMagn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxMagn = new System.Windows.Forms.CheckBox();
            this.cbyMagn = new System.Windows.Forms.CheckBox();
            this.cbzMagn = new System.Windows.Forms.CheckBox();
            this.chartGyro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxGyro = new System.Windows.Forms.CheckBox();
            this.cbyGyro = new System.Windows.Forms.CheckBox();
            this.cbzGyro = new System.Windows.Forms.CheckBox();
            this.chartAcce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxAcce = new System.Windows.Forms.CheckBox();
            this.cbyAcce = new System.Windows.Forms.CheckBox();
            this.cbzAcce = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btIdleMotor = new System.Windows.Forms.Button();
            this.btResetPID = new System.Windows.Forms.Button();
            this.btSoftReset = new System.Windows.Forms.Button();
            this.btResetFilter = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMotorYawD = new System.Windows.Forms.TextBox();
            this.tbMotorYawI = new System.Windows.Forms.TextBox();
            this.tbMotorYawP = new System.Windows.Forms.TextBox();
            this.tbMotorPitchD = new System.Windows.Forms.TextBox();
            this.tbMotorPitchI = new System.Windows.Forms.TextBox();
            this.tbMotorPitchP = new System.Windows.Forms.TextBox();
            this.tbMotorRollD = new System.Windows.Forms.TextBox();
            this.tbMotorRollI = new System.Windows.Forms.TextBox();
            this.tbMotorRollP = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFilterYawI = new System.Windows.Forms.TextBox();
            this.tbFilterRollPitchI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFilterYawP = new System.Windows.Forms.TextBox();
            this.tbFilterRollPitchP = new System.Windows.Forms.TextBox();
            this.btWritePID = new System.Windows.Forms.Button();
            this.btReadPID = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbMotor1 = new System.Windows.Forms.ProgressBar();
            this.tbMotor1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbMotor4 = new System.Windows.Forms.ProgressBar();
            this.tbMotor3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbMotor3 = new System.Windows.Forms.ProgressBar();
            this.tbMotor2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMotor4 = new System.Windows.Forms.TextBox();
            this.pbMotor2 = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.btShutoffMotors = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbSP = new System.Windows.Forms.GroupBox();
            this.btRefreshSP = new System.Windows.Forms.Button();
            this.btConnectSP = new System.Windows.Forms.Button();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.gbWIFI = new System.Windows.Forms.GroupBox();
            this.btRefreshWIFI = new System.Windows.Forms.Button();
            this.btConnectWIFI = new System.Windows.Forms.Button();
            this.cbWIFI = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbYawDes = new System.Windows.Forms.TextBox();
            this.tbYawPerc = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPitchDes = new System.Windows.Forms.TextBox();
            this.tbPitchPerc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRollDes = new System.Windows.Forms.TextBox();
            this.tbRollPerc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chartYaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPitch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chartRoll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label21 = new System.Windows.Forms.Label();
            this.tbBattVolt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.quadcopterModel1 = new GUI.QuadcopterModel();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGyro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAcce)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbSP.SuspendLayout();
            this.gbWIFI.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPitch)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(537, 593);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sensors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartMagn);
            this.groupBox1.Controls.Add(this.cbxMagn);
            this.groupBox1.Controls.Add(this.cbyMagn);
            this.groupBox1.Controls.Add(this.cbzMagn);
            this.groupBox1.Controls.Add(this.chartGyro);
            this.groupBox1.Controls.Add(this.cbxGyro);
            this.groupBox1.Controls.Add(this.cbyGyro);
            this.groupBox1.Controls.Add(this.cbzGyro);
            this.groupBox1.Controls.Add(this.chartAcce);
            this.groupBox1.Controls.Add(this.cbxAcce);
            this.groupBox1.Controls.Add(this.cbyAcce);
            this.groupBox1.Controls.Add(this.cbzAcce);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(527, 587);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // chartMagn
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMagn.ChartAreas.Add(chartArea1);
            this.chartMagn.Location = new System.Drawing.Point(6, 388);
            this.chartMagn.Margin = new System.Windows.Forms.Padding(2);
            this.chartMagn.Name = "chartMagn";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Purple;
            series2.IsVisibleInLegend = false;
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Green;
            series3.IsVisibleInLegend = false;
            series3.Name = "Z";
            this.chartMagn.Series.Add(series1);
            this.chartMagn.Series.Add(series2);
            this.chartMagn.Series.Add(series3);
            this.chartMagn.Size = new System.Drawing.Size(450, 150);
            this.chartMagn.TabIndex = 23;
            this.chartMagn.Text = "chart2";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Magnetometers  Chart Title";
            title1.Text = "Magnetometer (Gauss)";
            this.chartMagn.Titles.Add(title1);
            // 
            // cbxMagn
            // 
            this.cbxMagn.AutoSize = true;
            this.cbxMagn.Checked = true;
            this.cbxMagn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMagn.ForeColor = System.Drawing.Color.Blue;
            this.cbxMagn.Location = new System.Drawing.Point(91, 367);
            this.cbxMagn.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMagn.Name = "cbxMagn";
            this.cbxMagn.Size = new System.Drawing.Size(33, 17);
            this.cbxMagn.TabIndex = 20;
            this.cbxMagn.Text = "X";
            this.cbxMagn.UseVisualStyleBackColor = true;
            // 
            // cbyMagn
            // 
            this.cbyMagn.AutoSize = true;
            this.cbyMagn.Checked = true;
            this.cbyMagn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbyMagn.ForeColor = System.Drawing.Color.Purple;
            this.cbyMagn.Location = new System.Drawing.Point(236, 367);
            this.cbyMagn.Margin = new System.Windows.Forms.Padding(2);
            this.cbyMagn.Name = "cbyMagn";
            this.cbyMagn.Size = new System.Drawing.Size(33, 17);
            this.cbyMagn.TabIndex = 21;
            this.cbyMagn.Text = "Y";
            this.cbyMagn.UseVisualStyleBackColor = true;
            // 
            // cbzMagn
            // 
            this.cbzMagn.AutoSize = true;
            this.cbzMagn.Checked = true;
            this.cbzMagn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbzMagn.ForeColor = System.Drawing.Color.Green;
            this.cbzMagn.Location = new System.Drawing.Point(387, 367);
            this.cbzMagn.Margin = new System.Windows.Forms.Padding(2);
            this.cbzMagn.Name = "cbzMagn";
            this.cbzMagn.Size = new System.Drawing.Size(33, 17);
            this.cbzMagn.TabIndex = 22;
            this.cbzMagn.Text = "Z";
            this.cbzMagn.UseVisualStyleBackColor = true;
            // 
            // chartGyro
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGyro.ChartAreas.Add(chartArea2);
            this.chartGyro.Location = new System.Drawing.Point(6, 213);
            this.chartGyro.Margin = new System.Windows.Forms.Padding(2);
            this.chartGyro.Name = "chartGyro";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsVisibleInLegend = false;
            series4.Name = "X";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Purple;
            series5.IsVisibleInLegend = false;
            series5.Name = "Y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Green;
            series6.IsVisibleInLegend = false;
            series6.Name = "Z";
            this.chartGyro.Series.Add(series4);
            this.chartGyro.Series.Add(series5);
            this.chartGyro.Series.Add(series6);
            this.chartGyro.Size = new System.Drawing.Size(450, 150);
            this.chartGyro.TabIndex = 19;
            this.chartGyro.Text = "chart1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Gyroscope Chart Title";
            title2.Text = "Gyroscope (dps)";
            this.chartGyro.Titles.Add(title2);
            // 
            // cbxGyro
            // 
            this.cbxGyro.AutoSize = true;
            this.cbxGyro.Checked = true;
            this.cbxGyro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGyro.ForeColor = System.Drawing.Color.Blue;
            this.cbxGyro.Location = new System.Drawing.Point(91, 192);
            this.cbxGyro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGyro.Name = "cbxGyro";
            this.cbxGyro.Size = new System.Drawing.Size(33, 17);
            this.cbxGyro.TabIndex = 16;
            this.cbxGyro.Text = "X";
            this.cbxGyro.UseVisualStyleBackColor = true;
            // 
            // cbyGyro
            // 
            this.cbyGyro.AutoSize = true;
            this.cbyGyro.Checked = true;
            this.cbyGyro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbyGyro.ForeColor = System.Drawing.Color.Purple;
            this.cbyGyro.Location = new System.Drawing.Point(236, 192);
            this.cbyGyro.Margin = new System.Windows.Forms.Padding(2);
            this.cbyGyro.Name = "cbyGyro";
            this.cbyGyro.Size = new System.Drawing.Size(33, 17);
            this.cbyGyro.TabIndex = 17;
            this.cbyGyro.Text = "Y";
            this.cbyGyro.UseVisualStyleBackColor = true;
            // 
            // cbzGyro
            // 
            this.cbzGyro.AutoSize = true;
            this.cbzGyro.Checked = true;
            this.cbzGyro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbzGyro.ForeColor = System.Drawing.Color.Green;
            this.cbzGyro.Location = new System.Drawing.Point(387, 192);
            this.cbzGyro.Margin = new System.Windows.Forms.Padding(2);
            this.cbzGyro.Name = "cbzGyro";
            this.cbzGyro.Size = new System.Drawing.Size(33, 17);
            this.cbzGyro.TabIndex = 18;
            this.cbzGyro.Text = "Z";
            this.cbzGyro.UseVisualStyleBackColor = true;
            // 
            // chartAcce
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAcce.ChartAreas.Add(chartArea3);
            this.chartAcce.Location = new System.Drawing.Point(6, 38);
            this.chartAcce.Margin = new System.Windows.Forms.Padding(2);
            this.chartAcce.Name = "chartAcce";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Blue;
            series7.IsVisibleInLegend = false;
            series7.Name = "X";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Purple;
            series8.IsVisibleInLegend = false;
            series8.Name = "Y";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Green;
            series9.IsVisibleInLegend = false;
            series9.Name = "Z";
            this.chartAcce.Series.Add(series7);
            this.chartAcce.Series.Add(series8);
            this.chartAcce.Series.Add(series9);
            this.chartAcce.Size = new System.Drawing.Size(450, 150);
            this.chartAcce.TabIndex = 15;
            this.chartAcce.Text = "chartAcce";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Acceleration Chart Title";
            title3.Text = "Accelerometer (G)";
            this.chartAcce.Titles.Add(title3);
            // 
            // cbxAcce
            // 
            this.cbxAcce.AutoSize = true;
            this.cbxAcce.Checked = true;
            this.cbxAcce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAcce.ForeColor = System.Drawing.Color.Blue;
            this.cbxAcce.Location = new System.Drawing.Point(91, 17);
            this.cbxAcce.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAcce.Name = "cbxAcce";
            this.cbxAcce.Size = new System.Drawing.Size(33, 17);
            this.cbxAcce.TabIndex = 3;
            this.cbxAcce.Text = "X";
            this.cbxAcce.UseVisualStyleBackColor = true;
            // 
            // cbyAcce
            // 
            this.cbyAcce.AutoSize = true;
            this.cbyAcce.Checked = true;
            this.cbyAcce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbyAcce.ForeColor = System.Drawing.Color.Purple;
            this.cbyAcce.Location = new System.Drawing.Point(236, 17);
            this.cbyAcce.Margin = new System.Windows.Forms.Padding(2);
            this.cbyAcce.Name = "cbyAcce";
            this.cbyAcce.Size = new System.Drawing.Size(33, 17);
            this.cbyAcce.TabIndex = 4;
            this.cbyAcce.Text = "Y";
            this.cbyAcce.UseVisualStyleBackColor = true;
            // 
            // cbzAcce
            // 
            this.cbzAcce.AutoSize = true;
            this.cbzAcce.Checked = true;
            this.cbzAcce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbzAcce.ForeColor = System.Drawing.Color.Green;
            this.cbzAcce.Location = new System.Drawing.Point(387, 17);
            this.cbzAcce.Margin = new System.Windows.Forms.Padding(2);
            this.cbzAcce.Name = "cbzAcce";
            this.cbzAcce.Size = new System.Drawing.Size(33, 17);
            this.cbzAcce.TabIndex = 5;
            this.cbzAcce.Text = "Z";
            this.cbzAcce.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(537, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btIdleMotor);
            this.groupBox2.Controls.Add(this.btResetPID);
            this.groupBox2.Controls.Add(this.btSoftReset);
            this.groupBox2.Controls.Add(this.btResetFilter);
            this.groupBox2.Location = new System.Drawing.Point(8, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 82);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // btIdleMotor
            // 
            this.btIdleMotor.Location = new System.Drawing.Point(123, 19);
            this.btIdleMotor.Name = "btIdleMotor";
            this.btIdleMotor.Size = new System.Drawing.Size(75, 23);
            this.btIdleMotor.TabIndex = 23;
            this.btIdleMotor.Text = "Idle Motors";
            this.btIdleMotor.UseVisualStyleBackColor = true;
            this.btIdleMotor.Click += new System.EventHandler(this.btIdleMotor_Click);
            // 
            // btResetPID
            // 
            this.btResetPID.Location = new System.Drawing.Point(11, 19);
            this.btResetPID.Name = "btResetPID";
            this.btResetPID.Size = new System.Drawing.Size(75, 23);
            this.btResetPID.TabIndex = 22;
            this.btResetPID.Text = "Reset PID";
            this.btResetPID.UseVisualStyleBackColor = true;
            this.btResetPID.Click += new System.EventHandler(this.btResetPID_Click);
            // 
            // btSoftReset
            // 
            this.btSoftReset.Location = new System.Drawing.Point(327, 48);
            this.btSoftReset.Name = "btSoftReset";
            this.btSoftReset.Size = new System.Drawing.Size(156, 23);
            this.btSoftReset.TabIndex = 20;
            this.btSoftReset.Text = "Soft Restart";
            this.btSoftReset.UseVisualStyleBackColor = true;
            this.btSoftReset.Click += new System.EventHandler(this.btSoftRestart_Click);
            // 
            // btResetFilter
            // 
            this.btResetFilter.Location = new System.Drawing.Point(11, 48);
            this.btResetFilter.Name = "btResetFilter";
            this.btResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btResetFilter.TabIndex = 21;
            this.btResetFilter.Text = "Reset Filter";
            this.btResetFilter.UseVisualStyleBackColor = true;
            this.btResetFilter.Click += new System.EventHandler(this.btResetFilter_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.btWritePID);
            this.groupBox7.Controls.Add(this.btReadPID);
            this.groupBox7.Location = new System.Drawing.Point(13, 344);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(484, 158);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tune Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbMotorYawD);
            this.groupBox5.Controls.Add(this.tbMotorYawI);
            this.groupBox5.Controls.Add(this.tbMotorYawP);
            this.groupBox5.Controls.Add(this.tbMotorPitchD);
            this.groupBox5.Controls.Add(this.tbMotorPitchI);
            this.groupBox5.Controls.Add(this.tbMotorPitchP);
            this.groupBox5.Controls.Add(this.tbMotorRollD);
            this.groupBox5.Controls.Add(this.tbMotorRollI);
            this.groupBox5.Controls.Add(this.tbMotorRollP);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 123);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor PID Constants";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Yaw";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pitch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roll";
            // 
            // tbMotorYawD
            // 
            this.tbMotorYawD.Location = new System.Drawing.Point(169, 89);
            this.tbMotorYawD.Name = "tbMotorYawD";
            this.tbMotorYawD.Size = new System.Drawing.Size(60, 20);
            this.tbMotorYawD.TabIndex = 8;
            // 
            // tbMotorYawI
            // 
            this.tbMotorYawI.Location = new System.Drawing.Point(103, 89);
            this.tbMotorYawI.Name = "tbMotorYawI";
            this.tbMotorYawI.Size = new System.Drawing.Size(60, 20);
            this.tbMotorYawI.TabIndex = 7;
            // 
            // tbMotorYawP
            // 
            this.tbMotorYawP.Location = new System.Drawing.Point(37, 89);
            this.tbMotorYawP.Name = "tbMotorYawP";
            this.tbMotorYawP.Size = new System.Drawing.Size(60, 20);
            this.tbMotorYawP.TabIndex = 6;
            // 
            // tbMotorPitchD
            // 
            this.tbMotorPitchD.Location = new System.Drawing.Point(169, 61);
            this.tbMotorPitchD.Name = "tbMotorPitchD";
            this.tbMotorPitchD.Size = new System.Drawing.Size(60, 20);
            this.tbMotorPitchD.TabIndex = 5;
            // 
            // tbMotorPitchI
            // 
            this.tbMotorPitchI.Location = new System.Drawing.Point(103, 63);
            this.tbMotorPitchI.Name = "tbMotorPitchI";
            this.tbMotorPitchI.Size = new System.Drawing.Size(60, 20);
            this.tbMotorPitchI.TabIndex = 4;
            // 
            // tbMotorPitchP
            // 
            this.tbMotorPitchP.Location = new System.Drawing.Point(37, 63);
            this.tbMotorPitchP.Name = "tbMotorPitchP";
            this.tbMotorPitchP.Size = new System.Drawing.Size(60, 20);
            this.tbMotorPitchP.TabIndex = 3;
            // 
            // tbMotorRollD
            // 
            this.tbMotorRollD.Location = new System.Drawing.Point(169, 35);
            this.tbMotorRollD.Name = "tbMotorRollD";
            this.tbMotorRollD.Size = new System.Drawing.Size(60, 20);
            this.tbMotorRollD.TabIndex = 2;
            // 
            // tbMotorRollI
            // 
            this.tbMotorRollI.Location = new System.Drawing.Point(103, 35);
            this.tbMotorRollI.Name = "tbMotorRollI";
            this.tbMotorRollI.Size = new System.Drawing.Size(60, 20);
            this.tbMotorRollI.TabIndex = 1;
            // 
            // tbMotorRollP
            // 
            this.tbMotorRollP.Location = new System.Drawing.Point(37, 35);
            this.tbMotorRollP.Name = "tbMotorRollP";
            this.tbMotorRollP.Size = new System.Drawing.Size(60, 20);
            this.tbMotorRollP.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbFilterYawI);
            this.groupBox4.Controls.Add(this.tbFilterRollPitchI);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbFilterYawP);
            this.groupBox4.Controls.Add(this.tbFilterRollPitchP);
            this.groupBox4.Location = new System.Drawing.Point(255, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 92);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter PI Constants";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "I";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "P";
            // 
            // tbFilterYawI
            // 
            this.tbFilterYawI.Location = new System.Drawing.Point(130, 61);
            this.tbFilterYawI.Name = "tbFilterYawI";
            this.tbFilterYawI.Size = new System.Drawing.Size(60, 20);
            this.tbFilterYawI.TabIndex = 8;
            // 
            // tbFilterRollPitchI
            // 
            this.tbFilterRollPitchI.Location = new System.Drawing.Point(130, 35);
            this.tbFilterRollPitchI.Name = "tbFilterRollPitchI";
            this.tbFilterRollPitchI.Size = new System.Drawing.Size(60, 20);
            this.tbFilterRollPitchI.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Yaw";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Roll,Pitch";
            // 
            // tbFilterYawP
            // 
            this.tbFilterYawP.Location = new System.Drawing.Point(64, 61);
            this.tbFilterYawP.Name = "tbFilterYawP";
            this.tbFilterYawP.Size = new System.Drawing.Size(60, 20);
            this.tbFilterYawP.TabIndex = 4;
            // 
            // tbFilterRollPitchP
            // 
            this.tbFilterRollPitchP.Location = new System.Drawing.Point(64, 35);
            this.tbFilterRollPitchP.Name = "tbFilterRollPitchP";
            this.tbFilterRollPitchP.Size = new System.Drawing.Size(60, 20);
            this.tbFilterRollPitchP.TabIndex = 3;
            // 
            // btWritePID
            // 
            this.btWritePID.Location = new System.Drawing.Point(336, 117);
            this.btWritePID.Name = "btWritePID";
            this.btWritePID.Size = new System.Drawing.Size(75, 23);
            this.btWritePID.TabIndex = 18;
            this.btWritePID.Text = "Write";
            this.btWritePID.UseVisualStyleBackColor = true;
            this.btWritePID.Click += new System.EventHandler(this.btWritePID_Click);
            // 
            // btReadPID
            // 
            this.btReadPID.Location = new System.Drawing.Point(255, 117);
            this.btReadPID.Name = "btReadPID";
            this.btReadPID.Size = new System.Drawing.Size(75, 23);
            this.btReadPID.TabIndex = 19;
            this.btReadPID.Text = "Read";
            this.btReadPID.UseVisualStyleBackColor = true;
            this.btReadPID.Click += new System.EventHandler(this.btReadPID_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox3);
            this.groupBox10.Controls.Add(this.groupBox6);
            this.groupBox10.Location = new System.Drawing.Point(13, 4);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(505, 298);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Remote Control";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 34);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 98);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Value = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.tbBattVolt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pbMotor1);
            this.groupBox3.Controls.Add(this.tbMotor1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pbMotor4);
            this.groupBox3.Controls.Add(this.tbMotor3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pbMotor3);
            this.groupBox3.Controls.Add(this.tbMotor2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbMotor4);
            this.groupBox3.Controls.Add(this.pbMotor2);
            this.groupBox3.Location = new System.Drawing.Point(15, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(485, 77);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motors Status";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(345, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "MOTOR 3";
            // 
            // pbMotor1
            // 
            this.pbMotor1.Location = new System.Drawing.Point(70, 22);
            this.pbMotor1.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor1.Name = "pbMotor1";
            this.pbMotor1.Size = new System.Drawing.Size(83, 16);
            this.pbMotor1.TabIndex = 1;
            // 
            // tbMotor1
            // 
            this.tbMotor1.Enabled = false;
            this.tbMotor1.Location = new System.Drawing.Point(158, 22);
            this.tbMotor1.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotor1.Name = "tbMotor1";
            this.tbMotor1.Size = new System.Drawing.Size(38, 20);
            this.tbMotor1.TabIndex = 4;
            this.tbMotor1.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "MOTOR 4";
            // 
            // pbMotor4
            // 
            this.pbMotor4.Location = new System.Drawing.Point(70, 51);
            this.pbMotor4.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor4.Name = "pbMotor4";
            this.pbMotor4.Size = new System.Drawing.Size(83, 16);
            this.pbMotor4.TabIndex = 3;
            // 
            // tbMotor3
            // 
            this.tbMotor3.Enabled = false;
            this.tbMotor3.Location = new System.Drawing.Point(217, 51);
            this.tbMotor3.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotor3.Name = "tbMotor3";
            this.tbMotor3.Size = new System.Drawing.Size(38, 20);
            this.tbMotor3.TabIndex = 5;
            this.tbMotor3.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(346, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "MOTOR 2";
            // 
            // pbMotor3
            // 
            this.pbMotor3.Location = new System.Drawing.Point(259, 52);
            this.pbMotor3.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor3.Name = "pbMotor3";
            this.pbMotor3.Size = new System.Drawing.Size(83, 16);
            this.pbMotor3.TabIndex = 2;
            // 
            // tbMotor2
            // 
            this.tbMotor2.Enabled = false;
            this.tbMotor2.Location = new System.Drawing.Point(217, 22);
            this.tbMotor2.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotor2.Name = "tbMotor2";
            this.tbMotor2.Size = new System.Drawing.Size(38, 20);
            this.tbMotor2.TabIndex = 6;
            this.tbMotor2.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "MOTOR 1";
            // 
            // tbMotor4
            // 
            this.tbMotor4.Enabled = false;
            this.tbMotor4.Location = new System.Drawing.Point(158, 51);
            this.tbMotor4.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotor4.Name = "tbMotor4";
            this.tbMotor4.Size = new System.Drawing.Size(38, 20);
            this.tbMotor4.TabIndex = 7;
            this.tbMotor4.Text = "0";
            // 
            // pbMotor2
            // 
            this.pbMotor2.Location = new System.Drawing.Point(259, 22);
            this.pbMotor2.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor2.Name = "pbMotor2";
            this.pbMotor2.Size = new System.Drawing.Size(83, 16);
            this.pbMotor2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.btShutoffMotors);
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.button18);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Location = new System.Drawing.Point(15, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 190);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Icons";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button13.Location = new System.Drawing.Point(200, 41);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 37);
            this.button13.TabIndex = 4;
            this.button13.Text = "Forward";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btShutoffMotors
            // 
            this.btShutoffMotors.BackColor = System.Drawing.Color.Red;
            this.btShutoffMotors.Location = new System.Drawing.Point(396, 61);
            this.btShutoffMotors.Margin = new System.Windows.Forms.Padding(2);
            this.btShutoffMotors.Name = "btShutoffMotors";
            this.btShutoffMotors.Size = new System.Drawing.Size(89, 80);
            this.btShutoffMotors.TabIndex = 10;
            this.btShutoffMotors.Text = "Shutoff Motors";
            this.btShutoffMotors.UseVisualStyleBackColor = false;
            this.btShutoffMotors.Click += new System.EventHandler(this.btShutoffMotors_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button15.Location = new System.Drawing.Point(141, 83);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 37);
            this.button15.TabIndex = 6;
            this.button15.Text = "Left";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Orange;
            this.button11.Location = new System.Drawing.Point(125, 18);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 22);
            this.button11.TabIndex = 2;
            this.button11.Text = "Rotate L.";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button14.Location = new System.Drawing.Point(200, 125);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(65, 37);
            this.button14.TabIndex = 5;
            this.button14.Text = "Backward";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button18.Location = new System.Drawing.Point(11, 164);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(41, 21);
            this.button18.TabIndex = 9;
            this.button18.Text = "Dec";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button16.Location = new System.Drawing.Point(263, 83);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(58, 37);
            this.button16.TabIndex = 7;
            this.button16.Text = "Right";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Orange;
            this.button12.Location = new System.Drawing.Point(263, 18);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 22);
            this.button12.TabIndex = 3;
            this.button12.Text = "Rotate R.";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button17.Location = new System.Drawing.Point(11, 137);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(41, 22);
            this.button17.TabIndex = 8;
            this.button17.Text = "Inc";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbDebug);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.gbSP);
            this.tabPage1.Controls.Add(this.gbWIFI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(537, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbDebug
            // 
            this.rtbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDebug.Location = new System.Drawing.Point(19, 307);
            this.rtbDebug.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(329, 225);
            this.rtbDebug.TabIndex = 4;
            this.rtbDebug.Text = resources.GetString("rtbDebug.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(2, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // connectionStatus
            // 
            this.connectionStatus.ForeColor = System.Drawing.Color.Red;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(88, 17);
            this.connectionStatus.Text = "Not Connected";
            // 
            // gbSP
            // 
            this.gbSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSP.AutoSize = true;
            this.gbSP.Controls.Add(this.btRefreshSP);
            this.gbSP.Controls.Add(this.btConnectSP);
            this.gbSP.Controls.Add(this.cbSP);
            this.gbSP.Location = new System.Drawing.Point(7, 19);
            this.gbSP.Margin = new System.Windows.Forms.Padding(2);
            this.gbSP.Name = "gbSP";
            this.gbSP.Padding = new System.Windows.Forms.Padding(2);
            this.gbSP.Size = new System.Drawing.Size(242, 161);
            this.gbSP.TabIndex = 2;
            this.gbSP.TabStop = false;
            this.gbSP.Text = "Serial Port";
            // 
            // btRefreshSP
            // 
            this.btRefreshSP.Location = new System.Drawing.Point(4, 64);
            this.btRefreshSP.Margin = new System.Windows.Forms.Padding(2);
            this.btRefreshSP.Name = "btRefreshSP";
            this.btRefreshSP.Size = new System.Drawing.Size(74, 28);
            this.btRefreshSP.TabIndex = 4;
            this.btRefreshSP.Text = "Refresh";
            this.btRefreshSP.UseVisualStyleBackColor = true;
            this.btRefreshSP.Click += new System.EventHandler(this.btRefreshSP_Click);
            // 
            // btConnectSP
            // 
            this.btConnectSP.Location = new System.Drawing.Point(4, 110);
            this.btConnectSP.Margin = new System.Windows.Forms.Padding(2);
            this.btConnectSP.Name = "btConnectSP";
            this.btConnectSP.Size = new System.Drawing.Size(74, 28);
            this.btConnectSP.TabIndex = 1;
            this.btConnectSP.Text = "Connect";
            this.btConnectSP.UseVisualStyleBackColor = true;
            this.btConnectSP.Click += new System.EventHandler(this.btConnectSP_Click);
            // 
            // cbSP
            // 
            this.cbSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(4, 30);
            this.cbSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(234, 21);
            this.cbSP.TabIndex = 3;
            // 
            // gbWIFI
            // 
            this.gbWIFI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWIFI.AutoSize = true;
            this.gbWIFI.Controls.Add(this.btRefreshWIFI);
            this.gbWIFI.Controls.Add(this.btConnectWIFI);
            this.gbWIFI.Controls.Add(this.cbWIFI);
            this.gbWIFI.Location = new System.Drawing.Point(269, 19);
            this.gbWIFI.Margin = new System.Windows.Forms.Padding(2);
            this.gbWIFI.Name = "gbWIFI";
            this.gbWIFI.Padding = new System.Windows.Forms.Padding(2);
            this.gbWIFI.Size = new System.Drawing.Size(238, 161);
            this.gbWIFI.TabIndex = 2;
            this.gbWIFI.TabStop = false;
            this.gbWIFI.Text = "WIFI";
            // 
            // btRefreshWIFI
            // 
            this.btRefreshWIFI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshWIFI.Location = new System.Drawing.Point(5, 64);
            this.btRefreshWIFI.Margin = new System.Windows.Forms.Padding(2);
            this.btRefreshWIFI.Name = "btRefreshWIFI";
            this.btRefreshWIFI.Size = new System.Drawing.Size(74, 28);
            this.btRefreshWIFI.TabIndex = 6;
            this.btRefreshWIFI.Text = "Refresh";
            this.btRefreshWIFI.UseVisualStyleBackColor = true;
            this.btRefreshWIFI.Click += new System.EventHandler(this.btRefreshWIFI_Click);
            // 
            // btConnectWIFI
            // 
            this.btConnectWIFI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnectWIFI.Location = new System.Drawing.Point(5, 110);
            this.btConnectWIFI.Margin = new System.Windows.Forms.Padding(2);
            this.btConnectWIFI.Name = "btConnectWIFI";
            this.btConnectWIFI.Size = new System.Drawing.Size(74, 28);
            this.btConnectWIFI.TabIndex = 5;
            this.btConnectWIFI.Text = "Connect";
            this.btConnectWIFI.UseVisualStyleBackColor = true;
            // 
            // cbWIFI
            // 
            this.cbWIFI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWIFI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWIFI.FormattingEnabled = true;
            this.cbWIFI.Location = new System.Drawing.Point(5, 30);
            this.cbWIFI.Margin = new System.Windows.Forms.Padding(2);
            this.cbWIFI.Name = "cbWIFI";
            this.cbWIFI.Size = new System.Drawing.Size(229, 21);
            this.cbWIFI.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbYawDes);
            this.tabPage5.Controls.Add(this.tbYawPerc);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.tbPitchDes);
            this.tabPage5.Controls.Add(this.tbPitchPerc);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.tbRollDes);
            this.tabPage5.Controls.Add(this.tbRollPerc);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.chartYaw);
            this.tabPage5.Controls.Add(this.chartPitch);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.chartRoll);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(537, 593);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Orientation";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbYawDes
            // 
            this.tbYawDes.Location = new System.Drawing.Point(434, 535);
            this.tbYawDes.Name = "tbYawDes";
            this.tbYawDes.ReadOnly = true;
            this.tbYawDes.Size = new System.Drawing.Size(58, 20);
            this.tbYawDes.TabIndex = 35;
            // 
            // tbYawPerc
            // 
            this.tbYawPerc.AcceptsReturn = true;
            this.tbYawPerc.Location = new System.Drawing.Point(434, 492);
            this.tbYawPerc.Name = "tbYawPerc";
            this.tbYawPerc.ReadOnly = true;
            this.tbYawPerc.Size = new System.Drawing.Size(58, 20);
            this.tbYawPerc.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(431, 476);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Perceived";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(431, 519);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Desired";
            // 
            // tbPitchDes
            // 
            this.tbPitchDes.Location = new System.Drawing.Point(434, 403);
            this.tbPitchDes.Name = "tbPitchDes";
            this.tbPitchDes.ReadOnly = true;
            this.tbPitchDes.Size = new System.Drawing.Size(58, 20);
            this.tbPitchDes.TabIndex = 31;
            // 
            // tbPitchPerc
            // 
            this.tbPitchPerc.Location = new System.Drawing.Point(434, 360);
            this.tbPitchPerc.Name = "tbPitchPerc";
            this.tbPitchPerc.ReadOnly = true;
            this.tbPitchPerc.Size = new System.Drawing.Size(58, 20);
            this.tbPitchPerc.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(431, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Perceived";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(431, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Desired";
            // 
            // tbRollDes
            // 
            this.tbRollDes.Location = new System.Drawing.Point(434, 281);
            this.tbRollDes.Name = "tbRollDes";
            this.tbRollDes.ReadOnly = true;
            this.tbRollDes.Size = new System.Drawing.Size(58, 20);
            this.tbRollDes.TabIndex = 27;
            // 
            // tbRollPerc
            // 
            this.tbRollPerc.Location = new System.Drawing.Point(434, 238);
            this.tbRollPerc.Name = "tbRollPerc";
            this.tbRollPerc.ReadOnly = true;
            this.tbRollPerc.Size = new System.Drawing.Size(58, 20);
            this.tbRollPerc.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(431, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Perceived";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(431, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Desired";
            // 
            // chartYaw
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.Name = "ChartArea1";
            this.chartYaw.ChartAreas.Add(chartArea4);
            this.chartYaw.Location = new System.Drawing.Point(-16, 455);
            this.chartYaw.Margin = new System.Windows.Forms.Padding(2);
            this.chartYaw.Name = "chartYaw";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Blue;
            series10.IsVisibleInLegend = false;
            series10.Name = "X";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Red;
            series11.IsVisibleInLegend = false;
            series11.Name = "Y";
            this.chartYaw.Series.Add(series10);
            this.chartYaw.Series.Add(series11);
            this.chartYaw.Size = new System.Drawing.Size(445, 125);
            this.chartYaw.TabIndex = 22;
            this.chartYaw.Text = "chart1";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.DockedToChartArea = "ChartArea1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Yaw Chart Title";
            title4.Text = "Yaw";
            this.chartYaw.Titles.Add(title4);
            // 
            // chartPitch
            // 
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.Name = "ChartArea1";
            this.chartPitch.ChartAreas.Add(chartArea5);
            this.chartPitch.Location = new System.Drawing.Point(-16, 326);
            this.chartPitch.Margin = new System.Windows.Forms.Padding(2);
            this.chartPitch.Name = "chartPitch";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.IsVisibleInLegend = false;
            series12.Name = "X";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Red;
            series13.IsVisibleInLegend = false;
            series13.Name = "Y";
            this.chartPitch.Series.Add(series12);
            this.chartPitch.Series.Add(series13);
            this.chartPitch.Size = new System.Drawing.Size(445, 125);
            this.chartPitch.TabIndex = 16;
            this.chartPitch.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.DockedToChartArea = "ChartArea1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Pitch Chart Title";
            title5.Text = "Pitch";
            this.chartPitch.Titles.Add(title5);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.elementHost1);
            this.groupBox11.Location = new System.Drawing.Point(85, 3);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox11.Size = new System.Drawing.Size(334, 200);
            this.groupBox11.TabIndex = 23;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Animation";
            // 
            // chartRoll
            // 
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.Name = "ChartArea1";
            this.chartRoll.ChartAreas.Add(chartArea6);
            this.chartRoll.Location = new System.Drawing.Point(-16, 207);
            this.chartRoll.Margin = new System.Windows.Forms.Padding(2);
            this.chartRoll.Name = "chartRoll";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Blue;
            series14.IsVisibleInLegend = false;
            series14.Name = "X";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Red;
            series15.IsVisibleInLegend = false;
            series15.Name = "Y";
            this.chartRoll.Series.Add(series14);
            this.chartRoll.Series.Add(series15);
            this.chartRoll.Size = new System.Drawing.Size(445, 125);
            this.chartRoll.TabIndex = 19;
            this.chartRoll.Text = "chart1";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.DockedToChartArea = "ChartArea1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Roll Chart Title";
            title6.Text = "Roll";
            this.chartRoll.Titles.Add(title6);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Throttle";
            // 
            // tbBattVolt
            // 
            this.tbBattVolt.Enabled = false;
            this.tbBattVolt.Location = new System.Drawing.Point(418, 38);
            this.tbBattVolt.Name = "tbBattVolt";
            this.tbBattVolt.Size = new System.Drawing.Size(62, 20);
            this.tbBattVolt.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(423, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Batt. Volt";
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.Gainsboro;
            this.elementHost1.Location = new System.Drawing.Point(3, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(326, 185);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.quadcopterModel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 621);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Senior Design Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGyro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAcce)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbSP.ResumeLayout(false);
            this.gbWIFI.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPitch)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMagn;
        private System.Windows.Forms.CheckBox cbxMagn;
        private System.Windows.Forms.CheckBox cbyMagn;
        private System.Windows.Forms.CheckBox cbzMagn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGyro;
        private System.Windows.Forms.CheckBox cbxGyro;
        private System.Windows.Forms.CheckBox cbyGyro;
        private System.Windows.Forms.CheckBox cbzGyro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAcce;
        private System.Windows.Forms.CheckBox cbxAcce;
        private System.Windows.Forms.CheckBox cbyAcce;
        private System.Windows.Forms.CheckBox cbzAcce;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btShutoffMotors;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        private System.Windows.Forms.GroupBox gbSP;
        private System.Windows.Forms.Button btRefreshSP;
        private System.Windows.Forms.Button btConnectSP;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.GroupBox gbWIFI;
        private System.Windows.Forms.Button btRefreshWIFI;
        private System.Windows.Forms.Button btConnectWIFI;
        private System.Windows.Forms.ComboBox cbWIFI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPitch;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbMotor1;
        private System.Windows.Forms.TextBox tbMotor1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbMotor4;
        private System.Windows.Forms.TextBox tbMotor3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbMotor3;
        private System.Windows.Forms.TextBox tbMotor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMotor4;
        private System.Windows.Forms.ProgressBar pbMotor2;
        private System.Windows.Forms.Button btResetPID;
        private System.Windows.Forms.Button btResetFilter;
        private System.Windows.Forms.Button btSoftReset;
        private System.Windows.Forms.Button btReadPID;
        private System.Windows.Forms.Button btWritePID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMotorYawD;
        private System.Windows.Forms.TextBox tbMotorYawI;
        private System.Windows.Forms.TextBox tbMotorYawP;
        private System.Windows.Forms.TextBox tbMotorPitchD;
        private System.Windows.Forms.TextBox tbMotorPitchI;
        private System.Windows.Forms.TextBox tbMotorPitchP;
        private System.Windows.Forms.TextBox tbMotorRollD;
        private System.Windows.Forms.TextBox tbMotorRollI;
        private System.Windows.Forms.TextBox tbMotorRollP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFilterYawI;
        private System.Windows.Forms.TextBox tbFilterRollPitchI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFilterYawP;
        private System.Windows.Forms.TextBox tbFilterRollPitchP;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbRollDes;
        private System.Windows.Forms.TextBox tbRollPerc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbYawDes;
        private System.Windows.Forms.TextBox tbYawPerc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbPitchDes;
        private System.Windows.Forms.TextBox tbPitchPerc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btIdleMotor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbBattVolt;
        private QuadcopterModel quadcopterModel1;
    }
}

