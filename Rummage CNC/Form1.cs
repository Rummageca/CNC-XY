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
            bootupOk();

            
        }

        public bool isLooping = false;
        public bool button11WasClicked = false;
        public bool EStopWasClicked = false;
        public int startthreadingnow = 0;
        public int threadcount = 0;
        public int Dtime = 15;

        private void bootupOk()
        {
            ButtonDisabled();
            //MessageBox.Show("Serial connection stabalize", "Start up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //run 1
            Form1.self.serialPort1.Write("0\r");
            Form1.self.serialPort1.Write("ccwx\r");
            Form1.self.serialPort1.Write("0.0\r");
            Task.Delay(200).Wait();
            //run 2
            Form1.self.serialPort1.Write("0\r");
            Form1.self.serialPort1.Write("ccx\r");
            Form1.self.serialPort1.Write("0.0\r");
            Task.Delay(200).Wait();
            //run 3
            Form1.self.serialPort1.Write("0\r");
            Form1.self.serialPort1.Write("ccwx\r");
            Form1.self.serialPort1.Write("0.0\r");
            Task.Delay(200).Wait();

            MessageBox.Show("Serial connection stabalized", "Start up Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ButtonEnabled();
        }
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
                s1.smartloop(sender, e);

            });
        }
        private void loopsequ(object sender, MouseEventArgs e)
        {
            Smartcontrol s1 = new Smartcontrol();
            s1.looporder(sender, e);
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
            //ButtonDisabled();          
            Form1.self.ReloadcodeCB.Checked = false;

            threading s1 = new threading();
            s1.threadright(sender, e);

            //Form1.self.startthreadingnow = 1;

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
        public int currentcycl = 1;
        public int Codeup = 0;
        public void running()
        {
            Task.Run(() =>
            {
                Codeup = 1;

                for (int i = 0; i < 6; i++)
                {
                    CodeRunning.Text = "Code Running";
                    Task.Delay(200).Wait();
                    CodeRunning.Text = "";
                    Task.Delay(200).Wait();

                    if (RGcodeRTB.Text != "")
                    {
                        i = 1;
                    }
                }


                Codeup = 0;
            });
        }
        public void RunRGcode_Click(object sender, EventArgs e) //run rgcode
        {
            Task.Factory.StartNew(() =>
                {
                    Form1.self.ButtonDisabled();

                    if (Codeup == 0)
                    {
                        running();
                    }

                    string[] lines = Form1.self.RGcodeRTB.Lines;
                    string notclear = Form1.self.RGcodeRTB.Text;

                    if (notclear.StartsWith("{") && notclear != "")
                    {
                        if (lines[1].Contains("Delay"))
                        {
                            Form1.self.startthreadingnow = 1;
                        }
                    }
                    //--- first check-----
                    int cycl = Convert.ToInt32(CycleCount.Text);
                    CurrentCycle.Text = Convert.ToString(currentcycl);

                    if (Form1.self.ReloadcodeCB.Checked == true)
                    {
                        Form1.self.RepeatBox.Text = Form1.self.RGcodeRTB.Text;
                    }
                    //--- run code second check----

                    RGcode s1 = new RGcode();
                    s1.Readcode(sender, e);

                    //--- third check for repeat----                    
                    if (Form1.self.ReloadcodeCB.Checked == true && currentcycl <= cycl - 1)
                    {
                        currentcycl++;
                        Form1.self.RGcodeRTB.Text = Form1.self.RepeatBox.Text;
                        RunRGcode_Click(sender, e);
                    }
                    else
                    {
                        currentcycl = 1;
                    }
                    Form1.self.ButtonEnabled();
                    //Form1.self.startthreadingnow = 0;

                });
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
        public void ClearEstop_Click(object sender, EventArgs e)
        {
            //if (ReloadcodeCB.Checked == false)
            //{
            Form1.self.startthreadingnow = 0;

            int getNum = Convert.ToInt32(CurrentCycle.Text);

            RepeatBox.Text = "";
            RGcodeRTB.Text = "";

            int getCycles = Convert.ToInt32(CycleCount.Text);

            CycleCount.Text = "0";
            
            if (Form1.self.serialPort1.IsOpen == true)
            {
                Form1.self.serialPort1.Write(string.Format("{0}\r", 1));
                Form1.self.serialPort1.Write("ccwx" + "\r");
                Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", 0)));
                Form1.self.serialPort1.Write("E-Stop" + "\r");
            }

            Form1.self.buttonEnabled.Text = "0";

            Task.Delay(100).Wait();

            CycleCount.Text = Convert.ToString(getCycles);
            CurrentCycle.Text = Convert.ToString(getNum);

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
                (sender as Button).Text = "Y Axis";
            }
            if (taperAxis == "Y Axis")
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
                Task.Delay(10).Wait();
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
        private void Axis_Click(object sender, EventArgs e)
        {
            string Drillax = Convert.ToString((sender as Button).Text);

            if (Drillax == "X")
            {
                (sender as Button).Text = "Y";
            }
            if (Drillax == "Y")
            {
                (sender as Button).Text = "Z";
            }
            if (Drillax == "Z")
            {
                (sender as Button).Text = "A";
            }
            if (Drillax == "A")
            {
                (sender as Button).Text = "X";
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

            if (Form1.self.ExportsClearCB.Checked == true)
            {
                Form1.self.RGcodeRTB.Text = "";
            }

            for (double i = 0; i < totalDrill; i = (i + peckdepth))
            {
                Form1.self.RGcodeRTB.Text += "{-----Cut-----}\r";
                Form1.self.RGcodeRTB.Text += string.Format("{0}", feed) + " -" + DrillAx + " " + (string.Format("{0:0.0000}", peckdepth * 2) + "\n");
                Form1.self.RGcodeRTB.Text += "{-----rapid out-----}\r";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", RapidDrill) + " +" + DrillAx + " " + (string.Format("{0:0.0000}", nextDrill) + "\n");
                Form1.self.RGcodeRTB.Text += "{------rapid in-----}\r";
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
            //----
            XnegMove.Enabled = true;
            XposMove.Enabled = true;
            YnegMove.Enabled = true;
            YposMove.Enabled = true;
            ZnegMove.Enabled = true;
            ZposMove.Enabled = true;
            AnegMove.Enabled = true;
            AposMove.Enabled = true;
            //----
            manualXn.Enabled = true;
            manualXp.Enabled = true;
            manualYn.Enabled = true;
            manualYp.Enabled = true;
            manualZn.Enabled = true;
            manualZp.Enabled = true;
            manualAn.Enabled = true;
            manualAp.Enabled = true;
            //----
            homeX.Enabled = true;
            homeY.Enabled = true;
            homeZ.Enabled = true;
            homeA.Enabled = true;
            //----
            LimitX.Enabled = true;
            LimitY.Enabled = true;
            LimitZ.Enabled = true;
            LimitA.Enabled = true;
            //----
            ToolSet.Enabled = true;
            RunRGcode.Enabled = true;



        }
        public void ButtonDisabled()
        {
            Cycle4.Enabled = false;
            //----
            XnegMove.Enabled = false;
            XposMove.Enabled = false;
            YnegMove.Enabled = false;
            YposMove.Enabled = false;
            ZnegMove.Enabled = false;
            ZposMove.Enabled = false;
            AnegMove.Enabled = false;
            AposMove.Enabled = false;
            //----
            manualXn.Enabled = false;
            manualXp.Enabled = false;
            manualYn.Enabled = false;
            manualYp.Enabled = false;
            manualZn.Enabled = false;
            manualZp.Enabled = false;
            manualAn.Enabled = false;
            manualAp.Enabled = false;
            //----
            homeX.Enabled = false;
            homeY.Enabled = false;
            homeZ.Enabled = false;
            homeA.Enabled = false;
            //----
            LimitX.Enabled = false;
            LimitY.Enabled = false;
            LimitZ.Enabled = false;
            LimitA.Enabled = false;
            //--
            ToolSet.Enabled = false;
            RunRGcode.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialsettings s1 = new serialsettings();
            s1.UpdateMessageBox(sender, e);
        }
        public double nep = 0;
        public void GoThread_TextChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (startthreadingnow == 1)
                {
                    Form1.self.RunRGcode_Click(sender, e);
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
                string rotate = "";

                if (ToolDir.Text == "+")
                {
                    rotate = "cw";
                }
                if (ToolDir.Text == "-")
                {
                    rotate = "ccw";
                }


                string axis = "";

                double convrt1 = 0;

                if (ToolSetAxis1.Text == "X")
                {
                    convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);
                    axis = "x";
                }
                if (ToolSetAxis1.Text == "Y")
                {
                    convrt1 = Convert.ToDouble(Form1.self.YConversion.Text);
                    axis = "y";
                }
                if (ToolSetAxis1.Text == "Z")
                {
                    convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);
                    axis = "z";
                }
                if (ToolSetAxis1.Text == "A")
                {
                    convrt1 = Convert.ToDouble(Form1.self.AConversion.Text);
                    axis = "a";
                }

                double thou = Convert.ToDouble(Form1.self.ReturnToStockDiam.Text);
                double convrt2 = thou / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion factor   ---    
                int convrt4 = Convert.ToInt32(convrt2 / convrt3);
                               

                if (IsRadius.Checked == true)
                {
                    convrt4 = convrt4 / 2;
                }        

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("10\r");
                    Form1.self.serialPort1.Write(rotate + axis + "\r");
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
                Form1.self.serialPort1.Write("1\r");
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

            double newvalue = MM / 25.4;

            InchConv.Text = string.Format("{0:0.0000}", newvalue);
        }

        private void MetricTPI_TextChanged(object sender, EventArgs e)
        {
            if (MetricTPI.Text == "")
            {
                MetricTPI.Text = "0";
            }

            double MTPI = Convert.ToDouble(MetricTPI.Text);

            if (MTPI > 0)
            {
                double conv = 25.4 / MTPI;
                TPI.Text = (string.Format("{0:0.000}", conv));
            }
        }

        private void TPI_TextChanged(object sender, EventArgs e)
        {
            if (TPI.Text == "")
            {
                TPI.Text = "0";
            }

            double TP = Convert.ToDouble(TPI.Text);

            if (TP > 0)
            {
                double conv = (1 / TP) * 0.614;
                ThreadDepth.Text = (string.Format("{0:0.0000}", conv));
            }
        }

        private void ThreadDepth_TextChanged(object sender, EventArgs e)
        {
            double tpi = Convert.ToDouble(TPI.Text);
            double ThrdDepth = Convert.ToDouble(ThreadDepth.Text);

            if (tpi > 0 && tpi < 10)
            {
                double D1 = ThrdDepth * 0.14;
                double D2 = ThrdDepth * 0.13;
                double D3 = ThrdDepth * 0.12;
                double D4 = ThrdDepth * 0.11;
                double D5 = ThrdDepth * 0.10;
                double D6 = ThrdDepth * 0.09;
                double D7 = ThrdDepth * 0.08;
                double D8 = ThrdDepth * 0.07;
                double D9 = ThrdDepth * 0.06;
                double D10 = ThrdDepth * 0.05;
                double D11 = ThrdDepth * 0.04;
                double D12 = ThrdDepth * 0.03;
                double D13 = ThrdDepth * 0.00;

                DOCRTB.Text = Convert.ToString(string.Format("{0:0.0000}", D1)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D2)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D3)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D4)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D5)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D6)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D7)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D8)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D9)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D10)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D11)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D12)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D13)) + "\r";

            }

            if (tpi > 9 && tpi < 30)
            {
                double D1 = ThrdDepth * 0.24;
                double D2 = ThrdDepth * 0.20;
                double D3 = ThrdDepth * 0.18;
                double D4 = ThrdDepth * 0.16;
                double D5 = ThrdDepth * 0.14;
                double D6 = ThrdDepth * 0.08;
                double D13 = ThrdDepth * 0.00;

                DOCRTB.Text = Convert.ToString(string.Format("{0:0.0000}", D1)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D2)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D3)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D4)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D5)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D6)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D13)) + "\r";

            }

            if (tpi > 29 && tpi < 60)
            {
                double D1 = ThrdDepth * 0.45;
                double D2 = ThrdDepth * 0.35;
                double D3 = ThrdDepth * 0.20;
                double D13 = ThrdDepth * 0.00;

                DOCRTB.Text = Convert.ToString(string.Format("{0:0.0000}", D1)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D2)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D3)) +
                       "\r" + Convert.ToString(string.Format("{0:0.0000}", D13)) + "\r";

            }

            if (tpi > 59)
            {
                double D1 = ThrdDepth;
                double D13 = ThrdDepth * 0.00;
                DOCRTB.Text = Convert.ToString(string.Format("{0:0.0000}", D1)) + "\r" + Convert.ToString(string.Format("{0:0.0000}", D13)) + "\r";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            threading s1 = new threading();
            s1.threadDirection(sender, e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string rotation = "";
            double manualIPM = Convert.ToDouble(Form1.self.manualIPM.Text);

            //capture up arrow key
            if (keyData == Keys.Up)
            {  
                return true;
            }            
            //capture down arrow key
            if (keyData == Keys.Down)
            {                
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {                
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {               
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

       
        private void manualXn_Click(object sender, EventArgs e)
        {

        }

        private void ToolDir_Click(object sender, EventArgs e)
        {
            string TDir = Convert.ToString((sender as Button).Text);

            if (TDir == "+")
            {
                (sender as Button).Text = "-";
            }
            if (TDir == "-")
            {
                (sender as Button).Text = "+";
            }
            
        }
    }
}









