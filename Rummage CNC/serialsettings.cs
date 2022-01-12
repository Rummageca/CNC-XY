using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Rummage_CNC
{

    class serialsettings
    {
        public long previous = 0;
        string GetLines;
        string[] lines;

        public void UpdateMessageBox(object sender, SerialDataReceivedEventArgs e)
        {

            for (int i = 1; i <= 2; i++)
            {
                GetLines += Form1.self.serialPort1.ReadLine();
            }

            Form1.self.serialPort1.DiscardInBuffer();

            lines = GetLines.Split('\r');

            // Form1.self.RGcodeRTB.Text += GetLines;

            switch (lines[0])
            {
                case "N1":
                    Form1.self.buttonEnabled.Text = "0";
                    break;
                case "X":
                    XReceived();
                    break;
                case "Y":
                    YReceived();
                    break;
                case "Z":
                    ZReceived();
                    break;
                case "Z0":
                    ZeroZ();
                    break;
                case "A":
                    AReceived();
                    break;
                case "Thd":
                    THDReceived();
                    break;
                default:

                    break;
            }
        }
        private void XReceived()
        {
            double toNum = Convert.ToDouble(lines[1]);
            double stepconverstion = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);

            double puls = Convert.ToDouble(Form1.self.XConversion.Text);
            double conv = (toNum * puls) * stepconverstion;
            double oldvalue = Convert.ToDouble(Form1.self.inchx.Text);
            double finished = oldvalue + conv;
            Form1.self.inchx.Text = Convert.ToString(String.Format("{0:0.0000}", finished));           
        }
        private void YReceived()
        {
            double toNum = Convert.ToDouble(lines[1]);
            double stepconverstion = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);

            double puls = Convert.ToDouble(Form1.self.YConversion.Text);
            double conv = (toNum * puls) * stepconverstion;
            double oldvalue = Convert.ToDouble(Form1.self.inchy.Text);
            double finished = oldvalue + conv;
            Form1.self.inchy.Text = Convert.ToString(String.Format("{0:0.0000}", finished));
        }
        private void ZReceived()
        {
            double toNum = Convert.ToDouble(lines[1]);
            double stepconverstion = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);

            double puls = Convert.ToDouble(Form1.self.ZConversion.Text);
            double conv = (toNum * puls) * stepconverstion;
            double oldvalue = Convert.ToDouble(Form1.self.inchz.Text);
            double finished = oldvalue + conv;
            Form1.self.inchz.Text = Convert.ToString(String.Format("{0:0.0000}", finished));            
        }
        private void ZeroZ()
        {
            Form1.self.inchz.Text = "0.0000";
        }
        private void AReceived()
        {
            double toNum = Convert.ToDouble(lines[1]);
            double stepconverstion = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);

            double puls = Convert.ToDouble(Form1.self.AConversion.Text);
            double conv = (toNum * puls) * stepconverstion;
            double oldvalue = Convert.ToDouble(Form1.self.incha.Text);
            double finished = oldvalue + conv;
            Form1.self.incha.Text = Convert.ToString(String.Format("{0:0.0000}", finished));
        }
        private void THDReceived()
        {
            double toNum = Convert.ToDouble(lines[1]);
            Form1.self.RPM.Text = Convert.ToString(toNum);

            Form1.self.threadcount++;

            if (Form1.self.threadcount == 1)
            {
                Form1.self.GoThread.ForeColor = System.Drawing.Color.Lime;
                Form1.self.GoThread.Text = "Waiting For TDC";
            }
            if (Form1.self.threadcount == 2)
            {
                Form1.self.GoThread.ForeColor = System.Drawing.Color.Red;
                Form1.self.GoThread.Text = "Waiting For TDC!";
                Form1.self.threadcount = 0;
            }

        }

        public void serialreset(object sender, EventArgs e)//----------------------------reset serial port--------------------------------
        {
            Form1.self.serialPort1.Close();
            Form1.self.DiagnosticsRTB.Text += "Serial Port Closed" + Environment.NewLine;
            Form1.self.ConnectSerial.Enabled = true;
        }

        public void baud1(object sender, EventArgs e)//-----------------------------------baud rate---------------------------------------
        {
            string baud = Convert.ToString((sender as Button).Text);

            switch (baud)
            {
                case "4800":
                    (sender as Button).Text = "9600";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "9600":
                    (sender as Button).Text = "14400";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "14400":
                    (sender as Button).Text = "19200";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "19200":
                    (sender as Button).Text = "38400";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "38400":
                    (sender as Button).Text = "57600";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "57600":
                    (sender as Button).Text = "115200";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "115200":
                    (sender as Button).Text = "250000";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "250000":
                    (sender as Button).Text = "500000";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                case "500000":
                    (sender as Button).Text = "4800";
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32((sender as Button).Text);
                    break;
                default:
                    break;
            }
        }

        public void com1(object sender, EventArgs e)//-----------------------------com ports-------serialsettings.cs-------------------
        {
            string com = Convert.ToString((sender as Button).Text);
            Form1.self.serialPort1.Close();

            switch (com)
            {
                case "COM1":
                    (sender as Button).Text = "COM2";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM2":
                    (sender as Button).Text = "COM3";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM3":
                    (sender as Button).Text = "COM4";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM4":
                    (sender as Button).Text = "COM5";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM5":
                    (sender as Button).Text = "COM6";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM6":
                    (sender as Button).Text = "COM7";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM7":
                    (sender as Button).Text = "COM8";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM8":
                    (sender as Button).Text = "COM9";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM9":
                    (sender as Button).Text = "COM10";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM10":
                    (sender as Button).Text = "COM11";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM11":
                    (sender as Button).Text = "COM12";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                case "COM12":
                    (sender as Button).Text = "COM1";
                    Form1.self.serialPort1.PortName = (sender as Button).Text;
                    break;
                default:
                    break;
            }
        }

        public void parity1(object sender, EventArgs e)//----------------------------parity-------serialsettings.cs--------------------
        {
            string parity = Convert.ToString((sender as Button).Text);

            switch (parity)
            {
                case "Odd":
                    (sender as Button).Text = "Even";
                    Form1.self.serialPort1.Parity = Parity.Even;
                    break;
                case "Even":
                    (sender as Button).Text = "None";
                    Form1.self.serialPort1.Parity = Parity.None;
                    break;
                case "None":
                    (sender as Button).Text = "Mark";
                    Form1.self.serialPort1.Parity = Parity.Mark;
                    break;
                case "Mark":
                    (sender as Button).Text = "Space";
                    Form1.self.serialPort1.Parity = Parity.Space;
                    break;
                case "Space":
                    (sender as Button).Text = "Odd";
                    Form1.self.serialPort1.Parity = Parity.Odd;
                    break;
                default:
                    break;
            }
        }

        public void writebuff(object sender, EventArgs e)//------------------------------write buffer size-----------------------------
        {
            if (Form1.self.WriteBuffer.Text == "")
            {
                Form1.self.WriteBuffer.Text = "1";
            }

            double Wbuffer = Convert.ToDouble(Form1.self.WriteBuffer.Text);

            Form1.self.serialPort1.WriteBufferSize = Convert.ToInt32(Wbuffer);
        }
        public void readbuff(object sender, EventArgs e)//--------------------------read buffer size-------serialsettings.cs-----------
        {
            if (Form1.self.ReadBuffer.Text == "")
            {
                Form1.self.ReadBuffer.Text = "1";
            }

            double Rbuffer = Convert.ToDouble(Form1.self.ReadBuffer.Text);

            Form1.self.serialPort1.ReadBufferSize = Convert.ToInt32(Rbuffer);

        }

        public void stopbit(object sender, EventArgs e)//----------------------------Stop Bits-------serialsettings.cs------------------
        {
            string baud = Convert.ToString((sender as Button).Text);

            if (baud == "One")
            {
                (sender as Button).Text = "Two";
                Form1.self.serialPort1.StopBits = StopBits.Two;
            }
            if (baud == "Two")
            {
                (sender as Button).Text = "OnePointFive";
                Form1.self.serialPort1.StopBits = StopBits.OnePointFive;
            }
            if (baud == "OnePointFive")
            {
                (sender as Button).Text = "One";
                Form1.self.serialPort1.StopBits = StopBits.One;
            }
        }

        public void databits(object sender, EventArgs e)//---------------------serial data bits--------serialsettings.cs----------------
        {
            string baud = Convert.ToString((sender as Button).Text);

            if (baud == "5")
            {
                (sender as Button).Text = "6";
                Form1.self.serialPort1.DataBits = Convert.ToInt32((sender as Button).Text);
            }
            if (baud == "6")
            {
                (sender as Button).Text = "7";
                Form1.self.serialPort1.DataBits = Convert.ToInt32((sender as Button).Text);
            }
            if (baud == "7")
            {
                (sender as Button).Text = "8";
                Form1.self.serialPort1.DataBits = Convert.ToInt32((sender as Button).Text);
            }
            if (baud == "8")
            {
                (sender as Button).Text = "5";
                Form1.self.serialPort1.DataBits = Convert.ToInt32((sender as Button).Text);
            }

        }
        public void handshake1(object sender, EventArgs e)//----------------handshake -------serialsettings.cs----------------------------
        {
            string baud = Convert.ToString((sender as Button).Text);

            if (baud == "XOnXOff")
            {
                (sender as Button).Text = "None";
                Form1.self.serialPort1.Handshake = Handshake.None;
            }
            if (baud == "None")
            {
                (sender as Button).Text = "RequestToSend";
                Form1.self.serialPort1.Handshake = Handshake.RequestToSend;
            }
            if (baud == "RequestToSend")
            {
                (sender as Button).Text = "RequestToSendXOnXOff";
                Form1.self.serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
            }
            if (baud == "RequestToSendXOnXOff")
            {
                (sender as Button).Text = "XOnXOff";
                Form1.self.serialPort1.Handshake = Handshake.XOnXOff;
            }
        }

    }

}
