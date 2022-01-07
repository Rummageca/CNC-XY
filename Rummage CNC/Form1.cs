using System;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rummage_CNC
{

    public partial class Form1 : Form
    {
        public static Form1 self;
        public Form1()
        {
            InitializeComponent();
            self = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            loadsetting();
            Task.Delay(20);
            ConnectSerial_Click(sender, e);
            ConnectSerial.Enabled = false;
        }

        public bool isLooping = false;
        public bool button11WasClicked = false;
        public bool EStopWasClicked = false;
        public int startthreadingnow = 0;
        public int threadcount = 0;

        //----------------------------------------------Load settings-----------------------------------------
        private void loadsetting()
        {
            Saveload s1 = new Saveload();
            s1.loadset();
        }
        //---------------------------------------------recieving information----------------------------------
        private void ConnectSerial_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            Form1.self.richTextBox2.Text += "The following serial ports were found:" + '\n';

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Form1.self.richTextBox2.Text += port + '\n';
            }

            if (Form1.self.serialPort1.IsOpen == false)
            {
                Form1.self.serialPort1.Open();
            }

            Form1.self.DiagnosticsRTB.Text += "Serial Port Open" + Environment.NewLine;
            Form1.self.ConnectSerial.Enabled = false;
        }
        //----------------------------------------baud rate------------serialsettings.cs----------------------
        private void Baud_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.baud1(sender, e);
        }
        //-----------------------------------------com ports------------serialsettings.cs---------------------
        private void Com_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.com1(sender, e);
        }
        //-------------------------------------------parity----------serialsettings.cs------------------------
        private void Parity_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.parity1(sender, e);
        }
        //-----------------------------------------write buffer size----------serialsettings.cs---------------
        private void WriteBuffer_TextChanged(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.writebuff(sender, e);
        }
        //-----------------------------------------read buffer size----------serialsettings.cs----------------
        private void ReadBuffer_TextChanged(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.readbuff(sender, e);
        }
        //-------------------------------------------Stop Bits--------serialsettings.cs-----------------------
        private void StopBit_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.stopbit(sender, e);
        }
        //---------------------------------------serial data bits-------------serialsettings.cs---------------
        private void DataBit_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.databits(sender, e);
        }
        //-----------------------------------------handshake -----------serialsettings.cs---------------------
        private void HandShake_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.handshake1(sender, e);
        }
        //------------------------------------reset serial port-----------serialsettings.cs-------------------
        private void SerialReset_Click(object sender, EventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.serialreset(sender, e);
        }

        //------------- A Axis clear / Half / Double --------------        
        private void zeroX_Click(object sender, EventArgs e)
        {
            inchx.Text = "0.0000";
            MetricX.Text = "0.000";
        }
        private void zeroY_Click(object sender, EventArgs e)
        {
            inchy.Text = "0.0000";
            MetricY.Text = "0.000";
        }
        private void zeroZ_Click(object sender, EventArgs e)
        {
            inchz.Text = "0.0000";
            MetricZ.Text = "0.000";
        }
        private void zeroA_Click(object sender, EventArgs e)
        {
            incha.Text = "0.0000";
            MetricA.Text = "0.000";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            double half = Convert.ToDouble(inchx.Text);
            inchx.Text = Convert.ToString(String.Format("{0:0.0000}", half / 2));
        }
        private void button35_Click(object sender, EventArgs e)
        {
            double doub = Convert.ToDouble(inchx.Text);
            inchx.Text = Convert.ToString(String.Format("{0:0.0000}", doub * 2));
        }
        private void button13_Click(object sender, EventArgs e)
        {
            double half = Convert.ToDouble(inchy.Text);
            inchy.Text = Convert.ToString(String.Format("{0:0.0000}", half / 2));
        }
        private void button36_Click(object sender, EventArgs e)
        {
            double doub = Convert.ToDouble(inchy.Text);
            inchy.Text = Convert.ToString(String.Format("{0:0.0000}", doub * 2));
        }
        private void halfZ_Click(object sender, EventArgs e)
        {
            double half = Convert.ToDouble(inchz.Text);
            inchz.Text = Convert.ToString(String.Format("{0:0.0000}", half / 2));
        }
        private void doubleZ_Click(object sender, EventArgs e)
        {
            double doub = Convert.ToDouble(inchz.Text);
            inchz.Text = Convert.ToString(String.Format("{0:0.0000}", doub * 2));
        }
        private void halfA_Click(object sender, EventArgs e)
        {
            double half = Convert.ToDouble(incha.Text);
            incha.Text = Convert.ToString(String.Format("{0:0.0000}", half / 2));
        }
        private void doubleA_Click(object sender, EventArgs e)
        {
            double doub = Convert.ToDouble(incha.Text);
            incha.Text = Convert.ToString(String.Format("{0:0.0000}", doub * 2));
        }
        //---------- Cutting Loop -----------------------------
        public void SteppersGo_Click(object sender, EventArgs e)
        {
            Steppers s1 = new Steppers();
            s1.turn(sender, e);
        }
        private void buttons_MouseDown(object sender, MouseEventArgs e)
        {
            double cspeed = Convert.ToDouble((sender as Button).Text);

            if (e.Button == MouseButtons.Left)
            {
                if (cspeed > 0 && cspeed <= 75)
                {
                    double newspeed = cspeed + 1;
                    (sender as Button).Text = Convert.ToString(newspeed);
                    if (cspeed >= 75)
                    {
                        cspeed = 1;
                        (sender as Button).Text = Convert.ToString(cspeed);
                    }
                }
                if (cspeed > 75)
                {
                    cspeed = 1;
                    (sender as Button).Text = Convert.ToString(cspeed);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (cspeed > 0 && cspeed <= 75)
                {
                    double newspeed = cspeed - 1;
                    (sender as Button).Text = Convert.ToString(newspeed);
                    if (cspeed <= 1)
                    {
                        cspeed = 75;
                        (sender as Button).Text = Convert.ToString(cspeed);
                    }
                }
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                int[] allorders = new int[]
                {
                    Convert.ToInt32(XnegOrder.Text),
                    Convert.ToInt32(XposOrder.Text),
                    Convert.ToInt32(YnegOrder.Text),
                    Convert.ToInt32(YposOrder.Text),
                    Convert.ToInt32(ZnegOrder.Text),
                    Convert.ToInt32(ZposOrder.Text),
                    Convert.ToInt32(AnegOrder.Text),
                    Convert.ToInt32(AposOrder.Text)
                };

                allorders = allorders.Where(x => x != 0).ToArray();

                for (int i = 0; i < allorders.Length; i++)
                {
                    for (int j = i + 1; j < allorders.Length; j++)
                    {

                        if (allorders[i] == allorders[j])
                        {
                            MessageBox.Show("More than one : " + allorders[i] + " Change The Duplicate To 0 or Other Non Duplicate Number", "Duplicate Loop Sequence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                Smartcontrol s1 = new Smartcontrol();
                s1.loop(sender, e);

            });
        }
        private void loopsequ(object sender, MouseEventArgs e)
        {
            Smartcontrol s1 = new Smartcontrol();
            s1.looporder(sender, e);
        }
        //------------- emergency stop ------------------------
        private void EStop_Click(object sender, EventArgs e)
        {
            EStopWasClicked = true;
            DiagnosticsRTB.Text += "Emergency STOP" + Environment.NewLine;
            ButtonEnabled();
        }
        //-------------- save settings--------------------------
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Saveload s1 = new Saveload();
            s1.saveset(sender, e);
        }
        //--------------- Threading ----------------------------
        private void button25_Click(object sender, EventArgs e)
        {
            startthreadingnow = 1;
        }
        private void button32_Click(object sender, EventArgs e)
        {
            threading s1 = new threading();
            s1.threadtype(sender, e);
        }
        //--------------- paint tabs ----------------------------
        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Drawgraphic s1 = new Drawgraphic();
            s1.Painttab1(sender, e);
        }

        //------------------ RGCode -----------------------------
        private void loadGcode_Click(object sender, EventArgs e)//load
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Form1.self.RGcodeRTB.LoadFile(openFile1.FileName,
                         RichTextBoxStreamType.PlainText);
            }

        }
        private void saveGcode_Click(object sender, EventArgs e)//save
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.DefaultExt = "*.txt";
            SaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                SaveFile.InitialDirectory = @"c:\dro";
                RGcodeRTB.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void RunRGcode_Click(object sender, EventArgs e) //run rgcode
        {
            Task.Factory.StartNew(() =>
            {
                RGcode s1 = new RGcode();
                s1.Readcode();
            });
        }
        private void ExportCode_Click(object sender, EventArgs e)//export RGcode
        {
            RGcode s1 = new RGcode();
            s1.ExportGcode();
        }

        //-------------- Convert inches to metric --------------
        private void inchX_TextChanged(object sender, EventArgs e)
        {
            double updatenum = Convert.ToDouble(inchx.Text);

            MetricX.Text = Convert.ToString(String.Format("{0:0.000}", updatenum * 25.4));
        }

        private void inchY_TextChanged(object sender, EventArgs e)
        {
            double updatenum = Convert.ToDouble(inchy.Text);

            MetricY.Text = Convert.ToString(String.Format("{0:0.000}", updatenum * 25.4));
        }
        private void inchZ_TextChanged(object sender, EventArgs e)
        {
            double updatenum = Convert.ToDouble(inchz.Text);

            MetricZ.Text = Convert.ToString(String.Format("{0:0.000}", updatenum * 25.4));
        }
        private void inchA_TextChanged(object sender, EventArgs e)
        {
            double updatenum = Convert.ToDouble(incha.Text);

            MetricA.Text = Convert.ToString(String.Format("{0:0.000}", updatenum * 25.4));
        }


        //----------------- Clear E STop -----------------------
        private void ClearEstop_Click(object sender, EventArgs e)
        {
            RGcodeRTB.Text = "";

            Form1.self.serialPort1.Write("0\r");
            Form1.self.serialPort1.Write("ccwy\r");
            Form1.self.serialPort1.Write("0\r");
            Form1.self.serialPort1.Write("RGE-Stop\r");

            Form1.self.buttonEnabled.Text = "0";
            ButtonEnabled();
        }
        //------------------ Tapers ----------------------------
        private void CycleTaper_Click(object sender, EventArgs e) // cycle taper
        {
            Tapers s1 = new Tapers();
            s1.setTaper(sender, e);
        }

        private void LongAxis_Click(object sender, EventArgs e)
        {
            string taperAxis = Convert.ToString((sender as Button).Text);

            if (taperAxis == "X Axis")
            {
                (sender as Button).Text = "Z Axis";
            }
            if (taperAxis == "Z Axis")
            {
                (sender as Button).Text = "X Axis";
            }
        }

        private void Slope_Click(object sender, EventArgs e)
        {
            string slope = Convert.ToString((sender as Button).Text);

            if (slope == "In")
            {
                (sender as Button).Text = "Out";
            }
            if (slope == "Out")
            {
                (sender as Button).Text = "In";
            }
        }

        //------------------- Home Axis -------------------------
        private void homes_Click(object sender, EventArgs e)
        {
            Steppers s1 = new Steppers();
            s1.motorMoves(sender, e);
        }
        //----------------- Manual Moves  -----------------------
        private async void manualMoves_MouseDown(object sender, MouseEventArgs e)
        {
            await Task.Factory.StartNew(() =>
            {
                Steppers s1 = new Steppers();
                s1.manualMotorMoves(sender, e);
            });
        }
        private async void manualMoves_MouseUp(object sender, MouseEventArgs e)
        {
            await Task.Run(() =>
            {
                Form1.self.serialPort1.Write("0\r");
                Form1.self.serialPort1.Write("ccwy\r");
                Form1.self.serialPort1.Write("0\r");
                Form1.self.serialPort1.Write("Manual Off\r");
            });
        }
        //--------------- Cycle Radius  --------------------------
        private void CycleRadius_Click(object sender, EventArgs e)
        {
            Radius s1 = new Radius();
            s1.radius(sender, e);
        }
        //--------------- Numbers Only  --------------------------
        private void numonly1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numbers s1 = new Numbers();
            s1.number_KeyPress(sender, e);
        }
        //--------------- Radius  --------------------------------
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Radius s1 = new Radius();
            s1.Radius_MouseClick(sender, e);
        }
        //--------------- Calculator -----------------------------
        private void Calc_Click(object sender, EventArgs e)
        {
            double currentDiam = Convert.ToDouble(CalcDiam.Text);
            double targetDiam = Convert.ToDouble(CalcTagetDiam.Text);
            double cutDepth = Convert.ToDouble(CalcDOC.Text);
            double material = 0;

            if (currentDiam > targetDiam)
            {
                material = currentDiam - targetDiam;
            }
            if (currentDiam < targetDiam)
            {
                material = targetDiam - currentDiam;
            }

            CalcAnswer.Text = "";
            CalcPass.Text = "";
            CalcAnswer.Text = string.Format("{0:0.0000}", material);
            double passes = material / cutDepth;
            CalcPass.Text = string.Format("{0:0.00}", passes);
            CalcRadius.Text = string.Format("{0:0.00}", passes / 2);
        }
        //--------------- Peck Drill ------------------------------
        private void DrillAxis_Click(object sender, EventArgs e)
        {
            string Drillax = DrillAxis.Text;

            if (Drillax == "x")
            {
                DrillAxis.Text = "y";
            }
            if (Drillax == "y")
            {
                DrillAxis.Text = "z";
            }
            if (Drillax == "z")
            {
                DrillAxis.Text = "a";
            }
            if (Drillax == "a")
            {
                DrillAxis.Text = "x";
            }
        }
        private void Drill_Click(object sender, EventArgs e)
        {
            double peckdepth = Convert.ToDouble(peckDepth.Text);
            double totalDrill = Convert.ToDouble(drillDepth.Text);
            double feed = Convert.ToDouble(drillFeed.Text);
            double RapidDrill = Convert.ToDouble(DrillRapid.Text);
            string DrillAx = DrillAxis.Text;
            double nextDrill = peckdepth;

            Form1.self.RGcodeRTB.Text = "";

            for (double i = 0; i < totalDrill; i = (i + peckdepth))
            {
                Form1.self.RGcodeRTB.Text += "{-----Cut-----}\r";
                Form1.self.RGcodeRTB.Text += string.Format("{0}", feed) + " -" + DrillAx + " " + (string.Format("{0:0.0000}", peckdepth * 2) + "\n");
                Form1.self.RGcodeRTB.Text += "{-----rapid out-----}\r";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", RapidDrill) + " +" + DrillAx + " " + (string.Format("{0:0.0000}", nextDrill) + "\n");
                Form1.self.RGcodeRTB.Text += "{--------rapid in---------}\r";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", RapidDrill) + " -" + DrillAx + " " + (string.Format("{0:0.0000}", (nextDrill - peckdepth)) + "\n");

                nextDrill += peckdepth;
            }
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            Drawgraphic s1 = new Drawgraphic();
            s1.Painttab2(sender, e);
        }

        public void ButtonEnabled()
        {
            Cycle4.Enabled = true;
            manualXn.Enabled = true;
            manualXp.Enabled = true;
            manualYn.Enabled = true;
            manualYp.Enabled = true;
            manualZn.Enabled = true;
            manualZp.Enabled = true;
            manualAn.Enabled = true;
            manualAp.Enabled = true;
            LimitX.Enabled = true;
            LimitY.Enabled = true;
            LimitZ.Enabled = true;
            LimitA.Enabled = true;
            ToolSet.Enabled = true;
            RunRGcode.Enabled = true;



        }
        public void ButtonDisabled()
        {
            Cycle4.Enabled = false;
            manualXn.Enabled = false;
            manualXp.Enabled = false;
            manualYn.Enabled = false;
            manualYp.Enabled = false;
            manualZn.Enabled = false;
            manualZp.Enabled = false;
            manualAn.Enabled = false;
            manualAp.Enabled = false;
            LimitX.Enabled = false;
            LimitY.Enabled = false;
            LimitZ.Enabled = false;
            LimitA.Enabled = false;
            ToolSet.Enabled = false;
            RunRGcode.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.UpdateMessageBox(sender, e);
        }

        private void GoThread_TextChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (startthreadingnow == 1)
                {
                    threading s1 = new threading();
                    s1.threadright(sender, e);
                    startthreadingnow = 0;
                }
            });
        }
        private void ToolSet_Click(object sender, EventArgs e)
        {
            Form1.self.buttonEnabled.Text = "1";

            Task.Factory.StartNew(() =>
            {
                ButtonDisabled();

                double thou = Convert.ToDouble(Form1.self.ReturnToStockDiam.Text);
                double convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);
                double convrt2 = thou / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion factor   ---    
                int convrt4 = Convert.ToInt32(convrt2 / convrt3);

                if (IsRadius.Checked == true)
                {
                    convrt4 = convrt4 / 2;
                }

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", convrt4)));
                    Form1.self.serialPort1.Write("ToolSet\r");

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }
                }
                ButtonEnabled();
            });

        }
        private void LimitX_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ButtonDisabled();
                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("LimitX\r");

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }
                    ButtonEnabled();
                }
            });
        }
        private void LimitY_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ButtonDisabled();
                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("LimitY\r");

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }
                    ButtonEnabled();
                }
            });
        }
        private void LimitZ_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ButtonDisabled();
                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("LimitZ\r");

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }
                    ButtonEnabled();
                }
            });
        }
        private void LimitA_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ButtonDisabled();
                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("N/A\r");
                    Form1.self.serialPort1.Write("LimitA\r");

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }
                    ButtonEnabled();
                }
            });
        }

        private void CancelLimit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Form1.self.serialPort1.Write("0\r");
                Form1.self.serialPort1.Write("ccwy\r");
                Form1.self.serialPort1.Write("0\r");
                Form1.self.serialPort1.Write("E-Stop\r");

                Form1.self.buttonEnabled.Text = "0";
                ButtonEnabled();
            });
        }

        private void MetricConv_TextChanged(object sender, EventArgs e)
        {
            if (MetricConv.Text == "")
            {
                MetricConv.Text = "0";
            }

            double MM = Convert.ToDouble(MetricConv.Text);

            double newvalue = MM / 2.54;

            InchConv.Text = string.Format("{0:0.0000}", newvalue);
        }

        private void MetricTPI_TextChanged(object sender, EventArgs e)
        {
            if (MetricTPI.Text == "")
            {
                MetricTPI.Text = "0";
            }

            double MTPI = Convert.ToDouble(MetricTPI.Text);
            double TP = Convert.ToDouble(TPI.Text);

            if (MTPI > 0)
            {
                double conv = 25.4 / MTPI;
                TPI.Text = (string.Format("{0:0.00}", conv));
            }
        }
    }
}









