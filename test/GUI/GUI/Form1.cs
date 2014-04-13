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

        }
        List<byte> RxBuffer = new List<byte>();
        boardRegisters CurrRegs = new boardRegisters();

        //WiFi Variables
        public TcpClient client = null;
        public NetworkStream netStream = null;


        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("There is NO Serial Ports Available!");
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
                cbzAcce.Text = "Z = " + CurrRegs.accel_y.ToString();

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


            double roll_perc_ang = (CurrRegs.roll * 180.0 / Math.PI);
            double pitch_perc_ang = (CurrRegs.pitch * 180.0 / Math.PI);
            double yaw_perc_ang = (CurrRegs.yaw * 180.0 / Math.PI);

            //----------------------- Pitch - Actual ---------------------//
            chartPitch.Series[0].Points.AddXY(xIndex, pitch_perc_ang);
            chartPitch.Series[1].Points.AddXY(xIndex, 0);
            //if (cbActualPitch.Checked) //Actual Value
            //{
            //    chartPitch.Series[0].Enabled = true;
            //    cbActualPitch.Text = "Actual = " + pitch_ang.ToString();

            //    if (cbActualPitch.Text.Length > 15)
            //        cbActualPitch.Text = cbActualPitch.Text.Substring(0, 15);
            //}
            //else
            //{
            //    chartPitch.Series[0].Enabled = false;
            //    cbActualPitch.Text = "Actual";
            //}

            //----------------------- Yaw - Actual ---------------------//
            chartYaw.Series[0].Points.AddXY(xIndex, yaw_perc_ang);
            chartYaw.Series[1].Points.AddXY(xIndex, 0); //for now
            //if (cbActualYaw.Checked) //Actual Value
            //{
            //    chartYaw.Series[0].Enabled = true;
            //    cbActualYaw.Text = "Actual = " + yaw_ang.ToString();

            //    if (cbActualYaw.Text.Length > 15)
            //        cbActualYaw.Text = cbActualYaw.Text.Substring(0, 15);
            //}
            //else
            //{
            //    chartYaw.Series[0].Enabled = false;
            //    cbActualYaw.Text = "Actual";
            //}

            //----------------------- Roll - Actual ---------------------//
            chartRoll.Series[0].Points.AddXY(xIndex, roll_perc_ang);
            chartRoll.Series[1].Points.AddXY(xIndex, 0); //for now

            //if (cbActualRoll.Checked) //Actual Value
            //{
            //    chartRoll.Series[0].Enabled = true;
            //    cbActualRoll.Text = "Actual = " + roll_ang.ToString();

            //    if (cbActualRoll.Text.Length > 15)
            //        cbActualRoll.Text = cbActualRoll.Text.Substring(0, 15);
            //}
            //else
            //{
            //    chartRoll.Series[0].Enabled = false;
            //    cbActualRoll.Text = "Actual";
            //}
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

                    //Quad copter model updating
                    quadcopterModel1.UpdateModel(CurrRegs.roll, CurrRegs.pitch, CurrRegs.yaw);

                }
                else
                {
                    MessageBox.Show("There is Error in updateSerialPort()\n" + "Number of data recieved is 0\n");
                }

            }
            send_requestRegisters();
        }

        private void send_requestRegisters()
        {
            List<byte> buffer2 = new List<byte> 
                               {0x10, 0x11, 0x12, 0x13,
                                0x14, 0x15, 0x16, 0x17, 

                                //Gyro
                                0x20, 0x21, 0x22, 0x23,
                                0x24, 0x25, 0x26, 0x27, 
                                0x28, 0x29, 0x2A, 

                                //mag
                                0x30, 0x31, 0x32, 
                                0x33, 0x34, 0x35,

                                //Roll yaw pitch
                                0x40, 0x41, 0x42,
                            };
            buffer2.Insert(0, 0x02); //Read reg
            buffer2.Insert(buffer2.Count, 0xFF); //add End of Transmission byte
            buffer2.Insert(0, (byte)(buffer2.Count() + 1));
            byte[] buffer = buffer2.ToArray();

            port1.Write(buffer, 0, buffer.Length);
        }


    }
}
