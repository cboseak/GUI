using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Added Libraries
using System.IO.Ports;     // For Serial Ports
using System.Net.Sockets;  // For TcpClient, NetworkStream, SocketException
using System.Net;          // For Dns, IPHostEntry, IPAddress
using System.Windows.Media.Media3D; // I think it is for the animation
using System.Runtime.InteropServices; // To use StructLayout & LayoutKind

namespace GUI
{
    public partial class Form1 : Form
    {
        double xIndex = 0.00;
        int deleteME = 0;

        //Connection Tap variables
        Connection method = new Connection();

        //Serial Port Variables
        SerialPort port1;
        //To convert from byte to floats
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct boardRegisters
        {
            public float accel_x;
            public float accel_y;
            public float accel_z;
            public float accel_temp;
            public short accel_x_raw;
            public short accel_y_raw;
            public short accel_z_raw;
            public short accel_temp_raw;
            public float accel_x_raw_avg;
            public float accel_y_raw_avg;
            public float accel_z_raw_avg;

            public float gyro_x;
            public float gyro_y;
            public float gyro_z;
            public float gyro_temp;
            public short gyro_x_raw;
            public short gyro_y_raw;
            public short gyro_z_raw;
            public short gyro_temp_raw;
            public float gyro_x_raw_avg;
            public float gyro_y_raw_avg;
            public float gyro_z_raw_avg;


            public float mag_x;
            public float mag_y;
            public float mag_z;
            public short mag_x_raw;
            public short mag_y_raw;
            public short mag_z_raw;

            public float pitch;
            public float yaw;
            public float roll;
            public float scaled_yaw;
            public float desired_pitch;
            public float desired_yaw;
            public float desired_roll;
            public float desired_throttle;

            public float gui_roll;
            public float gui_pitch;
            public float gui_yaw;
            public float gui_throttle;

            public float motor1;
            public float motor2;
            public float motor3;
            public float motor4;

            public float v_batt;

            public float filter_RollPitch_P;
            public float filter_RollPitch_I;
            public float filter_Yaw_P;
            public float filter_Yaw_I;

            public float PID_Roll_P;
            public float PID_Roll_I;
            public float PID_Roll_D;
            public float PID_Pitch_P;
            public float PID_Pitch_I;
            public float PID_Pitch_D;
            public float PID_Yaw_P;
            public float PID_Yaw_I;
            public float PID_Yaw_D;

        }
        List<byte> RxBuffer = new List<byte>();
        boardRegisters CurrRegs = new boardRegisters();

        //WiFi Variables
        public TcpClient client = null;
        public NetworkStream netStream = null;


        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(GUI_KeyUp);
        }
        void GUI_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
                case Keys.Space://Emergency
                    btShutoffMotors_Click(sender, e);
                    break;
                case Keys.E://Forward
                    btGUIForward_Click(sender, e);
                    break;
                case Keys.D://Backward
                    btGUIBackward_Click(sender, e);
                    break;
                case Keys.F://Right
                    btGUIRight_Click(sender, e);
                    break;
                 case Keys.S://Left
                    btGUILeft_Click(sender, e);
                    break;
                 case Keys.R://Right Yaw
                    btGUIRotateRight_Click(sender, e);
                    break;
                 case Keys.W://Left Yaw
                    btGUIRotateLeft_Click(sender, e);
                    break;
                 case Keys.Q://Go up
                    btGUIIncThrottle_Click(sender, e);
                    break;
                 case Keys.A://Go Down
                    btGUIDecThrottle_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btRefreshSP_Click(sender, e);
        }


        private void port1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int c = port1.BytesToRead;
            for (int i = 0; i < c; i++)
            {
                RxBuffer.Add((byte)(port1.ReadByte()));
            }
        }

        private void btConnectSP_Click(object sender, EventArgs e)
        {
            if (cbSP.Text != "")
            {
                string portName = cbSP.Text;
                rtbDebug.AppendText("Connecting to Serial Port ( " + portName + " )....\n");
                this.Refresh();
                int badRate = 115200;
                Parity par = Parity.None;
                int dataBits = 8;
                StopBits stpbits = StopBits.One;
                if (port1 == null)
                {
                    port1 = new SerialPort(portName, badRate, par, dataBits, stpbits);
                    port1.Open();
                    port1.DataReceived += new SerialDataReceivedEventHandler(port1_DataReceived);
                    rtbDebug.AppendText("Connected Successfully to ( " + portName + " )....\n");
                    connectionStatus.ForeColor = Color.Green;
                    connectionStatus.Text = "Connected to " + port1.PortName;
                }
                else
                    rtbDebug.AppendText("It is already connected to " + port1.PortName + "\n");

                timer1.Interval = 200;
                timer1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Select a serial Port first!");
            }

        }

        private void btRefreshSP_Click(object sender, EventArgs e)
        {
            cbSP.Text = "Select";
            cbSP.Items.Clear();

            string[] serialPorts = SerialPort.GetPortNames();

            if (0 == serialPorts.Length)
            {
                //MessageBox.Show("There are no Serial Ports Available!");
            }
            else
            {
                foreach (string portName in serialPorts)
                {
                    cbSP.Items.Add(portName);
                }
                cbSP.Text = serialPorts[0];
            }
        }


        private void btRefreshWIFI_Click(object sender, EventArgs e)
        {
            cbWIFI.Text = "Select";
            cbWIFI.Items.Clear();

            string myInfo;
            WiFi myNetworks = new WiFi();
            List<KeyValuePair<string, uint>> networkInfo = myNetworks.networksList();
            if (0 == networkInfo.Count)
                MessageBox.Show("There is no Networks available!");
            else
                foreach (var network in networkInfo)
                {
                    myInfo = "%" + network.Value.ToString() + "  " + network.Key;
                    cbWIFI.Items.Add(myInfo);
                }

        }

        /************************************************************
         * Tab              : Control Tab
         * Purpose          : 
         * Last Modification:
         * **********************************************************/
        private void btGUIIncThrottle_Click(object sender, EventArgs e)
        {
            float incr = 2.0F;

            if (CurrRegs.gui_throttle < 100.0)
            {
                send_OffsetThrottle(incr);
            }
        }

        private void btGUIDecThrottle_Click(object sender, EventArgs e)
        {
            float dec = -2.0F;
            if (CurrRegs.gui_throttle > 0.0)
            {
                send_OffsetThrottle(dec);
            }
        }

        private void btGUIRotateLeft_Click(object sender, EventArgs e)
        {
            float angle = -5.0F;

            send_OffsetYaw((float)(angle * Math.PI / 180.0));
        }

        private void btGUIRotateRight_Click(object sender, EventArgs e)
        {
            float angle = 5.0F;

            send_OffsetYaw((float)(angle * Math.PI / 180.0));
        }

        private void btGUIForward_Click(object sender, EventArgs e)
        {
            float angle = -5.0F;

            send_OffsetPitch((float)(angle * Math.PI / 180.0));
        }

        private void btGUIBackward_Click(object sender, EventArgs e)
        {
            float angle = 5.0F;

            send_OffsetPitch((float)(angle * Math.PI / 180.0));
        }

        private void btGUILeft_Click(object sender, EventArgs e)
        {
            float angle = -5.0F;

            send_OffsetRoll((float)(angle * Math.PI / 180.0));
        }

        private void btGUIRight_Click(object sender, EventArgs e)
        {
            float angle = 5.0F;

            send_OffsetRoll((float)(angle * Math.PI / 180.0));
        }

        private void btWritePID_Click(object sender, EventArgs e)
        {
            send_WritePID();
        }

        private void btReadPID_Click(object sender, EventArgs e)
        {
            //Motor PID
            //Roll
            tbMotorRollP.Text = CurrRegs.PID_Roll_P.ToString("0.0######");
            tbMotorRollI.Text = CurrRegs.PID_Roll_I.ToString("0.0######");
            tbMotorRollD.Text = CurrRegs.PID_Roll_D.ToString("0.0######");
            //pitch
            tbMotorPitchP.Text = CurrRegs.PID_Pitch_P.ToString("0.0######");
            tbMotorPitchI.Text = CurrRegs.PID_Pitch_I.ToString("0.0######");
            tbMotorPitchD.Text = CurrRegs.PID_Pitch_D.ToString("0.0######");
            //yaw
            tbMotorYawP.Text = CurrRegs.PID_Yaw_P.ToString("0.0######");
            tbMotorYawI.Text = CurrRegs.PID_Yaw_I.ToString("0.0######");
            tbMotorYawD.Text = CurrRegs.PID_Yaw_D.ToString("0.0######");

            //Filter
            //Roll,Pitch
            tbFilterRollPitchP.Text = CurrRegs.filter_RollPitch_P.ToString("0.0######");
            tbFilterRollPitchI.Text = CurrRegs.filter_RollPitch_I.ToString("0.0######");
            //yaw
            tbFilterYawP.Text = CurrRegs.filter_Yaw_P.ToString("0.0######");
            tbFilterYawI.Text = CurrRegs.filter_Yaw_I.ToString("0.0######");
        }

        private void btResetPID_Click(object sender, EventArgs e)
        {
            send_ResetPID();
        }

        private void btResetFilter_Click(object sender, EventArgs e)
        {
            send_ResetFilter();
        }

        private void btIdleMotor_Click(object sender, EventArgs e)
        {
            send_IdleMotors();
        }

        private void btSoftRestart_Click(object sender, EventArgs e)
        {
            //Doesn't do anything atm
            send_SoftRestart();
        }

        private void btShutoffMotors_Click(object sender, EventArgs e)
        {
            send_ShuttoffMotors();
        }

        private void updateRemoteMotors()
        {
            float max_val = 3250.0F;
            float min_val = 3000.0F;

            tbMotor1.Text = CurrRegs.motor1.ToString();
            tbMotor2.Text = CurrRegs.motor2.ToString();
            tbMotor3.Text = CurrRegs.motor3.ToString();
            tbMotor4.Text = CurrRegs.motor4.ToString();

            float diff_motor1 = CurrRegs.motor1 - min_val;
            float diff_motor2 = CurrRegs.motor2 - min_val;
            float diff_motor3 = CurrRegs.motor3 - min_val;
            float diff_motor4 = CurrRegs.motor4 - min_val;

            if ((diff_motor1 > 0) && (diff_motor2 > 0) &&
                (diff_motor3 > 0) && (diff_motor4 > 0))
            {
                pbMotor1.Value = (int)(100.0 * (diff_motor1) / (max_val - min_val));
                pbMotor2.Value = (int)(100.0 * (diff_motor2) / (max_val - min_val));
                pbMotor3.Value = (int)(100.0 * (diff_motor3) / (max_val - min_val));
                pbMotor4.Value = (int)(100.0 * (diff_motor4) / (max_val - min_val));
            }

            tbBattVolt.Text = CurrRegs.v_batt.ToString("00.0#");

            tbGUIRoll.Text = (CurrRegs.gui_roll * 180.0/Math.PI).ToString("0.#");
            tbGUIPitch.Text = (CurrRegs.gui_pitch * 180.0 / Math.PI).ToString("0.#");
            tbGUIYaw.Text = (CurrRegs.gui_yaw * 180.0 / Math.PI).ToString("0.#");

            if ((CurrRegs.gui_throttle > 0.0) && (CurrRegs.gui_throttle < 100.0))
            {
                trckbarThrottle.Value = (int)CurrRegs.gui_throttle;
            }
            
        }

        /************************************************************
         * Tab              : Sensors Tab
         * Purpose          : 
         * Last Modification: 2014/FEB/14
         * **********************************************************/
        public void shiftCharts()
        {
            //----------------Accel
            chartAcce.ChartAreas[0].AxisY.Maximum = 2;
            chartAcce.ChartAreas[0].AxisY.Minimum = -2;
            chartAcce.ChartAreas[0].AxisY.Interval = 0.5;
            chartAcce.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartAcce.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartAcce.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Gyro
            chartGyro.ChartAreas[0].AxisY.Maximum = 200;
            chartGyro.ChartAreas[0].AxisY.Minimum = -200;
            chartGyro.ChartAreas[0].AxisY.Interval = 100;
            chartGyro.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartGyro.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartGyro.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Magn
            chartMagn.ChartAreas[0].AxisY.Maximum = 0.6;
            chartMagn.ChartAreas[0].AxisY.Minimum = -0.6;
            chartMagn.ChartAreas[0].AxisY.Interval = 0.2;
            chartMagn.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartMagn.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartMagn.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Roll
            chartRoll.ChartAreas[0].AxisY.Maximum = 45;
            chartRoll.ChartAreas[0].AxisY.Minimum = -45;
            chartRoll.ChartAreas[0].AxisY.Interval = 15;
            chartRoll.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartRoll.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartRoll.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Pitch
            chartPitch.ChartAreas[0].AxisY.Maximum = 45;
            chartPitch.ChartAreas[0].AxisY.Minimum = -45;
            chartPitch.ChartAreas[0].AxisY.Interval = 15;
            chartPitch.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartPitch.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartPitch.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Yaw
            chartYaw.ChartAreas[0].AxisY.Maximum = 180;
            chartYaw.ChartAreas[0].AxisY.Minimum = -180;
            chartYaw.ChartAreas[0].AxisY.Interval = 40;
            chartYaw.ChartAreas[0].AxisX.Minimum = xIndex - 0.45;
            chartYaw.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartYaw.ChartAreas[0].AxisX.LabelStyle.Enabled = false;



        }
        private void updateSensorGraphs()
        {
            //----------------------- X-Acce ---------------------//
            chartAcce.Series[0].Points.AddXY(xIndex, CurrRegs.accel_x);
            if (cbxAcce.Checked) //X
            {
                chartAcce.Series[0].Enabled = true;
                cbxAcce.Text = "X = " + CurrRegs.accel_x.ToString();

                if (cbxAcce.Text.Length > 9)
                    cbxAcce.Text = cbxAcce.Text.Substring(0, 9);
            }
            else
            {
                chartAcce.Series[0].Enabled = false;
                cbxAcce.Text = "X";

            }

            //----------------------- Y-Acce ---------------------//
            chartAcce.Series[1].Points.AddXY(xIndex, CurrRegs.accel_y);
            if (cbyAcce.Checked) //Y
            {
                chartAcce.Series[1].Enabled = true;
                cbyAcce.Text = "Y = " + CurrRegs.accel_y.ToString();

                if (cbyAcce.Text.Length > 9)
                    cbyAcce.Text = cbyAcce.Text.Substring(0, 9);
            }
            else
            {
                chartAcce.Series[1].Enabled = false;
                cbyAcce.Text = "Y";

            }

            //----------------------- Z-Acce ---------------------//
            chartAcce.Series[2].Points.AddXY(xIndex, CurrRegs.accel_z);
            if (cbzAcce.Checked) //Z
            {
                chartAcce.Series[2].Enabled = true;
                cbzAcce.Text = "Z = " + CurrRegs.accel_z.ToString();

                if (cbzAcce.Text.Length > 9)
                    cbzAcce.Text = cbzAcce.Text.Substring(0, 9);
            }
            else
            {
                chartAcce.Series[2].Enabled = false;
                cbzAcce.Text = "Z";

            }

            //----------------------- X-Gyro ---------------------//
            chartGyro.Series[0].Points.AddXY(xIndex, CurrRegs.gyro_x);
            if (cbxGyro.Checked) //X
            {
                chartGyro.Series[0].Enabled = true;
                cbxGyro.Text = "X = " + CurrRegs.gyro_x.ToString();

                if (cbxGyro.Text.Length > 9)
                    cbxGyro.Text = cbxGyro.Text.Substring(0, 9);
            }
            else
            {
                chartGyro.Series[0].Enabled = false;
                cbxGyro.Text = "X";

            }
            //----------------------- Y-Gyro ---------------------//
            chartGyro.Series[1].Points.AddXY(xIndex, CurrRegs.gyro_y);
            if (cbyGyro.Checked) //Y
            {
                chartGyro.Series[1].Enabled = true;
                cbyGyro.Text = "Y = " + CurrRegs.gyro_y.ToString();

                if (cbyGyro.Text.Length > 9)
                    cbyGyro.Text = cbyGyro.Text.Substring(0, 9);
            }
            else
            {
                chartGyro.Series[1].Enabled = false;
                cbyGyro.Text = "Y";

            }
            //----------------------- Z-Gyro ---------------------//
            chartGyro.Series[2].Points.AddXY(xIndex, CurrRegs.gyro_z);
            if (cbzGyro.Checked) //Z
            {
                chartGyro.Series[2].Enabled = true;
                cbzGyro.Text = "Z = " + CurrRegs.gyro_z.ToString();

                if (cbzGyro.Text.Length > 9)
                    cbzGyro.Text = cbzGyro.Text.Substring(0, 9);
            }
            else
            {
                chartGyro.Series[2].Enabled = false;
                cbzGyro.Text = "Z";

            }

            //----------------------- X-Magn ---------------------//
            chartMagn.Series[0].Points.AddXY(xIndex, CurrRegs.mag_x);
            if (cbxMagn.Checked) //X
            {
                chartMagn.Series[0].Enabled = true;
                cbxMagn.Text = "X = " + CurrRegs.mag_x.ToString();

                if (cbxMagn.Text.Length > 9)
                    cbxMagn.Text = cbxMagn.Text.Substring(0, 9);
            }
            else
            {
                chartMagn.Series[0].Enabled = false;
                cbxMagn.Text = "X";

            }
            //----------------------- Y-Magn ---------------------//
            chartMagn.Series[1].Points.AddXY(xIndex, CurrRegs.mag_y);
            if (cbyMagn.Checked) //Y
            {
                chartMagn.Series[1].Enabled = true;
                cbyMagn.Text = "Y = " + CurrRegs.mag_y.ToString();

                if (cbyMagn.Text.Length > 9)
                    cbyMagn.Text = cbyMagn.Text.Substring(0, 9);
            }
            else
            {
                chartMagn.Series[1].Enabled = false;
                cbyMagn.Text = "Y";
            }
            //----------------------- Z-Magn ---------------------//
            chartMagn.Series[2].Points.AddXY(xIndex, CurrRegs.mag_z);
            if (cbzMagn.Checked) //Z
            {
                chartMagn.Series[2].Enabled = true;
                cbzMagn.Text = "Z = " + CurrRegs.mag_z.ToString();

                if (cbzMagn.Text.Length > 9)
                    cbzMagn.Text = cbzMagn.Text.Substring(0, 9);
            }
            else
            {
                chartMagn.Series[2].Enabled = false;
                cbzMagn.Text = "Z";
            }
        }

        /************************************************************
         * Tab              : Orientation Tab
         * Purpose          : 
         * Last Modification: 2014/FEB/14
        * **********************************************************/
        private void updateOrientationGraphs()
        {
            double roll_perc_ang = -1*(CurrRegs.roll * 180.0 / Math.PI);
            double pitch_perc_ang = -1 * (CurrRegs.pitch * 180.0 / Math.PI);
            double yaw_perc_ang = -1 * (CurrRegs.yaw * 180.0 / Math.PI);

            double roll_des_ang = ((CurrRegs.desired_roll + CurrRegs.gui_roll) * 180.0 / Math.PI);
            double pitch_des_ang = ((CurrRegs.desired_pitch + CurrRegs.gui_pitch) * 180.0 / Math.PI);
            double yaw_des_ang = ((CurrRegs.desired_yaw + CurrRegs.gui_yaw) * 180.0 / Math.PI);

            //----------------------- Roll - Actual ---------------------//
            chartRoll.Series[0].Points.AddXY(xIndex, roll_perc_ang);
            chartRoll.Series[1].Points.AddXY(xIndex, roll_des_ang);
            tbRollPerc.Text = roll_perc_ang.ToString("0.#");
            tbRollDes.Text = roll_des_ang.ToString("0.#");

            //----------------------- Pitch - Actual ---------------------//
            chartPitch.Series[0].Points.AddXY(xIndex, pitch_perc_ang);
            chartPitch.Series[1].Points.AddXY(xIndex, pitch_des_ang);
            tbPitchPerc.Text = pitch_perc_ang.ToString("0.#");
            tbPitchDes.Text = pitch_des_ang.ToString("0.#");

            //----------------------- Yaw - Actual ---------------------//
            chartYaw.Series[0].Points.AddXY(xIndex, yaw_perc_ang);
            chartYaw.Series[1].Points.AddXY(xIndex, yaw_des_ang);
            tbYawPerc.Text = yaw_perc_ang.ToString("0.#");
            tbYawDes.Text = yaw_des_ang.ToString("0.#");
        }

        /************************************************************

        * **********************************************************/
        boardRegisters fromBytes(byte[] arr)
        {
            boardRegisters str = new boardRegisters();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (boardRegisters)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        public static byte[] StructureToByteArray(object obj)
        {
            //creds not to me
            int len = Marshal.SizeOf(obj);

            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);

            Marshal.StructureToPtr(obj, ptr, true);

            Marshal.Copy(ptr, arr, 0, len);

            Marshal.FreeHGlobal(ptr);

            return arr;

        }


        /************************************************************
        * Communication
        * **********************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            interpretMessages();
            shiftCharts();
        }

        public void interpretMessages()
        {
            //Interpret buffer
            if (RxBuffer.Count > 0)
            {
                //If received a MSG
                if (RxBuffer.Count >= RxBuffer[0])
                {
                    //Convert raw bytes to a struct
                    int count = RxBuffer[0];
                    RxBuffer.RemoveAt(0);
                    CurrRegs = fromBytes(RxBuffer.ToArray());
                    RxBuffer.RemoveRange(0, count - 1);

                    // xindex is global double;
                    xIndex += 0.01;

                    //Update Graphs
                    updateSensorGraphs();
                    updateOrientationGraphs();

                    //update progress bars
                    updateRemoteMotors();

                    //Quad copter model updating
                    quadcopterModel1.UpdateModel(-1 * CurrRegs.roll, -1 * CurrRegs.pitch, -1 * CurrRegs.yaw);

                }
                else
                {
                    //MessageBox.Show("There is Error in updateSerialPort()\n" + "Number of data recieved is 0\n");
                }

            }
            send_requestRegisters();
        }

        private void send_requestRegisters()
        {
            List<byte> buffer2 = new List<byte> 
                               {0x10, 0x11, 0x12, 0x13,
                               0x14, 0x15, 0x16, 0x17,
                                0x18, 0x19, 0x1A,

                                //Gyro
                                0x20, 0x21, 0x22, 0x23,
                                0x24, 0x25, 0x26, 0x27, 
                                0x28, 0x29, 0x2A, 

                                //mag
                                0x30, 0x31, 0x32, 
                                0x33, 0x34, 0x35,

                                //Roll yaw pitch
                                0x40, 0x41, 0x42,
                                //scaled yaw
                                0x43, 
                                //Desired pitch, yaw, roll, throttle
                                0x44, 0x45, 0x46, 0x47,
                                //GUI deserired roll_pitch yaw
                                0x48, 0x49, 0x4A, 0x4B,

                                //motor values
                                0x50, 0x51, 0x52, 0x53,

                                //voltage battery
                                0x60,

                                //Filter RollPitchP, RollPitchI, YawP, YawI
                                0x80, 0x81, 0x82, 0x83,

                                //MotorPID
                                //Roll PID, Pitch PID, Yaw PID
                                0x90, 0x91, 0x92,
                                0x93, 0x94, 0x95,
                                0x96, 0x97, 0x98
                            };

            buffer2.Insert(0, 0x02); //Read reg
            buffer2.Insert(buffer2.Count, 0xFF); //add End of Transmission byte
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }

        private void send_WritePID()
        {
            //filter
            float rollpitch_kp = 0;
            float rollpitch_ki = 0;
            float yaw_kp = 0;
            float yaw_ki = 0;

            float.TryParse(tbFilterRollPitchP.Text, out rollpitch_kp);
            float.TryParse(tbFilterRollPitchI.Text, out rollpitch_ki);
            float.TryParse(tbFilterYawP.Text, out yaw_kp);
            float.TryParse(tbFilterYawI.Text, out yaw_ki);

            byte[] rp_kp = StructureToByteArray(rollpitch_kp);
            byte[] rp_ki = StructureToByteArray(rollpitch_ki);
            byte[] y_kp = StructureToByteArray(yaw_kp);
            byte[] y_ki = StructureToByteArray(yaw_ki);


            float mRollP = 0;
            float mRollI = 0;
            float mRollD = 0;
            float.TryParse(tbMotorRollP.Text, out mRollP);
            float.TryParse(tbMotorRollI.Text, out mRollI);
            float.TryParse(tbMotorRollD.Text, out mRollD);
            byte[] mRollP_b = StructureToByteArray(mRollP);
            byte[] mRollI_b = StructureToByteArray(mRollI);
            byte[] mRollD_b = StructureToByteArray(mRollD);

            float mPitchP = 0;
            float mPitchI = 0;
            float mPitchD = 0;
            float.TryParse(tbMotorPitchP.Text, out mPitchP);
            float.TryParse(tbMotorPitchI.Text, out mPitchI);
            float.TryParse(tbMotorPitchD.Text, out mPitchD);
            byte[] mPitchP_b = StructureToByteArray(mPitchP);
            byte[] mPitchI_b = StructureToByteArray(mPitchI);
            byte[] mPitchD_b = StructureToByteArray(mPitchD);


            float mYawP = 0;
            float mYawI = 0;
            float mYawD = 0;
            float.TryParse(tbMotorYawP.Text, out mYawP);
            float.TryParse(tbMotorYawI.Text, out mYawI);
            float.TryParse(tbMotorYawD.Text, out mYawD);
            byte[] mYawP_b = StructureToByteArray(mYawP);
            byte[] mYawI_b = StructureToByteArray(mYawI);
            byte[] mYawD_b = StructureToByteArray(mYawD);



            List<byte> buffer2 = new List<byte> 
                            {
                                //Filter
                                0x80, rp_kp[0], rp_kp[1], rp_kp[2], rp_kp[3], 
                                0x81, rp_ki[0], rp_ki[1], rp_ki[2], rp_ki[3], 
                                0x82, y_kp[0], y_kp[1], y_kp[2], y_kp[3], 
                                0x83, y_ki[0], y_ki[1], y_ki[2], y_ki[3],

                                //PID
                                0x90, mRollP_b[0], mRollP_b[1], mRollP_b[2], mRollP_b[3],
                                0x91, mRollI_b[0], mRollI_b[1], mRollI_b[2], mRollI_b[3], 
                                0x92, mRollD_b[0], mRollD_b[1], mRollD_b[2], mRollD_b[3], 

                                0x93, mPitchP_b[0], mPitchP_b[1], mPitchP_b[2], mPitchP_b[3], 
                                0x94, mPitchI_b[0], mPitchI_b[1], mPitchI_b[2], mPitchI_b[3], 
                                0x95, mPitchD_b[0], mPitchD_b[1], mPitchD_b[2], mPitchD_b[3], 

                                0x96, mYawP_b[0], mYawP_b[1], mYawP_b[2], mYawP_b[3], 
                                0x97, mYawI_b[0], mYawI_b[1], mYawI_b[2], mYawI_b[3], 
                                0x98, mYawD_b[0], mYawD_b[1], mYawD_b[2], mYawD_b[3], 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);


        }

        private void send_ResetPID()
        {
            List<byte> buffer2 = new List<byte> 
                            {
                                //Reset PID
                                0x99, 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }

        private void send_ResetFilter()
        {
            List<byte> buffer2 = new List<byte> 
                            {
                                //Reset PID
                                0x84, 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }

        private void send_IdleMotors()
        {
            List<byte> buffer2 = new List<byte> 
                            {
                                //Reset PID
                                0x54, 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }

        private void send_SoftRestart()
        {

        }

        private void send_ShuttoffMotors()
        {
            List<byte> buffer2 = new List<byte> 
                            {
                                //Reset PID
                                0x55, 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }



        private void send_OffsetRoll(float offset)
        {
            byte[] value_b = StructureToByteArray(offset);

            List<byte> buffer2 = new List<byte> 
                            {
                                0x4c, value_b[0], value_b[1], value_b[2], value_b[3], 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }
        private void send_OffsetPitch(float offset)
        {
            byte[] value_b = StructureToByteArray(offset);

            List<byte> buffer2 = new List<byte> 
                            {
                                0x4D, value_b[0], value_b[1], value_b[2], value_b[3], 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }
        private void send_OffsetYaw(float offset)
        {
            byte[] value_b = StructureToByteArray(offset);

            List<byte> buffer2 = new List<byte> 
                            {
                                0x4E, value_b[0], value_b[1], value_b[2], value_b[3], 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }
        private void send_OffsetThrottle(float offset)
        {
            byte[] value_b = StructureToByteArray(offset);

            List<byte> buffer2 = new List<byte> 
                            {
                                0x4F, value_b[0], value_b[1], value_b[2], value_b[3], 
                        };


            buffer2.Insert(0, 0x03); //Write reg
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }
    }
}
