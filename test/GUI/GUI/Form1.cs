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

namespace GUI
{
    public partial class Form1 : Form
    {
        //Connection Tap variables
        Connection method = new Connection();
        //Serial Port Variables
        SerialPort port1;
        string[] serialPorts = SerialPort.GetPortNames();
        List<byte> RxBuffer = new List<byte>();
        //WiFi Variables
        public TcpClient client = null;
        public NetworkStream netStream = null;

        double xIndex = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbSP_CheckedChanged(sender, e);
            btRefreshSP_Click(sender, e);
        }
        /************************************************************
         * Tap: Connection Tap
         * Purpose: Setting the Connection Method
         * Last Modification: 2014/FEB/14
         * **********************************************************/
        private void rbRC_CheckedChanged(object sender, EventArgs e)
        {
            method.update(1); // Set the method to RC
            // Enble RC and disable SP and wifi
            gbRC.Enabled = true;
            gbSP.Enabled = false;
            gbWIFI.Enabled = false;
        }

        private void rbSP_CheckedChanged(object sender, EventArgs e)
        {
            method.update(2); // Set the method to Serial Port
            // Enble SP and disable RC and wifi
            gbRC.Enabled = false;
            gbSP.Enabled = true;
            gbWIFI.Enabled = false;
        }

        private void rbWIF_CheckedChanged(object sender, EventArgs e)
        {
            method.update(3); // Set the method to wifi
            // Enble wifi and disable RC and SP
            gbRC.Enabled = false;
            gbSP.Enabled = false;
            gbWIFI.Enabled = true;
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
                int badRate = 115200;
                Parity par = Parity.None;
                int dataBits = 8;
                StopBits stpbits = StopBits.One;
                if (port1 == null)
                {
                    port1 = new SerialPort(portName, badRate, par, dataBits, stpbits);
                    port1.Open();
                    port1.DataReceived += new SerialDataReceivedEventHandler(port1_DataReceived);
                }

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

            serialPorts = SerialPort.GetPortNames();
            
            if (0 == serialPorts.Length)
            {
                MessageBox.Show("There is NO Serial Ports Available!");
            }
            else
            {
                foreach (string portName in serialPorts)
                {
                    cbSP.Items.Add(portName);
                    cbSP.Text = portName;
                }
            }
        }
        
        public void updateSerialPort()
        {
            int index = 0;
            // xindex is global double;
            
            //Interpret buffer
            if (RxBuffer.Count > 0)
            {
                if (RxBuffer.Count >= RxBuffer[0])
                {
                    int count = RxBuffer[0];
                    byte[] rxBuff = new byte[count - 1];
                    for (int i = 1; i < count; i++)
                    {
                        rxBuff[i - 1] = RxBuffer[i];
                    }
                    RxBuffer.RemoveRange(0, count);

                    var floatBuff = new float[rxBuff.Length / 4];
                    Buffer.BlockCopy(rxBuff, 0, floatBuff, 0, rxBuff.Length);

                    if (floatBuff.Length == 12)
                    {
                        xIndex += 0.01;

                        for (index = 0; index <= 2; index++)
                        {
                            chartAcce.Series[index].Points.AddXY(xIndex, floatBuff[index]);
                            chartGyro.Series[index].Points.AddXY(xIndex, floatBuff[index + 3]);
                            chartMagn.Series[index].Points.AddXY(xIndex, floatBuff[index + 6]);
                        }
                        //------------------Pitch
                        chartPitch.Series[0].Points.AddXY(xIndex, floatBuff[9]);
                        chartPitch.Series[1].Points.AddXY(xIndex, 0); //for now
                        
                        //------------------Yaw
                        chartYaw.Series[0].Points.AddXY(xIndex, floatBuff[10]);
                        chartYaw.Series[1].Points.AddXY(xIndex, 0); //for now
                        
                        //------------------Roll
                        chartRoll.Series[0].Points.AddXY(xIndex, floatBuff[11]);
                        chartRoll.Series[1].Points.AddXY(xIndex, 0); //for now
                        

                        //----------------------- X-Acce ---------------------//
                        if (cbxAcce.Checked) //X
                        {
                            chartAcce.Series[0].Enabled = true;
                            cbxAcce.Text = "X = " + floatBuff[0].ToString();

                            if (cbxAcce.Text.Length > 9)
                                cbxAcce.Text = cbxAcce.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartAcce.Series[0].Enabled = false;
                            cbxAcce.Text = "X";
                            
                        }

                        //----------------------- Y-Acce ---------------------//
                        if (cbyAcce.Checked) //Y
                        {
                            chartAcce.Series[1].Enabled = true;
                            cbyAcce.Text = "Y = " + floatBuff[1].ToString();

                            if (cbyAcce.Text.Length > 9)
                                cbyAcce.Text = cbyAcce.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartAcce.Series[1].Enabled = false;
                            cbyAcce.Text = "Y";

                        }

                        //----------------------- Z-Acce ---------------------//
                        if (cbzAcce.Checked) //Z
                        {
                            chartAcce.Series[2].Enabled = true;
                            cbzAcce.Text = "Z = " + floatBuff[2].ToString();

                            if (cbzAcce.Text.Length > 9)
                                cbzAcce.Text = cbzAcce.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartAcce.Series[2].Enabled = false;
                            cbzAcce.Text = "Z";

                        }
                        //--------------------End of Acce --------------------//

                        //----------------------- X-Gyro ---------------------//
                        if (cbxGyro.Checked) //X
                        {
                            chartGyro.Series[0].Enabled = true;
                            cbxGyro.Text = "X = " + floatBuff[3].ToString();

                            if (cbxGyro.Text.Length > 9)
                                cbxGyro.Text = cbxGyro.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartGyro.Series[0].Enabled = false;
                            cbxGyro.Text = "X";

                        }
                        //----------------------- Y-Gyro ---------------------//
                        if (cbyGyro.Checked) //Y
                        {
                            chartGyro.Series[1].Enabled = true;
                            cbyGyro.Text = "Y = " + floatBuff[4].ToString();

                            if (cbyGyro.Text.Length > 9)
                                cbyGyro.Text = cbyGyro.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartGyro.Series[1].Enabled = false;
                            cbyGyro.Text = "Y";

                        }
                        //----------------------- Z-Gyro ---------------------//
                        if (cbzGyro.Checked) //Z
                        {
                            chartGyro.Series[2].Enabled = true;
                            cbzGyro.Text = "Z = " + floatBuff[5].ToString();

                            if (cbzGyro.Text.Length > 9)
                                cbzGyro.Text = cbzGyro.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartGyro.Series[2].Enabled = false;
                            cbzGyro.Text = "Z";

                        }

                        //----------------------- X-Magn ---------------------//
                        if (cbxMagn.Checked) //X
                        {
                            chartMagn.Series[0].Enabled = true;
                            cbxMagn.Text = "X = " + floatBuff[6].ToString();

                            if (cbxMagn.Text.Length > 9)
                                cbxMagn.Text = cbxMagn.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartMagn.Series[0].Enabled = false;
                            cbxMagn.Text = "X";

                        }
                        //----------------------- Y-Magn ---------------------//
                        if (cbyMagn.Checked) //Y
                        {
                            chartMagn.Series[1].Enabled = true;
                            cbyMagn.Text = "Y = " + floatBuff[7].ToString();

                            if (cbyMagn.Text.Length > 9)
                                cbyMagn.Text = cbyMagn.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartMagn.Series[1].Enabled = false;
                            cbyMagn.Text = "Y";
                        }
                        //----------------------- Z-Magn ---------------------//
                        if (cbzMagn.Checked) //Z
                        {
                            chartMagn.Series[2].Enabled = true;
                            cbzMagn.Text = "Z = " + floatBuff[8].ToString();

                            if (cbzMagn.Text.Length > 9)
                                cbzMagn.Text = cbzMagn.Text.Substring(0, 9);
                        }
                        else
                        {
                            chartMagn.Series[2].Enabled = false;
                            cbzMagn.Text = "Z";
                        }

                        //----------------------- Pitch - Actual ---------------------//
                        if (cbActualPitch.Checked) //Actual Value
                        {
                            chartPitch.Series[0].Enabled = true;
                            cbActualPitch.Text = "Actual = " + floatBuff[9].ToString();

                            if (cbActualPitch.Text.Length > 15)
                                cbActualPitch.Text = cbActualPitch.Text.Substring(0, 15);
                        }
                        else
                        {
                            chartPitch.Series[0].Enabled = false;
                            cbActualPitch.Text = "Actual";
                        }

                        //----------------------- Yaw - Actual ---------------------//
                        if (cbActualYaw.Checked) //Actual Value
                        {
                            chartYaw.Series[0].Enabled = true;
                            cbActualYaw.Text = "Actual = " + floatBuff[10].ToString();

                            if (cbActualYaw.Text.Length > 15)
                                cbActualYaw.Text = cbActualYaw.Text.Substring(0, 15);
                        }
                        else
                        {
                            chartYaw.Series[0].Enabled = false;
                            cbActualYaw.Text = "Actual";
                        }

                        //----------------------- Roll - Actual ---------------------//
                        if (cbActualRoll.Checked) //Actual Value
                        {
                            chartRoll.Series[0].Enabled = true;
                            cbActualRoll.Text = "Actual = " + floatBuff[11].ToString();

                            if (cbActualRoll.Text.Length > 15)
                                cbActualRoll.Text = cbActualRoll.Text.Substring(0, 15);
                        }
                        else
                        {
                            chartRoll.Series[0].Enabled = false;
                            cbActualRoll.Text = "Actual";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("There is Error in updateSerialPort()");
                    }
                }
            }
            //Send request
            byte[] buffer = { 14, 0x02, 
                                0x10, 0x11, 0x12, 
                                0x20, 0x21, 0x22,
                                0x30, 0x31, 0x32,
                                0x40, 0x41, 0x42};
            port1.Write(buffer, 0, buffer.Length);
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
         * Tap              : Setting Tap
         * Purpose          : 
         * Last Modification: 2014/FEB/14
         * **********************************************************/



        /************************************************************
         * Tap              : Control Tap
         * Purpose          : 
         * Last Modification:
         * **********************************************************/



        /************************************************************
         * Tap              : Sensors Tap
         * Purpose          : 
         * Last Modification: 2014/FEB/14
         * **********************************************************/
        public void updateSnesorCharts()
        {
            //----------------Accel
            chartAcce.ChartAreas[0].AxisY.Maximum = 2;
            chartAcce.ChartAreas[0].AxisY.Minimum = -2;
            chartAcce.ChartAreas[0].AxisY.Interval = 0.5;
            chartAcce.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartAcce.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartAcce.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Gyro
            chartGyro.ChartAreas[0].AxisY.Maximum = 300;
            chartGyro.ChartAreas[0].AxisY.Minimum = -300;
            chartGyro.ChartAreas[0].AxisY.Interval = 100;
            chartGyro.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartGyro.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartGyro.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Magn
            chartMagn.ChartAreas[0].AxisY.Maximum = 0.25;
            chartMagn.ChartAreas[0].AxisY.Minimum = -0.25;
            chartMagn.ChartAreas[0].AxisY.Interval = 0.05;
            chartMagn.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartMagn.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartMagn.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Pitch
            chartPitch.ChartAreas[0].AxisY.Maximum = 1.5;
            chartPitch.ChartAreas[0].AxisY.Minimum = -1.5;
            chartPitch.ChartAreas[0].AxisY.Interval = 0.75;
            chartPitch.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartPitch.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartPitch.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            //----------------Yaw
            chartYaw.ChartAreas[0].AxisY.Maximum = 10;
            chartYaw.ChartAreas[0].AxisY.Minimum = -10;
            chartYaw.ChartAreas[0].AxisY.Interval = 5;
            chartYaw.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartYaw.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartYaw.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
           
            //----------------Roll
            chartRoll.ChartAreas[0].AxisY.Maximum = 0.9;
            chartRoll.ChartAreas[0].AxisY.Minimum = -0.9;
            chartRoll.ChartAreas[0].AxisY.Interval = 0.45;
            chartRoll.ChartAreas[0].AxisX.Minimum = xIndex - 0.24;
            chartRoll.ChartAreas[0].AxisX.Maximum = xIndex + 0.05; ;
            chartRoll.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            

           
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateSerialPort();
            updateSnesorCharts();
        }

      
    }
}
