
namespace Rummage_CNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.XConversion = new System.Windows.Forms.TextBox();
            this.StepMultiplyConvs = new System.Windows.Forms.TextBox();
            this.XnegOrder = new System.Windows.Forms.Button();
            this.XposOrder = new System.Windows.Forms.Button();
            this.YnegOrder = new System.Windows.Forms.Button();
            this.YposOrder = new System.Windows.Forms.Button();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.ExportCode = new System.Windows.Forms.Button();
            this.AposOrder = new System.Windows.Forms.Button();
            this.AnegOrder = new System.Windows.Forms.Button();
            this.ZposOrder = new System.Windows.Forms.Button();
            this.ZnegOrder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.BacklashA = new System.Windows.Forms.TextBox();
            this.BacklashZ = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.BacklashY = new System.Windows.Forms.TextBox();
            this.BacklashX = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.AConversion = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ZConversion = new System.Windows.Forms.TextBox();
            this.YConversion = new System.Windows.Forms.TextBox();
            this.DiagnosticsRTB = new System.Windows.Forms.RichTextBox();
            this.WriteBuffer = new System.Windows.Forms.TextBox();
            this.ReadBuffer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConnectSerial = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SerialReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Com = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.Button();
            this.HandShake = new System.Windows.Forms.Button();
            this.DataBit = new System.Windows.Forms.Button();
            this.StopBit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RepeatBox = new System.Windows.Forms.RichTextBox();
            this.ReloadcodeCB = new System.Windows.Forms.CheckBox();
            this.checkBoxTaperReturn = new System.Windows.Forms.CheckBox();
            this.ExportsClearCB = new System.Windows.Forms.CheckBox();
            this.IsRadius = new System.Windows.Forms.CheckBox();
            this.InchConv = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.MetricConv = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ReturnToStockDiam = new System.Windows.Forms.TextBox();
            this.CancelLimit = new System.Windows.Forms.Button();
            this.LimitA = new System.Windows.Forms.Button();
            this.LimitZ = new System.Windows.Forms.Button();
            this.LimitY = new System.Windows.Forms.Button();
            this.LimitX = new System.Windows.Forms.Button();
            this.ToolSet = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.DrillRapid = new System.Windows.Forms.Button();
            this.TPI = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.MetricTPI = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.GoThread = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.DrillAxis = new System.Windows.Forms.Button();
            this.AnegTB = new System.Windows.Forms.TextBox();
            this.AposTB = new System.Windows.Forms.TextBox();
            this.ZposTB = new System.Windows.Forms.TextBox();
            this.ZnegTB = new System.Windows.Forms.TextBox();
            this.AnegIPM = new System.Windows.Forms.Button();
            this.AposIPM = new System.Windows.Forms.Button();
            this.AnegMove = new System.Windows.Forms.Button();
            this.AposMove = new System.Windows.Forms.Button();
            this.ZposIPM = new System.Windows.Forms.Button();
            this.ZnegIPM = new System.Windows.Forms.Button();
            this.ZposMove = new System.Windows.Forms.Button();
            this.ZnegMove = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.manualAn = new System.Windows.Forms.Button();
            this.manualAp = new System.Windows.Forms.Button();
            this.manualZn = new System.Windows.Forms.Button();
            this.manualZp = new System.Windows.Forms.Button();
            this.homeA = new System.Windows.Forms.Button();
            this.MetricA = new System.Windows.Forms.TextBox();
            this.incha = new System.Windows.Forms.TextBox();
            this.DoubleA = new System.Windows.Forms.Button();
            this.HalfA = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.zeroA = new System.Windows.Forms.Button();
            this.homeZ = new System.Windows.Forms.Button();
            this.MetricZ = new System.Windows.Forms.TextBox();
            this.inchz = new System.Windows.Forms.TextBox();
            this.DoubleZ = new System.Windows.Forms.Button();
            this.HalfZ = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.zeroZ = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.CalcRadius = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.CalcPass = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.CalcAnswer = new System.Windows.Forms.TextBox();
            this.CalculatorCalc = new System.Windows.Forms.Button();
            this.CalcDOC = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.CalcTagetDiam = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.CalcDiam = new System.Windows.Forms.TextBox();
            this.Calclabel = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.Drill = new System.Windows.Forms.Button();
            this.peckDepth = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.drillFeed = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.drillDepth = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.DegreeIPM = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.IPMtaper = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.DOCtaper = new System.Windows.Forms.TextBox();
            this.RPM = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.CycleRadius = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.DegreeInc = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.CircleRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.manualIPM = new System.Windows.Forms.TextBox();
            this.saveGcode = new System.Windows.Forms.Button();
            this.manualXn = new System.Windows.Forms.Button();
            this.manualXp = new System.Windows.Forms.Button();
            this.manualYp = new System.Windows.Forms.Button();
            this.manualYn = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.homeY = new System.Windows.Forms.Button();
            this.homeX = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.ToRemove = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.Slope = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.CycleTaper = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.LongAxis = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.TaperLength = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.Ratio = new System.Windows.Forms.TextBox();
            this.buttonEnabled = new System.Windows.Forms.Label();
            this.LoadRGCode = new System.Windows.Forms.Button();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.RGcodeRTB = new System.Windows.Forms.RichTextBox();
            this.CurrentCycle = new System.Windows.Forms.TextBox();
            this.ThreadRPM = new System.Windows.Forms.TextBox();
            this.ThreadPI = new System.Windows.Forms.TextBox();
            this.CycleCount = new System.Windows.Forms.TextBox();
            this.YnegTB = new System.Windows.Forms.TextBox();
            this.YposTB = new System.Windows.Forms.TextBox();
            this.XposTB = new System.Windows.Forms.TextBox();
            this.XnegTB = new System.Windows.Forms.TextBox();
            this.MetricY = new System.Windows.Forms.TextBox();
            this.MetricX = new System.Windows.Forms.TextBox();
            this.inchx = new System.Windows.Forms.TextBox();
            this.inchy = new System.Windows.Forms.TextBox();
            this.RGCodeEStop = new System.Windows.Forms.Button();
            this.RunRGcode = new System.Windows.Forms.Button();
            this.DoubleY = new System.Windows.Forms.Button();
            this.DoubleX = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ThreadType = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ThreadCycle = new System.Windows.Forms.Button();
            this.Cycle4 = new System.Windows.Forms.Button();
            this.YnegIPM = new System.Windows.Forms.Button();
            this.YposIPM = new System.Windows.Forms.Button();
            this.YnegMove = new System.Windows.Forms.Button();
            this.YposMove = new System.Windows.Forms.Button();
            this.XposIPM = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.XnegIPM = new System.Windows.Forms.Button();
            this.XposMove = new System.Windows.Forms.Button();
            this.XnegMove = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.HalfY = new System.Windows.Forms.Button();
            this.HalfX = new System.Windows.Forms.Button();
            this.zeroX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zeroY = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label67 = new System.Windows.Forms.Label();
            this.CodeRunning = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ParityReplace = ((byte)(0));
            this.serialPort1.PortName = "COM11";
            this.serialPort1.ReadBufferSize = 2048;
            this.serialPort1.WriteBufferSize = 4096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // XConversion
            // 
            this.XConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XConversion.Location = new System.Drawing.Point(115, 380);
            this.XConversion.Name = "XConversion";
            this.XConversion.Size = new System.Drawing.Size(133, 26);
            this.XConversion.TabIndex = 0;
            this.XConversion.Text = "0.00004";
            this.XConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.XConversion, "Movement per 360 degree rotation\r\non encoder / PPR of encoder\r\n\r\nEx. 0.080\" / 200" +
        "0 PPR = 0.00004 Conv");
            this.XConversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // StepMultiplyConvs
            // 
            this.StepMultiplyConvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepMultiplyConvs.Location = new System.Drawing.Point(115, 540);
            this.StepMultiplyConvs.Name = "StepMultiplyConvs";
            this.StepMultiplyConvs.Size = new System.Drawing.Size(133, 26);
            this.StepMultiplyConvs.TabIndex = 34;
            this.StepMultiplyConvs.Text = "2.5";
            this.StepMultiplyConvs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.StepMultiplyConvs, "encoder pulses per rev / stepper motor pulses per rev\r\n\r\nEx. 2000 ppr encoder / 8" +
        "00 step motor = 2.5 conv");
            this.StepMultiplyConvs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // XnegOrder
            // 
            this.XnegOrder.BackColor = System.Drawing.Color.White;
            this.XnegOrder.FlatAppearance.BorderSize = 0;
            this.XnegOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XnegOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XnegOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XnegOrder.ForeColor = System.Drawing.Color.Black;
            this.XnegOrder.Location = new System.Drawing.Point(291, 256);
            this.XnegOrder.Name = "XnegOrder";
            this.XnegOrder.Size = new System.Drawing.Size(36, 31);
            this.XnegOrder.TabIndex = 29;
            this.XnegOrder.Text = "1";
            this.toolTip1.SetToolTip(this.XnegOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.");
            this.XnegOrder.UseVisualStyleBackColor = false;
            this.XnegOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // XposOrder
            // 
            this.XposOrder.BackColor = System.Drawing.Color.White;
            this.XposOrder.FlatAppearance.BorderSize = 0;
            this.XposOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XposOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XposOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XposOrder.ForeColor = System.Drawing.Color.Black;
            this.XposOrder.Location = new System.Drawing.Point(291, 292);
            this.XposOrder.Name = "XposOrder";
            this.XposOrder.Size = new System.Drawing.Size(36, 31);
            this.XposOrder.TabIndex = 33;
            this.XposOrder.Text = "3";
            this.toolTip1.SetToolTip(this.XposOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.XposOrder.UseVisualStyleBackColor = false;
            this.XposOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // YnegOrder
            // 
            this.YnegOrder.BackColor = System.Drawing.Color.White;
            this.YnegOrder.FlatAppearance.BorderSize = 0;
            this.YnegOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YnegOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YnegOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YnegOrder.ForeColor = System.Drawing.Color.Black;
            this.YnegOrder.Location = new System.Drawing.Point(291, 345);
            this.YnegOrder.Name = "YnegOrder";
            this.YnegOrder.Size = new System.Drawing.Size(36, 31);
            this.YnegOrder.TabIndex = 37;
            this.YnegOrder.Text = "0";
            this.toolTip1.SetToolTip(this.YnegOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.YnegOrder.UseVisualStyleBackColor = false;
            this.YnegOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // YposOrder
            // 
            this.YposOrder.BackColor = System.Drawing.Color.White;
            this.YposOrder.FlatAppearance.BorderSize = 0;
            this.YposOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YposOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YposOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YposOrder.ForeColor = System.Drawing.Color.Black;
            this.YposOrder.Location = new System.Drawing.Point(291, 382);
            this.YposOrder.Name = "YposOrder";
            this.YposOrder.Size = new System.Drawing.Size(36, 31);
            this.YposOrder.TabIndex = 41;
            this.YposOrder.Text = "0";
            this.toolTip1.SetToolTip(this.YposOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.YposOrder.UseVisualStyleBackColor = false;
            this.YposOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // SaveSettings
            // 
            this.SaveSettings.BackColor = System.Drawing.Color.Yellow;
            this.SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettings.ForeColor = System.Drawing.Color.Black;
            this.SaveSettings.Location = new System.Drawing.Point(115, 820);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(133, 52);
            this.SaveSettings.TabIndex = 0;
            this.SaveSettings.Text = "Save Settings";
            this.toolTip1.SetToolTip(this.SaveSettings, "Save file as \"Settings.cfg\" in the default directory for it to auto load");
            this.SaveSettings.UseVisualStyleBackColor = false;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // ExportCode
            // 
            this.ExportCode.BackColor = System.Drawing.Color.Yellow;
            this.ExportCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExportCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportCode.ForeColor = System.Drawing.Color.Black;
            this.ExportCode.Location = new System.Drawing.Point(1288, 581);
            this.ExportCode.Name = "ExportCode";
            this.ExportCode.Size = new System.Drawing.Size(121, 31);
            this.ExportCode.TabIndex = 154;
            this.ExportCode.Text = "Export";
            this.toolTip1.SetToolTip(this.ExportCode, "Export to Cycles");
            this.ExportCode.UseVisualStyleBackColor = false;
            this.ExportCode.Click += new System.EventHandler(this.ExportCode_Click);
            // 
            // AposOrder
            // 
            this.AposOrder.BackColor = System.Drawing.Color.White;
            this.AposOrder.FlatAppearance.BorderSize = 0;
            this.AposOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AposOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AposOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AposOrder.ForeColor = System.Drawing.Color.Black;
            this.AposOrder.Location = new System.Drawing.Point(291, 560);
            this.AposOrder.Name = "AposOrder";
            this.AposOrder.Size = new System.Drawing.Size(36, 31);
            this.AposOrder.TabIndex = 57;
            this.AposOrder.Text = "0";
            this.toolTip1.SetToolTip(this.AposOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.AposOrder.UseVisualStyleBackColor = false;
            this.AposOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // AnegOrder
            // 
            this.AnegOrder.BackColor = System.Drawing.Color.White;
            this.AnegOrder.FlatAppearance.BorderSize = 0;
            this.AnegOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AnegOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnegOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnegOrder.ForeColor = System.Drawing.Color.Black;
            this.AnegOrder.Location = new System.Drawing.Point(291, 523);
            this.AnegOrder.Name = "AnegOrder";
            this.AnegOrder.Size = new System.Drawing.Size(36, 31);
            this.AnegOrder.TabIndex = 53;
            this.AnegOrder.Text = "0";
            this.toolTip1.SetToolTip(this.AnegOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.AnegOrder.UseVisualStyleBackColor = false;
            this.AnegOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // ZposOrder
            // 
            this.ZposOrder.BackColor = System.Drawing.Color.White;
            this.ZposOrder.FlatAppearance.BorderSize = 0;
            this.ZposOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZposOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZposOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZposOrder.ForeColor = System.Drawing.Color.Black;
            this.ZposOrder.Location = new System.Drawing.Point(291, 470);
            this.ZposOrder.Name = "ZposOrder";
            this.ZposOrder.Size = new System.Drawing.Size(36, 31);
            this.ZposOrder.TabIndex = 49;
            this.ZposOrder.Text = "2";
            this.toolTip1.SetToolTip(this.ZposOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.ZposOrder.UseVisualStyleBackColor = false;
            this.ZposOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // ZnegOrder
            // 
            this.ZnegOrder.BackColor = System.Drawing.Color.White;
            this.ZnegOrder.FlatAppearance.BorderSize = 0;
            this.ZnegOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZnegOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZnegOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZnegOrder.ForeColor = System.Drawing.Color.Black;
            this.ZnegOrder.Location = new System.Drawing.Point(291, 434);
            this.ZnegOrder.Name = "ZnegOrder";
            this.ZnegOrder.Size = new System.Drawing.Size(36, 31);
            this.ZnegOrder.TabIndex = 45;
            this.ZnegOrder.Text = "4";
            this.toolTip1.SetToolTip(this.ZnegOrder, "Every sequnce button should have a unique number\r\n\r\nDO NOT have two 2\'s or three " +
        "1\'s this will most likely\r\ncause a software crash or worse!\r\n\r\n0 is skip.\r\n");
            this.ZnegOrder.UseVisualStyleBackColor = false;
            this.ZnegOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopsequ);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.label60);
            this.tabPage2.Controls.Add(this.label59);
            this.tabPage2.Controls.Add(this.label58);
            this.tabPage2.Controls.Add(this.label57);
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.BacklashA);
            this.tabPage2.Controls.Add(this.BacklashZ);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.BacklashY);
            this.tabPage2.Controls.Add(this.BacklashX);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.AConversion);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.StepMultiplyConvs);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.ZConversion);
            this.tabPage2.Controls.Add(this.YConversion);
            this.tabPage2.Controls.Add(this.XConversion);
            this.tabPage2.Controls.Add(this.DiagnosticsRTB);
            this.tabPage2.Controls.Add(this.WriteBuffer);
            this.tabPage2.Controls.Add(this.ReadBuffer);
            this.tabPage2.Controls.Add(this.SaveSettings);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ConnectSerial);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.SerialReset);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Baud);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Com);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Parity);
            this.tabPage2.Controls.Add(this.HandShake);
            this.tabPage2.Controls.Add(this.DataBit);
            this.tabPage2.Controls.Add(this.StopBit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1897, 974);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Lime;
            this.label60.Location = new System.Drawing.Point(93, 748);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(15, 13);
            this.label60.TabIndex = 147;
            this.label60.Text = "A";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Lime;
            this.label59.Location = new System.Drawing.Point(93, 708);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(15, 13);
            this.label59.TabIndex = 146;
            this.label59.Text = "Z";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Lime;
            this.label58.Location = new System.Drawing.Point(93, 668);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(15, 13);
            this.label58.TabIndex = 145;
            this.label58.Text = "Y";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.Lime;
            this.label57.Location = new System.Drawing.Point(93, 628);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(15, 13);
            this.label57.TabIndex = 144;
            this.label57.Text = "X";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.Yellow;
            this.richTextBox4.Location = new System.Drawing.Point(576, 22);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(248, 457);
            this.richTextBox4.TabIndex = 143;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // BacklashA
            // 
            this.BacklashA.BackColor = System.Drawing.Color.White;
            this.BacklashA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklashA.ForeColor = System.Drawing.Color.Black;
            this.BacklashA.Location = new System.Drawing.Point(115, 740);
            this.BacklashA.MaxLength = 6;
            this.BacklashA.Name = "BacklashA";
            this.BacklashA.Size = new System.Drawing.Size(133, 26);
            this.BacklashA.TabIndex = 142;
            this.BacklashA.Text = "0.002";
            this.BacklashA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BacklashZ
            // 
            this.BacklashZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklashZ.ForeColor = System.Drawing.Color.Black;
            this.BacklashZ.Location = new System.Drawing.Point(115, 700);
            this.BacklashZ.MaxLength = 6;
            this.BacklashZ.Name = "BacklashZ";
            this.BacklashZ.Size = new System.Drawing.Size(133, 26);
            this.BacklashZ.TabIndex = 141;
            this.BacklashZ.Text = "0.002";
            this.BacklashZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.Lime;
            this.checkBox5.Location = new System.Drawing.Point(119, 780);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 17);
            this.checkBox5.TabIndex = 140;
            this.checkBox5.Text = "Use Backlash Adj,";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // BacklashY
            // 
            this.BacklashY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklashY.ForeColor = System.Drawing.Color.Black;
            this.BacklashY.Location = new System.Drawing.Point(115, 660);
            this.BacklashY.MaxLength = 6;
            this.BacklashY.Name = "BacklashY";
            this.BacklashY.Size = new System.Drawing.Size(133, 26);
            this.BacklashY.TabIndex = 139;
            this.BacklashY.Text = "0.002";
            this.BacklashY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BacklashX
            // 
            this.BacklashX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacklashX.ForeColor = System.Drawing.Color.Black;
            this.BacklashX.Location = new System.Drawing.Point(115, 620);
            this.BacklashX.MaxLength = 6;
            this.BacklashX.Name = "BacklashX";
            this.BacklashX.Size = new System.Drawing.Size(133, 26);
            this.BacklashX.TabIndex = 138;
            this.BacklashX.Text = "0.015";
            this.BacklashX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Lime;
            this.label41.Location = new System.Drawing.Point(123, 580);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(118, 20);
            this.label41.TabIndex = 137;
            this.label41.Text = "Backlash Adj.";
            // 
            // AConversion
            // 
            this.AConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AConversion.Location = new System.Drawing.Point(115, 500);
            this.AConversion.Name = "AConversion";
            this.AConversion.Size = new System.Drawing.Size(133, 26);
            this.AConversion.TabIndex = 37;
            this.AConversion.Text = "0.00004";
            this.AConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Lime;
            this.label53.Location = new System.Drawing.Point(30, 506);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(79, 13);
            this.label53.TabIndex = 38;
            this.label53.Text = "A Axis Conv.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Lime;
            this.label25.Location = new System.Drawing.Point(1648, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 20);
            this.label25.TabIndex = 36;
            this.label25.Text = "Diagnostics";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(40, 546);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "steps conv";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(266, 22);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(280, 850);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // ZConversion
            // 
            this.ZConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZConversion.Location = new System.Drawing.Point(115, 460);
            this.ZConversion.Name = "ZConversion";
            this.ZConversion.Size = new System.Drawing.Size(133, 26);
            this.ZConversion.TabIndex = 0;
            this.ZConversion.Text = "0.00004";
            this.ZConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ZConversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // YConversion
            // 
            this.YConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YConversion.Location = new System.Drawing.Point(115, 420);
            this.YConversion.Name = "YConversion";
            this.YConversion.Size = new System.Drawing.Size(133, 26);
            this.YConversion.TabIndex = 0;
            this.YConversion.Text = "0.00004";
            this.YConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YConversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // DiagnosticsRTB
            // 
            this.DiagnosticsRTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DiagnosticsRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticsRTB.Location = new System.Drawing.Point(1495, 61);
            this.DiagnosticsRTB.Name = "DiagnosticsRTB";
            this.DiagnosticsRTB.ReadOnly = true;
            this.DiagnosticsRTB.Size = new System.Drawing.Size(394, 811);
            this.DiagnosticsRTB.TabIndex = 0;
            this.DiagnosticsRTB.Text = "";
            // 
            // WriteBuffer
            // 
            this.WriteBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteBuffer.ForeColor = System.Drawing.Color.Green;
            this.WriteBuffer.Location = new System.Drawing.Point(115, 140);
            this.WriteBuffer.Name = "WriteBuffer";
            this.WriteBuffer.Size = new System.Drawing.Size(133, 26);
            this.WriteBuffer.TabIndex = 0;
            this.WriteBuffer.Text = "2048";
            this.WriteBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WriteBuffer.TextChanged += new System.EventHandler(this.WriteBuffer_TextChanged);
            // 
            // ReadBuffer
            // 
            this.ReadBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBuffer.ForeColor = System.Drawing.Color.Green;
            this.ReadBuffer.Location = new System.Drawing.Point(115, 180);
            this.ReadBuffer.Name = "ReadBuffer";
            this.ReadBuffer.Size = new System.Drawing.Size(133, 26);
            this.ReadBuffer.TabIndex = 0;
            this.ReadBuffer.Text = "4096";
            this.ReadBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReadBuffer.TextChanged += new System.EventHandler(this.ReadBuffer_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(93, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Set in Inch Decimal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(31, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Z Axis Conv.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(30, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Y Axis Conv.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(30, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "X Axis Conv.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(9, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Handshake";
            // 
            // ConnectSerial
            // 
            this.ConnectSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectSerial.ForeColor = System.Drawing.Color.OrangeRed;
            this.ConnectSerial.Location = new System.Drawing.Point(1495, 9);
            this.ConnectSerial.Name = "ConnectSerial";
            this.ConnectSerial.Size = new System.Drawing.Size(114, 33);
            this.ConnectSerial.TabIndex = 0;
            this.ConnectSerial.Text = "Connect";
            this.ConnectSerial.UseVisualStyleBackColor = true;
            this.ConnectSerial.Click += new System.EventHandler(this.ConnectSerial_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(25, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Data Bits";
            // 
            // SerialReset
            // 
            this.SerialReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialReset.ForeColor = System.Drawing.Color.OrangeRed;
            this.SerialReset.Location = new System.Drawing.Point(1775, 9);
            this.SerialReset.Name = "SerialReset";
            this.SerialReset.Size = new System.Drawing.Size(114, 33);
            this.SerialReset.TabIndex = 0;
            this.SerialReset.Text = "Disconnect";
            this.SerialReset.UseVisualStyleBackColor = true;
            this.SerialReset.Click += new System.EventHandler(this.SerialReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(26, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Stop Bits";
            // 
            // Baud
            // 
            this.Baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baud.ForeColor = System.Drawing.Color.Green;
            this.Baud.Location = new System.Drawing.Point(115, 20);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(133, 26);
            this.Baud.TabIndex = 0;
            this.Baud.Text = "9600";
            this.Baud.UseVisualStyleBackColor = true;
            this.Baud.Click += new System.EventHandler(this.Baud_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(18, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Read Buff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(58, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(21, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Write buff";
            // 
            // Com
            // 
            this.Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com.ForeColor = System.Drawing.Color.Green;
            this.Com.Location = new System.Drawing.Point(115, 60);
            this.Com.Name = "Com";
            this.Com.Size = new System.Drawing.Size(133, 26);
            this.Com.TabIndex = 0;
            this.Com.Text = "COM7";
            this.Com.UseVisualStyleBackColor = true;
            this.Com.Click += new System.EventHandler(this.Com_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(55, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parity";
            // 
            // Parity
            // 
            this.Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parity.ForeColor = System.Drawing.Color.Green;
            this.Parity.Location = new System.Drawing.Point(115, 100);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(133, 26);
            this.Parity.TabIndex = 0;
            this.Parity.Text = "Space";
            this.Parity.UseVisualStyleBackColor = true;
            this.Parity.Click += new System.EventHandler(this.Parity_Click);
            // 
            // HandShake
            // 
            this.HandShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandShake.ForeColor = System.Drawing.Color.Green;
            this.HandShake.Location = new System.Drawing.Point(115, 300);
            this.HandShake.Name = "HandShake";
            this.HandShake.Size = new System.Drawing.Size(133, 26);
            this.HandShake.TabIndex = 0;
            this.HandShake.Text = "None";
            this.HandShake.UseVisualStyleBackColor = true;
            this.HandShake.Click += new System.EventHandler(this.HandShake_Click);
            // 
            // DataBit
            // 
            this.DataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBit.ForeColor = System.Drawing.Color.Green;
            this.DataBit.Location = new System.Drawing.Point(115, 260);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(133, 26);
            this.DataBit.TabIndex = 0;
            this.DataBit.Text = "7";
            this.DataBit.UseVisualStyleBackColor = true;
            this.DataBit.Click += new System.EventHandler(this.DataBit_Click);
            // 
            // StopBit
            // 
            this.StopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBit.ForeColor = System.Drawing.Color.Green;
            this.StopBit.Location = new System.Drawing.Point(115, 220);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(133, 26);
            this.StopBit.TabIndex = 0;
            this.StopBit.Text = "One";
            this.StopBit.UseVisualStyleBackColor = true;
            this.StopBit.Click += new System.EventHandler(this.StopBit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage1.Controls.Add(this.CodeRunning);
            this.tabPage1.Controls.Add(this.label67);
            this.tabPage1.Controls.Add(this.RepeatBox);
            this.tabPage1.Controls.Add(this.ReloadcodeCB);
            this.tabPage1.Controls.Add(this.checkBoxTaperReturn);
            this.tabPage1.Controls.Add(this.ExportsClearCB);
            this.tabPage1.Controls.Add(this.IsRadius);
            this.tabPage1.Controls.Add(this.InchConv);
            this.tabPage1.Controls.Add(this.label66);
            this.tabPage1.Controls.Add(this.MetricConv);
            this.tabPage1.Controls.Add(this.label56);
            this.tabPage1.Controls.Add(this.label65);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.ReturnToStockDiam);
            this.tabPage1.Controls.Add(this.CancelLimit);
            this.tabPage1.Controls.Add(this.LimitA);
            this.tabPage1.Controls.Add(this.LimitZ);
            this.tabPage1.Controls.Add(this.LimitY);
            this.tabPage1.Controls.Add(this.LimitX);
            this.tabPage1.Controls.Add(this.ToolSet);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.DrillRapid);
            this.tabPage1.Controls.Add(this.TPI);
            this.tabPage1.Controls.Add(this.label62);
            this.tabPage1.Controls.Add(this.MetricTPI);
            this.tabPage1.Controls.Add(this.label63);
            this.tabPage1.Controls.Add(this.label64);
            this.tabPage1.Controls.Add(this.GoThread);
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.DrillAxis);
            this.tabPage1.Controls.Add(this.AnegTB);
            this.tabPage1.Controls.Add(this.AposTB);
            this.tabPage1.Controls.Add(this.ZposTB);
            this.tabPage1.Controls.Add(this.ZnegTB);
            this.tabPage1.Controls.Add(this.AposOrder);
            this.tabPage1.Controls.Add(this.AnegOrder);
            this.tabPage1.Controls.Add(this.ZposOrder);
            this.tabPage1.Controls.Add(this.ZnegOrder);
            this.tabPage1.Controls.Add(this.AnegIPM);
            this.tabPage1.Controls.Add(this.AposIPM);
            this.tabPage1.Controls.Add(this.AnegMove);
            this.tabPage1.Controls.Add(this.AposMove);
            this.tabPage1.Controls.Add(this.ZposIPM);
            this.tabPage1.Controls.Add(this.ZnegIPM);
            this.tabPage1.Controls.Add(this.ZposMove);
            this.tabPage1.Controls.Add(this.ZnegMove);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.manualAn);
            this.tabPage1.Controls.Add(this.manualAp);
            this.tabPage1.Controls.Add(this.manualZn);
            this.tabPage1.Controls.Add(this.manualZp);
            this.tabPage1.Controls.Add(this.homeA);
            this.tabPage1.Controls.Add(this.MetricA);
            this.tabPage1.Controls.Add(this.incha);
            this.tabPage1.Controls.Add(this.DoubleA);
            this.tabPage1.Controls.Add(this.HalfA);
            this.tabPage1.Controls.Add(this.label52);
            this.tabPage1.Controls.Add(this.zeroA);
            this.tabPage1.Controls.Add(this.homeZ);
            this.tabPage1.Controls.Add(this.MetricZ);
            this.tabPage1.Controls.Add(this.inchz);
            this.tabPage1.Controls.Add(this.DoubleZ);
            this.tabPage1.Controls.Add(this.HalfZ);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.zeroZ);
            this.tabPage1.Controls.Add(this.label51);
            this.tabPage1.Controls.Add(this.CalcRadius);
            this.tabPage1.Controls.Add(this.label50);
            this.tabPage1.Controls.Add(this.CalcPass);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.CalcAnswer);
            this.tabPage1.Controls.Add(this.CalculatorCalc);
            this.tabPage1.Controls.Add(this.CalcDOC);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.CalcTagetDiam);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.CalcDiam);
            this.tabPage1.Controls.Add(this.Calclabel);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.Drill);
            this.tabPage1.Controls.Add(this.peckDepth);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.drillFeed);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.drillDepth);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.DegreeIPM);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.IPMtaper);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.DOCtaper);
            this.tabPage1.Controls.Add(this.RPM);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.ExportCode);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.CycleRadius);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.DegreeInc);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.CircleRadius);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.manualIPM);
            this.tabPage1.Controls.Add(this.saveGcode);
            this.tabPage1.Controls.Add(this.manualXn);
            this.tabPage1.Controls.Add(this.manualXp);
            this.tabPage1.Controls.Add(this.manualYp);
            this.tabPage1.Controls.Add(this.manualYn);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.homeY);
            this.tabPage1.Controls.Add(this.homeX);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.ToRemove);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.Slope);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.CycleTaper);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.LongAxis);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.TaperLength);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.Ratio);
            this.tabPage1.Controls.Add(this.buttonEnabled);
            this.tabPage1.Controls.Add(this.LoadRGCode);
            this.tabPage1.Controls.Add(this.textBox21);
            this.tabPage1.Controls.Add(this.RGcodeRTB);
            this.tabPage1.Controls.Add(this.CurrentCycle);
            this.tabPage1.Controls.Add(this.ThreadRPM);
            this.tabPage1.Controls.Add(this.ThreadPI);
            this.tabPage1.Controls.Add(this.CycleCount);
            this.tabPage1.Controls.Add(this.YnegTB);
            this.tabPage1.Controls.Add(this.YposTB);
            this.tabPage1.Controls.Add(this.XposTB);
            this.tabPage1.Controls.Add(this.XnegTB);
            this.tabPage1.Controls.Add(this.MetricY);
            this.tabPage1.Controls.Add(this.MetricX);
            this.tabPage1.Controls.Add(this.inchx);
            this.tabPage1.Controls.Add(this.inchy);
            this.tabPage1.Controls.Add(this.RGCodeEStop);
            this.tabPage1.Controls.Add(this.RunRGcode);
            this.tabPage1.Controls.Add(this.DoubleY);
            this.tabPage1.Controls.Add(this.DoubleX);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.ThreadType);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.YposOrder);
            this.tabPage1.Controls.Add(this.YnegOrder);
            this.tabPage1.Controls.Add(this.XposOrder);
            this.tabPage1.Controls.Add(this.XnegOrder);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.ThreadCycle);
            this.tabPage1.Controls.Add(this.Cycle4);
            this.tabPage1.Controls.Add(this.YnegIPM);
            this.tabPage1.Controls.Add(this.YposIPM);
            this.tabPage1.Controls.Add(this.YnegMove);
            this.tabPage1.Controls.Add(this.YposMove);
            this.tabPage1.Controls.Add(this.XposIPM);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.XnegIPM);
            this.tabPage1.Controls.Add(this.XposMove);
            this.tabPage1.Controls.Add(this.XnegMove);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.HalfY);
            this.tabPage1.Controls.Add(this.HalfX);
            this.tabPage1.Controls.Add(this.zeroX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.zeroY);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1897, 974);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DRO";
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // RepeatBox
            // 
            this.RepeatBox.Location = new System.Drawing.Point(1296, 855);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(100, 96);
            this.RepeatBox.TabIndex = 159;
            this.RepeatBox.Text = "";
            this.RepeatBox.Visible = false;
            // 
            // ReloadcodeCB
            // 
            this.ReloadcodeCB.AutoSize = true;
            this.ReloadcodeCB.Checked = true;
            this.ReloadcodeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReloadcodeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadcodeCB.ForeColor = System.Drawing.Color.Lime;
            this.ReloadcodeCB.Location = new System.Drawing.Point(1290, 702);
            this.ReloadcodeCB.Name = "ReloadcodeCB";
            this.ReloadcodeCB.Size = new System.Drawing.Size(106, 20);
            this.ReloadcodeCB.TabIndex = 158;
            this.ReloadcodeCB.Text = "Cycle Code";
            this.ReloadcodeCB.UseVisualStyleBackColor = true;
            // 
            // checkBoxTaperReturn
            // 
            this.checkBoxTaperReturn.AutoSize = true;
            this.checkBoxTaperReturn.Checked = true;
            this.checkBoxTaperReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaperReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTaperReturn.ForeColor = System.Drawing.Color.Lime;
            this.checkBoxTaperReturn.Location = new System.Drawing.Point(791, 760);
            this.checkBoxTaperReturn.Name = "checkBoxTaperReturn";
            this.checkBoxTaperReturn.Size = new System.Drawing.Size(105, 20);
            this.checkBoxTaperReturn.TabIndex = 157;
            this.checkBoxTaperReturn.Text = "Taper Return";
            this.checkBoxTaperReturn.UseVisualStyleBackColor = true;
            // 
            // ExportsClearCB
            // 
            this.ExportsClearCB.AutoSize = true;
            this.ExportsClearCB.Checked = true;
            this.ExportsClearCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportsClearCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportsClearCB.ForeColor = System.Drawing.Color.Lime;
            this.ExportsClearCB.Location = new System.Drawing.Point(1290, 645);
            this.ExportsClearCB.Name = "ExportsClearCB";
            this.ExportsClearCB.Size = new System.Drawing.Size(119, 20);
            this.ExportsClearCB.TabIndex = 156;
            this.ExportsClearCB.Text = "Exports Clear";
            this.ExportsClearCB.UseVisualStyleBackColor = true;
            // 
            // IsRadius
            // 
            this.IsRadius.AutoSize = true;
            this.IsRadius.Checked = true;
            this.IsRadius.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsRadius.ForeColor = System.Drawing.Color.Lime;
            this.IsRadius.Location = new System.Drawing.Point(556, 380);
            this.IsRadius.Name = "IsRadius";
            this.IsRadius.Size = new System.Drawing.Size(104, 24);
            this.IsRadius.TabIndex = 95;
            this.IsRadius.Text = "Is Radius";
            this.IsRadius.UseVisualStyleBackColor = true;
            // 
            // InchConv
            // 
            this.InchConv.BackColor = System.Drawing.Color.White;
            this.InchConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchConv.Location = new System.Drawing.Point(955, 864);
            this.InchConv.MaxLength = 10;
            this.InchConv.Name = "InchConv";
            this.InchConv.ReadOnly = true;
            this.InchConv.Size = new System.Drawing.Size(114, 31);
            this.InchConv.TabIndex = 0;
            this.InchConv.Text = "0.0";
            this.InchConv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.Lime;
            this.label66.Location = new System.Drawing.Point(996, 844);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(34, 15);
            this.label66.TabIndex = 0;
            this.label66.Text = "Inch";
            // 
            // MetricConv
            // 
            this.MetricConv.BackColor = System.Drawing.Color.White;
            this.MetricConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricConv.Location = new System.Drawing.Point(955, 808);
            this.MetricConv.MaxLength = 10;
            this.MetricConv.Name = "MetricConv";
            this.MetricConv.Size = new System.Drawing.Size(114, 31);
            this.MetricConv.TabIndex = 88;
            this.MetricConv.Text = "0.0";
            this.MetricConv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MetricConv.TextChanged += new System.EventHandler(this.MetricConv_TextChanged);
            this.MetricConv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Lime;
            this.label56.Location = new System.Drawing.Point(974, 788);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(75, 15);
            this.label56.TabIndex = 0;
            this.label56.Text = "Metric MM";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Lime;
            this.label65.Location = new System.Drawing.Point(952, 760);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(119, 20);
            this.label65.TabIndex = 0;
            this.label65.Text = "Metric to Inch";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Lime;
            this.label24.Location = new System.Drawing.Point(555, 308);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 32);
            this.label24.TabIndex = 0;
            this.label24.Text = " Stock Diam \r\nOr Thickness";
            // 
            // ReturnToStockDiam
            // 
            this.ReturnToStockDiam.BackColor = System.Drawing.Color.White;
            this.ReturnToStockDiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToStockDiam.Location = new System.Drawing.Point(552, 345);
            this.ReturnToStockDiam.MaxLength = 8;
            this.ReturnToStockDiam.Name = "ReturnToStockDiam";
            this.ReturnToStockDiam.Size = new System.Drawing.Size(105, 31);
            this.ReturnToStockDiam.TabIndex = 94;
            this.ReturnToStockDiam.Text = "2.00";
            this.ReturnToStockDiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReturnToStockDiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // CancelLimit
            // 
            this.CancelLimit.BackColor = System.Drawing.Color.Black;
            this.CancelLimit.FlatAppearance.BorderSize = 0;
            this.CancelLimit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLimit.ForeColor = System.Drawing.Color.Red;
            this.CancelLimit.Location = new System.Drawing.Point(539, 470);
            this.CancelLimit.Name = "CancelLimit";
            this.CancelLimit.Size = new System.Drawing.Size(709, 32);
            this.CancelLimit.TabIndex = 100;
            this.CancelLimit.Text = "STOP";
            this.CancelLimit.UseVisualStyleBackColor = false;
            this.CancelLimit.Click += new System.EventHandler(this.CancelLimit_Click);
            // 
            // LimitA
            // 
            this.LimitA.BackColor = System.Drawing.Color.Yellow;
            this.LimitA.FlatAppearance.BorderSize = 2;
            this.LimitA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LimitA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimitA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitA.ForeColor = System.Drawing.Color.Black;
            this.LimitA.Location = new System.Drawing.Point(1115, 255);
            this.LimitA.Name = "LimitA";
            this.LimitA.Size = new System.Drawing.Size(133, 31);
            this.LimitA.TabIndex = 99;
            this.LimitA.Text = "Home Limit A";
            this.LimitA.UseVisualStyleBackColor = false;
            this.LimitA.Click += new System.EventHandler(this.LimitA_Click);
            // 
            // LimitZ
            // 
            this.LimitZ.BackColor = System.Drawing.Color.Yellow;
            this.LimitZ.FlatAppearance.BorderSize = 2;
            this.LimitZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LimitZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimitZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitZ.ForeColor = System.Drawing.Color.Black;
            this.LimitZ.Location = new System.Drawing.Point(971, 255);
            this.LimitZ.Name = "LimitZ";
            this.LimitZ.Size = new System.Drawing.Size(133, 31);
            this.LimitZ.TabIndex = 98;
            this.LimitZ.Text = "Home Limit Z";
            this.LimitZ.UseVisualStyleBackColor = false;
            this.LimitZ.Click += new System.EventHandler(this.LimitZ_Click);
            // 
            // LimitY
            // 
            this.LimitY.BackColor = System.Drawing.Color.Yellow;
            this.LimitY.FlatAppearance.BorderSize = 2;
            this.LimitY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LimitY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimitY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitY.ForeColor = System.Drawing.Color.Black;
            this.LimitY.Location = new System.Drawing.Point(827, 255);
            this.LimitY.Name = "LimitY";
            this.LimitY.Size = new System.Drawing.Size(133, 31);
            this.LimitY.TabIndex = 97;
            this.LimitY.Text = "Home Limit Y";
            this.LimitY.UseVisualStyleBackColor = false;
            this.LimitY.Click += new System.EventHandler(this.LimitY_Click);
            // 
            // LimitX
            // 
            this.LimitX.BackColor = System.Drawing.Color.Yellow;
            this.LimitX.FlatAppearance.BorderSize = 2;
            this.LimitX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LimitX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimitX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitX.ForeColor = System.Drawing.Color.Black;
            this.LimitX.Location = new System.Drawing.Point(683, 255);
            this.LimitX.Name = "LimitX";
            this.LimitX.Size = new System.Drawing.Size(133, 31);
            this.LimitX.TabIndex = 96;
            this.LimitX.Text = "Home Limit X";
            this.LimitX.UseVisualStyleBackColor = false;
            this.LimitX.Click += new System.EventHandler(this.LimitX_Click);
            // 
            // ToolSet
            // 
            this.ToolSet.BackColor = System.Drawing.Color.Yellow;
            this.ToolSet.FlatAppearance.BorderSize = 2;
            this.ToolSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ToolSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolSet.ForeColor = System.Drawing.Color.Black;
            this.ToolSet.Location = new System.Drawing.Point(539, 255);
            this.ToolSet.Name = "ToolSet";
            this.ToolSet.Size = new System.Drawing.Size(133, 31);
            this.ToolSet.TabIndex = 93;
            this.ToolSet.Text = "Auto Tool Set";
            this.ToolSet.UseVisualStyleBackColor = false;
            this.ToolSet.Click += new System.EventHandler(this.ToolSet_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Lime;
            this.label61.Location = new System.Drawing.Point(536, 789);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(99, 16);
            this.label61.TabIndex = 0;
            this.label61.Text = "Rapid Speed";
            // 
            // DrillRapid
            // 
            this.DrillRapid.BackColor = System.Drawing.Color.Transparent;
            this.DrillRapid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DrillRapid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrillRapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrillRapid.ForeColor = System.Drawing.Color.Cyan;
            this.DrillRapid.Location = new System.Drawing.Point(545, 809);
            this.DrillRapid.Name = "DrillRapid";
            this.DrillRapid.Size = new System.Drawing.Size(81, 31);
            this.DrillRapid.TabIndex = 76;
            this.DrillRapid.Text = "25";
            this.DrillRapid.UseVisualStyleBackColor = false;
            this.DrillRapid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // TPI
            // 
            this.TPI.BackColor = System.Drawing.Color.White;
            this.TPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPI.Location = new System.Drawing.Point(955, 636);
            this.TPI.MaxLength = 10;
            this.TPI.Name = "TPI";
            this.TPI.ReadOnly = true;
            this.TPI.Size = new System.Drawing.Size(114, 31);
            this.TPI.TabIndex = 0;
            this.TPI.Text = "0";
            this.TPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Lime;
            this.label62.Location = new System.Drawing.Point(1000, 615);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(28, 15);
            this.label62.TabIndex = 0;
            this.label62.Text = "TPI";
            // 
            // MetricTPI
            // 
            this.MetricTPI.BackColor = System.Drawing.Color.White;
            this.MetricTPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricTPI.Location = new System.Drawing.Point(955, 581);
            this.MetricTPI.MaxLength = 10;
            this.MetricTPI.Name = "MetricTPI";
            this.MetricTPI.Size = new System.Drawing.Size(114, 31);
            this.MetricTPI.TabIndex = 87;
            this.MetricTPI.Text = "1.75";
            this.MetricTPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MetricTPI.TextChanged += new System.EventHandler(this.MetricTPI_TextChanged);
            this.MetricTPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Lime;
            this.label63.Location = new System.Drawing.Point(967, 561);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(83, 15);
            this.label63.TabIndex = 0;
            this.label63.Text = "Metric Pitch";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Lime;
            this.label64.Location = new System.Drawing.Point(956, 533);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(111, 20);
            this.label64.TabIndex = 0;
            this.label64.Text = "Metric to TPI";
            // 
            // GoThread
            // 
            this.GoThread.AutoSize = true;
            this.GoThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoThread.ForeColor = System.Drawing.Color.Lime;
            this.GoThread.Location = new System.Drawing.Point(80, 926);
            this.GoThread.Name = "GoThread";
            this.GoThread.Size = new System.Drawing.Size(177, 25);
            this.GoThread.TabIndex = 0;
            this.GoThread.Text = "Waiting For TDC!";
            this.GoThread.TextChanged += new System.EventHandler(this.GoThread_TextChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Lime;
            this.label55.Location = new System.Drawing.Point(568, 844);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(36, 16);
            this.label55.TabIndex = 0;
            this.label55.Text = "Axis";
            // 
            // DrillAxis
            // 
            this.DrillAxis.BackColor = System.Drawing.Color.Transparent;
            this.DrillAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DrillAxis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DrillAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrillAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrillAxis.ForeColor = System.Drawing.Color.Cyan;
            this.DrillAxis.Location = new System.Drawing.Point(545, 866);
            this.DrillAxis.Name = "DrillAxis";
            this.DrillAxis.Size = new System.Drawing.Size(81, 31);
            this.DrillAxis.TabIndex = 77;
            this.DrillAxis.Text = "x";
            this.DrillAxis.UseVisualStyleBackColor = false;
            this.DrillAxis.Click += new System.EventHandler(this.DrillAxis_Click);
            // 
            // AnegTB
            // 
            this.AnegTB.BackColor = System.Drawing.Color.White;
            this.AnegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnegTB.ForeColor = System.Drawing.Color.Black;
            this.AnegTB.Location = new System.Drawing.Point(14, 523);
            this.AnegTB.MaxLength = 6;
            this.AnegTB.Name = "AnegTB";
            this.AnegTB.Size = new System.Drawing.Size(102, 31);
            this.AnegTB.TabIndex = 50;
            this.AnegTB.Text = "0.080";
            this.AnegTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AnegTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // AposTB
            // 
            this.AposTB.BackColor = System.Drawing.Color.White;
            this.AposTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AposTB.ForeColor = System.Drawing.Color.Black;
            this.AposTB.Location = new System.Drawing.Point(14, 560);
            this.AposTB.MaxLength = 6;
            this.AposTB.Name = "AposTB";
            this.AposTB.Size = new System.Drawing.Size(102, 31);
            this.AposTB.TabIndex = 54;
            this.AposTB.Text = "0.080";
            this.AposTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AposTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // ZposTB
            // 
            this.ZposTB.BackColor = System.Drawing.Color.White;
            this.ZposTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZposTB.ForeColor = System.Drawing.Color.Black;
            this.ZposTB.Location = new System.Drawing.Point(14, 471);
            this.ZposTB.MaxLength = 6;
            this.ZposTB.Name = "ZposTB";
            this.ZposTB.Size = new System.Drawing.Size(102, 31);
            this.ZposTB.TabIndex = 46;
            this.ZposTB.Text = "0.080";
            this.ZposTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ZposTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // ZnegTB
            // 
            this.ZnegTB.BackColor = System.Drawing.Color.White;
            this.ZnegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZnegTB.ForeColor = System.Drawing.Color.Black;
            this.ZnegTB.Location = new System.Drawing.Point(14, 434);
            this.ZnegTB.MaxLength = 6;
            this.ZnegTB.Name = "ZnegTB";
            this.ZnegTB.Size = new System.Drawing.Size(102, 31);
            this.ZnegTB.TabIndex = 42;
            this.ZnegTB.Text = "0.080";
            this.ZnegTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ZnegTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // AnegIPM
            // 
            this.AnegIPM.BackColor = System.Drawing.Color.Transparent;
            this.AnegIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AnegIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnegIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnegIPM.ForeColor = System.Drawing.Color.Cyan;
            this.AnegIPM.Location = new System.Drawing.Point(195, 523);
            this.AnegIPM.Name = "AnegIPM";
            this.AnegIPM.Size = new System.Drawing.Size(90, 31);
            this.AnegIPM.TabIndex = 52;
            this.AnegIPM.Text = "15";
            this.AnegIPM.UseVisualStyleBackColor = false;
            this.AnegIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // AposIPM
            // 
            this.AposIPM.BackColor = System.Drawing.Color.Transparent;
            this.AposIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AposIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AposIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AposIPM.ForeColor = System.Drawing.Color.Cyan;
            this.AposIPM.Location = new System.Drawing.Point(195, 560);
            this.AposIPM.Name = "AposIPM";
            this.AposIPM.Size = new System.Drawing.Size(90, 31);
            this.AposIPM.TabIndex = 56;
            this.AposIPM.Text = "15";
            this.AposIPM.UseVisualStyleBackColor = false;
            this.AposIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // AnegMove
            // 
            this.AnegMove.BackColor = System.Drawing.Color.Transparent;
            this.AnegMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AnegMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnegMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnegMove.ForeColor = System.Drawing.Color.Cyan;
            this.AnegMove.Location = new System.Drawing.Point(122, 523);
            this.AnegMove.Name = "AnegMove";
            this.AnegMove.Size = new System.Drawing.Size(67, 31);
            this.AnegMove.TabIndex = 51;
            this.AnegMove.Text = "- A";
            this.AnegMove.UseVisualStyleBackColor = false;
            this.AnegMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // AposMove
            // 
            this.AposMove.BackColor = System.Drawing.Color.Transparent;
            this.AposMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AposMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AposMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AposMove.ForeColor = System.Drawing.Color.Cyan;
            this.AposMove.Location = new System.Drawing.Point(122, 560);
            this.AposMove.Name = "AposMove";
            this.AposMove.Size = new System.Drawing.Size(67, 31);
            this.AposMove.TabIndex = 55;
            this.AposMove.Text = "+ A";
            this.AposMove.UseVisualStyleBackColor = false;
            this.AposMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // ZposIPM
            // 
            this.ZposIPM.BackColor = System.Drawing.Color.Transparent;
            this.ZposIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZposIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZposIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZposIPM.ForeColor = System.Drawing.Color.Cyan;
            this.ZposIPM.Location = new System.Drawing.Point(195, 471);
            this.ZposIPM.Name = "ZposIPM";
            this.ZposIPM.Size = new System.Drawing.Size(90, 31);
            this.ZposIPM.TabIndex = 48;
            this.ZposIPM.Text = "15";
            this.ZposIPM.UseVisualStyleBackColor = false;
            this.ZposIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // ZnegIPM
            // 
            this.ZnegIPM.BackColor = System.Drawing.Color.Transparent;
            this.ZnegIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZnegIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZnegIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZnegIPM.ForeColor = System.Drawing.Color.Cyan;
            this.ZnegIPM.Location = new System.Drawing.Point(195, 434);
            this.ZnegIPM.Name = "ZnegIPM";
            this.ZnegIPM.Size = new System.Drawing.Size(90, 31);
            this.ZnegIPM.TabIndex = 44;
            this.ZnegIPM.Text = "15";
            this.ZnegIPM.UseVisualStyleBackColor = false;
            this.ZnegIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // ZposMove
            // 
            this.ZposMove.BackColor = System.Drawing.Color.Transparent;
            this.ZposMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZposMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZposMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZposMove.ForeColor = System.Drawing.Color.Cyan;
            this.ZposMove.Location = new System.Drawing.Point(122, 471);
            this.ZposMove.Name = "ZposMove";
            this.ZposMove.Size = new System.Drawing.Size(67, 31);
            this.ZposMove.TabIndex = 47;
            this.ZposMove.Text = "+ Z";
            this.ZposMove.UseVisualStyleBackColor = false;
            this.ZposMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // ZnegMove
            // 
            this.ZnegMove.BackColor = System.Drawing.Color.Transparent;
            this.ZnegMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ZnegMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZnegMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZnegMove.ForeColor = System.Drawing.Color.Cyan;
            this.ZnegMove.Location = new System.Drawing.Point(122, 434);
            this.ZnegMove.Name = "ZnegMove";
            this.ZnegMove.Size = new System.Drawing.Size(67, 31);
            this.ZnegMove.TabIndex = 43;
            this.ZnegMove.Text = "- Z";
            this.ZnegMove.UseVisualStyleBackColor = false;
            this.ZnegMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Lime;
            this.label54.Location = new System.Drawing.Point(416, 243);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 20);
            this.label54.TabIndex = 0;
            this.label54.Text = "Thread";
            // 
            // manualAn
            // 
            this.manualAn.BackColor = System.Drawing.Color.Transparent;
            this.manualAn.FlatAppearance.BorderSize = 0;
            this.manualAn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualAn.ForeColor = System.Drawing.Color.Black;
            this.manualAn.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Left_Icon_64;
            this.manualAn.Location = new System.Drawing.Point(985, 78);
            this.manualAn.Name = "manualAn";
            this.manualAn.Size = new System.Drawing.Size(65, 65);
            this.manualAn.TabIndex = 21;
            this.manualAn.Text = "-A";
            this.manualAn.UseVisualStyleBackColor = false;
            this.manualAn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualAn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualAp
            // 
            this.manualAp.BackColor = System.Drawing.Color.Transparent;
            this.manualAp.FlatAppearance.BorderSize = 0;
            this.manualAp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualAp.ForeColor = System.Drawing.Color.Black;
            this.manualAp.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Right_Icon_64;
            this.manualAp.Location = new System.Drawing.Point(1116, 78);
            this.manualAp.Name = "manualAp";
            this.manualAp.Size = new System.Drawing.Size(65, 65);
            this.manualAp.TabIndex = 22;
            this.manualAp.Text = "+A";
            this.manualAp.UseVisualStyleBackColor = false;
            this.manualAp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualAp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualZn
            // 
            this.manualZn.BackColor = System.Drawing.Color.Transparent;
            this.manualZn.FlatAppearance.BorderSize = 0;
            this.manualZn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualZn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualZn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualZn.ForeColor = System.Drawing.Color.Black;
            this.manualZn.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Up_Icon_64;
            this.manualZn.Location = new System.Drawing.Point(1051, 13);
            this.manualZn.Name = "manualZn";
            this.manualZn.Size = new System.Drawing.Size(65, 65);
            this.manualZn.TabIndex = 23;
            this.manualZn.Text = "-Z";
            this.manualZn.UseVisualStyleBackColor = false;
            this.manualZn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualZn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualZp
            // 
            this.manualZp.BackColor = System.Drawing.Color.Transparent;
            this.manualZp.FlatAppearance.BorderSize = 0;
            this.manualZp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualZp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualZp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualZp.ForeColor = System.Drawing.Color.Black;
            this.manualZp.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Down_Icon_64;
            this.manualZp.Location = new System.Drawing.Point(1051, 143);
            this.manualZp.Name = "manualZp";
            this.manualZp.Size = new System.Drawing.Size(65, 65);
            this.manualZp.TabIndex = 24;
            this.manualZp.Text = "+Z";
            this.manualZp.UseVisualStyleBackColor = false;
            this.manualZp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualZp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // homeA
            // 
            this.homeA.BackColor = System.Drawing.Color.Transparent;
            this.homeA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeA.ForeColor = System.Drawing.Color.Cyan;
            this.homeA.Location = new System.Drawing.Point(394, 171);
            this.homeA.Name = "homeA";
            this.homeA.Size = new System.Drawing.Size(89, 31);
            this.homeA.TabIndex = 14;
            this.homeA.Text = "Home A";
            this.homeA.UseVisualStyleBackColor = false;
            this.homeA.Click += new System.EventHandler(this.homes_Click);
            // 
            // MetricA
            // 
            this.MetricA.BackColor = System.Drawing.Color.White;
            this.MetricA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricA.ForeColor = System.Drawing.Color.Black;
            this.MetricA.Location = new System.Drawing.Point(100, 171);
            this.MetricA.Name = "MetricA";
            this.MetricA.ReadOnly = true;
            this.MetricA.Size = new System.Drawing.Size(118, 31);
            this.MetricA.TabIndex = 0;
            this.MetricA.Text = "0.000";
            this.MetricA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // incha
            // 
            this.incha.BackColor = System.Drawing.Color.White;
            this.incha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incha.ForeColor = System.Drawing.Color.Black;
            this.incha.Location = new System.Drawing.Point(263, 171);
            this.incha.Name = "incha";
            this.incha.ReadOnly = true;
            this.incha.Size = new System.Drawing.Size(118, 31);
            this.incha.TabIndex = 0;
            this.incha.Text = "0.0000";
            this.incha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.incha.TextChanged += new System.EventHandler(this.inchA_TextChanged);
            // 
            // DoubleA
            // 
            this.DoubleA.BackColor = System.Drawing.Color.Transparent;
            this.DoubleA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DoubleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleA.ForeColor = System.Drawing.Color.Cyan;
            this.DoubleA.Location = new System.Drawing.Point(573, 171);
            this.DoubleA.Name = "DoubleA";
            this.DoubleA.Size = new System.Drawing.Size(58, 31);
            this.DoubleA.TabIndex = 16;
            this.DoubleA.Text = "X 2";
            this.DoubleA.UseVisualStyleBackColor = false;
            this.DoubleA.Click += new System.EventHandler(this.doubleA_Click);
            // 
            // HalfA
            // 
            this.HalfA.BackColor = System.Drawing.Color.Transparent;
            this.HalfA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.HalfA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfA.ForeColor = System.Drawing.Color.Cyan;
            this.HalfA.Location = new System.Drawing.Point(501, 171);
            this.HalfA.Name = "HalfA";
            this.HalfA.Size = new System.Drawing.Size(58, 31);
            this.HalfA.TabIndex = 15;
            this.HalfA.Text = "1/2";
            this.HalfA.UseVisualStyleBackColor = false;
            this.HalfA.Click += new System.EventHandler(this.halfA_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Blue;
            this.label52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Lime;
            this.label52.Location = new System.Drawing.Point(227, 173);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(27, 25);
            this.label52.TabIndex = 0;
            this.label52.Text = "A";
            // 
            // zeroA
            // 
            this.zeroA.BackColor = System.Drawing.Color.Yellow;
            this.zeroA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.zeroA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroA.ForeColor = System.Drawing.Color.Black;
            this.zeroA.Location = new System.Drawing.Point(14, 171);
            this.zeroA.Name = "zeroA";
            this.zeroA.Size = new System.Drawing.Size(71, 31);
            this.zeroA.TabIndex = 4;
            this.zeroA.Text = "Clear";
            this.zeroA.UseVisualStyleBackColor = false;
            this.zeroA.Click += new System.EventHandler(this.zeroA_Click);
            // 
            // homeZ
            // 
            this.homeZ.BackColor = System.Drawing.Color.Transparent;
            this.homeZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeZ.ForeColor = System.Drawing.Color.Cyan;
            this.homeZ.Location = new System.Drawing.Point(394, 127);
            this.homeZ.Name = "homeZ";
            this.homeZ.Size = new System.Drawing.Size(89, 31);
            this.homeZ.TabIndex = 11;
            this.homeZ.Text = "Home Z";
            this.homeZ.UseVisualStyleBackColor = false;
            this.homeZ.Click += new System.EventHandler(this.homes_Click);
            // 
            // MetricZ
            // 
            this.MetricZ.BackColor = System.Drawing.Color.White;
            this.MetricZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricZ.ForeColor = System.Drawing.Color.Black;
            this.MetricZ.Location = new System.Drawing.Point(100, 127);
            this.MetricZ.Name = "MetricZ";
            this.MetricZ.ReadOnly = true;
            this.MetricZ.Size = new System.Drawing.Size(118, 31);
            this.MetricZ.TabIndex = 0;
            this.MetricZ.Text = "0.000";
            this.MetricZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inchz
            // 
            this.inchz.BackColor = System.Drawing.Color.White;
            this.inchz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchz.ForeColor = System.Drawing.Color.Black;
            this.inchz.Location = new System.Drawing.Point(263, 127);
            this.inchz.Name = "inchz";
            this.inchz.ReadOnly = true;
            this.inchz.Size = new System.Drawing.Size(118, 31);
            this.inchz.TabIndex = 0;
            this.inchz.Text = "0.0000";
            this.inchz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inchz.TextChanged += new System.EventHandler(this.inchZ_TextChanged);
            // 
            // DoubleZ
            // 
            this.DoubleZ.BackColor = System.Drawing.Color.Transparent;
            this.DoubleZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DoubleZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleZ.ForeColor = System.Drawing.Color.Cyan;
            this.DoubleZ.Location = new System.Drawing.Point(573, 127);
            this.DoubleZ.Name = "DoubleZ";
            this.DoubleZ.Size = new System.Drawing.Size(58, 31);
            this.DoubleZ.TabIndex = 13;
            this.DoubleZ.Text = "X 2";
            this.DoubleZ.UseVisualStyleBackColor = false;
            this.DoubleZ.Click += new System.EventHandler(this.doubleZ_Click);
            // 
            // HalfZ
            // 
            this.HalfZ.BackColor = System.Drawing.Color.Transparent;
            this.HalfZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.HalfZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfZ.ForeColor = System.Drawing.Color.Cyan;
            this.HalfZ.Location = new System.Drawing.Point(501, 127);
            this.HalfZ.Name = "HalfZ";
            this.HalfZ.Size = new System.Drawing.Size(58, 31);
            this.HalfZ.TabIndex = 12;
            this.HalfZ.Text = "1/2";
            this.HalfZ.UseVisualStyleBackColor = false;
            this.HalfZ.Click += new System.EventHandler(this.halfZ_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(227, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Z";
            // 
            // zeroZ
            // 
            this.zeroZ.BackColor = System.Drawing.Color.Yellow;
            this.zeroZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.zeroZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroZ.ForeColor = System.Drawing.Color.Black;
            this.zeroZ.Location = new System.Drawing.Point(14, 127);
            this.zeroZ.Name = "zeroZ";
            this.zeroZ.Size = new System.Drawing.Size(71, 31);
            this.zeroZ.TabIndex = 3;
            this.zeroZ.Text = "Clear";
            this.zeroZ.UseVisualStyleBackColor = false;
            this.zeroZ.Click += new System.EventHandler(this.zeroZ_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.Lime;
            this.label51.Location = new System.Drawing.Point(1136, 900);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(102, 15);
            this.label51.TabIndex = 0;
            this.label51.Text = "Passes Radius";
            // 
            // CalcRadius
            // 
            this.CalcRadius.BackColor = System.Drawing.Color.White;
            this.CalcRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcRadius.Location = new System.Drawing.Point(1130, 920);
            this.CalcRadius.MaxLength = 10;
            this.CalcRadius.Name = "CalcRadius";
            this.CalcRadius.ReadOnly = true;
            this.CalcRadius.Size = new System.Drawing.Size(114, 31);
            this.CalcRadius.TabIndex = 0;
            this.CalcRadius.Text = "0";
            this.CalcRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Lime;
            this.label50.Location = new System.Drawing.Point(1141, 844);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(91, 15);
            this.label50.TabIndex = 0;
            this.label50.Text = "Passes Diam";
            // 
            // CalcPass
            // 
            this.CalcPass.BackColor = System.Drawing.Color.White;
            this.CalcPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcPass.Location = new System.Drawing.Point(1130, 864);
            this.CalcPass.MaxLength = 10;
            this.CalcPass.Name = "CalcPass";
            this.CalcPass.ReadOnly = true;
            this.CalcPass.Size = new System.Drawing.Size(114, 31);
            this.CalcPass.TabIndex = 0;
            this.CalcPass.Text = "0";
            this.CalcPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Lime;
            this.label48.Location = new System.Drawing.Point(1154, 789);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(60, 15);
            this.label48.TabIndex = 0;
            this.label48.Text = "Material";
            // 
            // CalcAnswer
            // 
            this.CalcAnswer.BackColor = System.Drawing.Color.White;
            this.CalcAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcAnswer.Location = new System.Drawing.Point(1130, 808);
            this.CalcAnswer.MaxLength = 10;
            this.CalcAnswer.Name = "CalcAnswer";
            this.CalcAnswer.ReadOnly = true;
            this.CalcAnswer.Size = new System.Drawing.Size(114, 31);
            this.CalcAnswer.TabIndex = 0;
            this.CalcAnswer.Text = "0";
            this.CalcAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorCalc
            // 
            this.CalculatorCalc.BackColor = System.Drawing.Color.Yellow;
            this.CalculatorCalc.FlatAppearance.BorderSize = 2;
            this.CalculatorCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CalculatorCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorCalc.ForeColor = System.Drawing.Color.Black;
            this.CalculatorCalc.Location = new System.Drawing.Point(1129, 755);
            this.CalculatorCalc.Name = "CalculatorCalc";
            this.CalculatorCalc.Size = new System.Drawing.Size(115, 31);
            this.CalculatorCalc.TabIndex = 92;
            this.CalculatorCalc.Text = "Calculate";
            this.CalculatorCalc.UseVisualStyleBackColor = false;
            this.CalculatorCalc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // CalcDOC
            // 
            this.CalcDOC.BackColor = System.Drawing.Color.White;
            this.CalcDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcDOC.Location = new System.Drawing.Point(1129, 695);
            this.CalcDOC.MaxLength = 10;
            this.CalcDOC.Name = "CalcDOC";
            this.CalcDOC.Size = new System.Drawing.Size(114, 31);
            this.CalcDOC.TabIndex = 91;
            this.CalcDOC.Text = "0.005";
            this.CalcDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalcDOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Lime;
            this.label46.Location = new System.Drawing.Point(1143, 674);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(88, 15);
            this.label46.TabIndex = 0;
            this.label46.Text = "Depth Of Cut";
            // 
            // CalcTagetDiam
            // 
            this.CalcTagetDiam.BackColor = System.Drawing.Color.White;
            this.CalcTagetDiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTagetDiam.Location = new System.Drawing.Point(1129, 636);
            this.CalcTagetDiam.MaxLength = 10;
            this.CalcTagetDiam.Name = "CalcTagetDiam";
            this.CalcTagetDiam.Size = new System.Drawing.Size(114, 31);
            this.CalcTagetDiam.TabIndex = 90;
            this.CalcTagetDiam.Text = "1";
            this.CalcTagetDiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalcTagetDiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Lime;
            this.label47.Location = new System.Drawing.Point(1132, 617);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(111, 15);
            this.label47.TabIndex = 0;
            this.label47.Text = "Target Diameter";
            // 
            // CalcDiam
            // 
            this.CalcDiam.BackColor = System.Drawing.Color.White;
            this.CalcDiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcDiam.Location = new System.Drawing.Point(1129, 581);
            this.CalcDiam.MaxLength = 10;
            this.CalcDiam.Name = "CalcDiam";
            this.CalcDiam.Size = new System.Drawing.Size(114, 31);
            this.CalcDiam.TabIndex = 89;
            this.CalcDiam.Text = "2";
            this.CalcDiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalcDiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // Calclabel
            // 
            this.Calclabel.AutoSize = true;
            this.Calclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calclabel.ForeColor = System.Drawing.Color.Lime;
            this.Calclabel.Location = new System.Drawing.Point(1127, 560);
            this.Calclabel.Name = "Calclabel";
            this.Calclabel.Size = new System.Drawing.Size(117, 15);
            this.Calclabel.TabIndex = 0;
            this.Calclabel.Text = "Current Diameter";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Lime;
            this.label49.Location = new System.Drawing.Point(1140, 533);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(90, 20);
            this.label49.TabIndex = 0;
            this.label49.Text = "Calculator";
            // 
            // Drill
            // 
            this.Drill.BackColor = System.Drawing.Color.Yellow;
            this.Drill.FlatAppearance.BorderSize = 2;
            this.Drill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Drill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drill.ForeColor = System.Drawing.Color.Black;
            this.Drill.Location = new System.Drawing.Point(545, 920);
            this.Drill.Name = "Drill";
            this.Drill.Size = new System.Drawing.Size(81, 31);
            this.Drill.TabIndex = 78;
            this.Drill.Text = "Export";
            this.Drill.UseVisualStyleBackColor = false;
            this.Drill.Click += new System.EventHandler(this.Drill_Click);
            // 
            // peckDepth
            // 
            this.peckDepth.BackColor = System.Drawing.Color.White;
            this.peckDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peckDepth.Location = new System.Drawing.Point(545, 695);
            this.peckDepth.Name = "peckDepth";
            this.peckDepth.Size = new System.Drawing.Size(81, 31);
            this.peckDepth.TabIndex = 75;
            this.peckDepth.Text = "0.125";
            this.peckDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.peckDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.Lime;
            this.label45.Location = new System.Drawing.Point(543, 674);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(87, 16);
            this.label45.TabIndex = 0;
            this.label45.Text = "Peck Depth";
            // 
            // drillFeed
            // 
            this.drillFeed.BackColor = System.Drawing.Color.White;
            this.drillFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillFeed.Location = new System.Drawing.Point(545, 636);
            this.drillFeed.Name = "drillFeed";
            this.drillFeed.Size = new System.Drawing.Size(81, 31);
            this.drillFeed.TabIndex = 74;
            this.drillFeed.Text = "2";
            this.drillFeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.drillFeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Lime;
            this.label44.Location = new System.Drawing.Point(549, 617);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(73, 16);
            this.label44.TabIndex = 0;
            this.label44.Text = "Feed IPM";
            // 
            // drillDepth
            // 
            this.drillDepth.BackColor = System.Drawing.Color.White;
            this.drillDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillDepth.Location = new System.Drawing.Point(545, 581);
            this.drillDepth.Name = "drillDepth";
            this.drillDepth.Size = new System.Drawing.Size(81, 31);
            this.drillDepth.TabIndex = 73;
            this.drillDepth.Text = "2";
            this.drillDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.drillDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Lime;
            this.label42.Location = new System.Drawing.Point(546, 561);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(80, 16);
            this.label42.TabIndex = 0;
            this.label42.Text = "Drill Depth";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Lime;
            this.checkBox4.Location = new System.Drawing.Point(423, 842);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(41, 24);
            this.checkBox4.TabIndex = 71;
            this.checkBox4.Text = "D";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox3.Location = new System.Drawing.Point(423, 812);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 24);
            this.checkBox3.TabIndex = 70;
            this.checkBox3.Text = "C";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(423, 782);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 24);
            this.checkBox2.TabIndex = 69;
            this.checkBox2.Text = "B";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBox1.Location = new System.Drawing.Point(423, 752);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 24);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "A";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Lime;
            this.label43.Location = new System.Drawing.Point(409, 674);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 16);
            this.label43.TabIndex = 0;
            this.label43.Text = "Feed IPM";
            // 
            // DegreeIPM
            // 
            this.DegreeIPM.BackColor = System.Drawing.Color.White;
            this.DegreeIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeIPM.Location = new System.Drawing.Point(395, 695);
            this.DegreeIPM.MaxLength = 3;
            this.DegreeIPM.Name = "DegreeIPM";
            this.DegreeIPM.Size = new System.Drawing.Size(102, 31);
            this.DegreeIPM.TabIndex = 67;
            this.DegreeIPM.Text = "5";
            this.DegreeIPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DegreeIPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Lime;
            this.label40.Location = new System.Drawing.Point(825, 560);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 16);
            this.label40.TabIndex = 0;
            this.label40.Text = "IPM";
            // 
            // IPMtaper
            // 
            this.IPMtaper.BackColor = System.Drawing.Color.White;
            this.IPMtaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPMtaper.Location = new System.Drawing.Point(791, 581);
            this.IPMtaper.MaxLength = 2;
            this.IPMtaper.Name = "IPMtaper";
            this.IPMtaper.Size = new System.Drawing.Size(102, 31);
            this.IPMtaper.TabIndex = 83;
            this.IPMtaper.Text = "5";
            this.IPMtaper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IPMtaper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Lime;
            this.label39.Location = new System.Drawing.Point(796, 616);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(91, 16);
            this.label39.TabIndex = 0;
            this.label39.Text = "Depth of Cut";
            // 
            // DOCtaper
            // 
            this.DOCtaper.BackColor = System.Drawing.Color.White;
            this.DOCtaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOCtaper.Location = new System.Drawing.Point(791, 636);
            this.DOCtaper.MaxLength = 8;
            this.DOCtaper.Name = "DOCtaper";
            this.DOCtaper.Size = new System.Drawing.Size(102, 31);
            this.DOCtaper.TabIndex = 84;
            this.DOCtaper.Text = "0.005";
            this.DOCtaper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DOCtaper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // RPM
            // 
            this.RPM.BackColor = System.Drawing.Color.White;
            this.RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPM.ForeColor = System.Drawing.Color.Red;
            this.RPM.Location = new System.Drawing.Point(14, 796);
            this.RPM.MaxLength = 8;
            this.RPM.Name = "RPM";
            this.RPM.ReadOnly = true;
            this.RPM.Size = new System.Drawing.Size(313, 116);
            this.RPM.TabIndex = 0;
            this.RPM.Text = "0";
            this.RPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RPM.WordWrap = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Lime;
            this.label38.Location = new System.Drawing.Point(127, 760);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 33);
            this.label38.TabIndex = 0;
            this.label38.Text = "RPM";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Lime;
            this.label37.Location = new System.Drawing.Point(544, 533);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(84, 20);
            this.label37.TabIndex = 0;
            this.label37.Text = "Peck Drill";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Lime;
            this.label36.Location = new System.Drawing.Point(398, 533);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(98, 20);
            this.label36.TabIndex = 0;
            this.label36.Text = "Cut Radius";
            // 
            // CycleRadius
            // 
            this.CycleRadius.BackColor = System.Drawing.Color.Yellow;
            this.CycleRadius.FlatAppearance.BorderSize = 2;
            this.CycleRadius.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CycleRadius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CycleRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CycleRadius.ForeColor = System.Drawing.Color.Black;
            this.CycleRadius.Location = new System.Drawing.Point(395, 920);
            this.CycleRadius.Name = "CycleRadius";
            this.CycleRadius.Size = new System.Drawing.Size(102, 31);
            this.CycleRadius.TabIndex = 72;
            this.CycleRadius.Text = "Export";
            this.CycleRadius.UseVisualStyleBackColor = false;
            this.CycleRadius.Click += new System.EventHandler(this.CycleRadius_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Lime;
            this.label35.Location = new System.Drawing.Point(404, 617);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Degree Inc";
            // 
            // DegreeInc
            // 
            this.DegreeInc.BackColor = System.Drawing.Color.White;
            this.DegreeInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeInc.Location = new System.Drawing.Point(395, 636);
            this.DegreeInc.MaxLength = 5;
            this.DegreeInc.Name = "DegreeInc";
            this.DegreeInc.Size = new System.Drawing.Size(102, 31);
            this.DegreeInc.TabIndex = 66;
            this.DegreeInc.Text = "1";
            this.DegreeInc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DegreeInc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Lime;
            this.label34.Location = new System.Drawing.Point(419, 560);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 16);
            this.label34.TabIndex = 0;
            this.label34.Text = "Radius";
            // 
            // CircleRadius
            // 
            this.CircleRadius.BackColor = System.Drawing.Color.White;
            this.CircleRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleRadius.Location = new System.Drawing.Point(395, 581);
            this.CircleRadius.MaxLength = 8;
            this.CircleRadius.Name = "CircleRadius";
            this.CircleRadius.Size = new System.Drawing.Size(102, 31);
            this.CircleRadius.TabIndex = 65;
            this.CircleRadius.Text = "0.25";
            this.CircleRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CircleRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(917, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "IPM";
            // 
            // manualIPM
            // 
            this.manualIPM.BackColor = System.Drawing.Color.White;
            this.manualIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualIPM.Location = new System.Drawing.Point(913, 92);
            this.manualIPM.MaxLength = 8;
            this.manualIPM.Name = "manualIPM";
            this.manualIPM.Size = new System.Drawing.Size(54, 35);
            this.manualIPM.TabIndex = 25;
            this.manualIPM.Text = "20";
            this.manualIPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.manualIPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // saveGcode
            // 
            this.saveGcode.BackColor = System.Drawing.Color.Transparent;
            this.saveGcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.saveGcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGcode.ForeColor = System.Drawing.Color.Cyan;
            this.saveGcode.Location = new System.Drawing.Point(1288, 545);
            this.saveGcode.Name = "saveGcode";
            this.saveGcode.Size = new System.Drawing.Size(121, 30);
            this.saveGcode.TabIndex = 153;
            this.saveGcode.Text = "Save File";
            this.saveGcode.UseVisualStyleBackColor = false;
            this.saveGcode.Click += new System.EventHandler(this.saveGcode_Click);
            // 
            // manualXn
            // 
            this.manualXn.BackColor = System.Drawing.Color.Transparent;
            this.manualXn.FlatAppearance.BorderSize = 0;
            this.manualXn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.manualXn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualXn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualXn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualXn.ForeColor = System.Drawing.Color.Black;
            this.manualXn.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Left_Icon_64;
            this.manualXn.Location = new System.Drawing.Point(698, 78);
            this.manualXn.Name = "manualXn";
            this.manualXn.Size = new System.Drawing.Size(65, 65);
            this.manualXn.TabIndex = 17;
            this.manualXn.Text = "-X";
            this.manualXn.UseVisualStyleBackColor = false;
            this.manualXn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualXn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualXp
            // 
            this.manualXp.BackColor = System.Drawing.Color.Transparent;
            this.manualXp.FlatAppearance.BorderSize = 0;
            this.manualXp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.manualXp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualXp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualXp.ForeColor = System.Drawing.Color.Black;
            this.manualXp.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Right_Icon_64;
            this.manualXp.Location = new System.Drawing.Point(828, 78);
            this.manualXp.Name = "manualXp";
            this.manualXp.Size = new System.Drawing.Size(65, 65);
            this.manualXp.TabIndex = 18;
            this.manualXp.Text = "+X";
            this.manualXp.UseVisualStyleBackColor = false;
            this.manualXp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualXp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualYp
            // 
            this.manualYp.BackColor = System.Drawing.Color.Transparent;
            this.manualYp.FlatAppearance.BorderSize = 0;
            this.manualYp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.manualYp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualYp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualYp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualYp.ForeColor = System.Drawing.Color.Black;
            this.manualYp.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Down_Icon_64;
            this.manualYp.Location = new System.Drawing.Point(763, 143);
            this.manualYp.Name = "manualYp";
            this.manualYp.Size = new System.Drawing.Size(65, 65);
            this.manualYp.TabIndex = 20;
            this.manualYp.Text = "+Y";
            this.manualYp.UseVisualStyleBackColor = false;
            this.manualYp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualYp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // manualYn
            // 
            this.manualYn.BackColor = System.Drawing.Color.Transparent;
            this.manualYn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manualYn.FlatAppearance.BorderSize = 0;
            this.manualYn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.manualYn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.manualYn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualYn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualYn.ForeColor = System.Drawing.Color.Black;
            this.manualYn.Image = global::Rummage_CNC.Properties.Resources.Alarm_Arrow_Up_Icon_64;
            this.manualYn.Location = new System.Drawing.Point(763, 13);
            this.manualYn.Name = "manualYn";
            this.manualYn.Size = new System.Drawing.Size(65, 65);
            this.manualYn.TabIndex = 19;
            this.manualYn.Text = "-Y";
            this.manualYn.UseVisualStyleBackColor = false;
            this.manualYn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseDown);
            this.manualYn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.manualMoves_MouseUp);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Lime;
            this.label33.Location = new System.Drawing.Point(1605, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 25);
            this.label33.TabIndex = 0;
            this.label33.Text = "RG Code";
            // 
            // homeY
            // 
            this.homeY.BackColor = System.Drawing.Color.Transparent;
            this.homeY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeY.ForeColor = System.Drawing.Color.Cyan;
            this.homeY.Location = new System.Drawing.Point(394, 83);
            this.homeY.Name = "homeY";
            this.homeY.Size = new System.Drawing.Size(89, 31);
            this.homeY.TabIndex = 8;
            this.homeY.Text = "Home Y";
            this.homeY.UseVisualStyleBackColor = false;
            this.homeY.Click += new System.EventHandler(this.homes_Click);
            // 
            // homeX
            // 
            this.homeX.BackColor = System.Drawing.Color.Transparent;
            this.homeX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeX.ForeColor = System.Drawing.Color.Cyan;
            this.homeX.Location = new System.Drawing.Point(394, 39);
            this.homeX.Name = "homeX";
            this.homeX.Size = new System.Drawing.Size(89, 31);
            this.homeX.TabIndex = 5;
            this.homeX.Text = "Home X";
            this.homeX.UseVisualStyleBackColor = false;
            this.homeX.Click += new System.EventHandler(this.homes_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Lime;
            this.label32.Location = new System.Drawing.Point(798, 674);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "To Remove";
            // 
            // ToRemove
            // 
            this.ToRemove.BackColor = System.Drawing.Color.White;
            this.ToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToRemove.Location = new System.Drawing.Point(791, 695);
            this.ToRemove.MaxLength = 8;
            this.ToRemove.Name = "ToRemove";
            this.ToRemove.Size = new System.Drawing.Size(102, 31);
            this.ToRemove.TabIndex = 85;
            this.ToRemove.Text = "0.005";
            this.ToRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Lime;
            this.label31.Location = new System.Drawing.Point(680, 734);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 16);
            this.label31.TabIndex = 0;
            this.label31.Text = "Taper Type";
            // 
            // Slope
            // 
            this.Slope.BackColor = System.Drawing.Color.Transparent;
            this.Slope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Slope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slope.ForeColor = System.Drawing.Color.Cyan;
            this.Slope.Location = new System.Drawing.Point(675, 755);
            this.Slope.Name = "Slope";
            this.Slope.Size = new System.Drawing.Size(102, 31);
            this.Slope.TabIndex = 82;
            this.Slope.Text = "Out";
            this.Slope.UseVisualStyleBackColor = false;
            this.Slope.Click += new System.EventHandler(this.Slope_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Lime;
            this.label30.Location = new System.Drawing.Point(683, 561);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 16);
            this.label30.TabIndex = 0;
            this.label30.Text = "Ratio X to 1";
            // 
            // CycleTaper
            // 
            this.CycleTaper.BackColor = System.Drawing.Color.Yellow;
            this.CycleTaper.FlatAppearance.BorderSize = 2;
            this.CycleTaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CycleTaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CycleTaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CycleTaper.ForeColor = System.Drawing.Color.Black;
            this.CycleTaper.Location = new System.Drawing.Point(737, 920);
            this.CycleTaper.Name = "CycleTaper";
            this.CycleTaper.Size = new System.Drawing.Size(102, 31);
            this.CycleTaper.TabIndex = 86;
            this.CycleTaper.Text = "Export";
            this.CycleTaper.UseVisualStyleBackColor = false;
            this.CycleTaper.Click += new System.EventHandler(this.CycleTaper_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Lime;
            this.label29.Location = new System.Drawing.Point(686, 674);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 16);
            this.label29.TabIndex = 0;
            this.label29.Text = "Long Side";
            // 
            // LongAxis
            // 
            this.LongAxis.BackColor = System.Drawing.Color.Transparent;
            this.LongAxis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.LongAxis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LongAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongAxis.ForeColor = System.Drawing.Color.Cyan;
            this.LongAxis.Location = new System.Drawing.Point(675, 695);
            this.LongAxis.Name = "LongAxis";
            this.LongAxis.Size = new System.Drawing.Size(102, 31);
            this.LongAxis.TabIndex = 81;
            this.LongAxis.Text = "X Axis";
            this.LongAxis.UseVisualStyleBackColor = false;
            this.LongAxis.Click += new System.EventHandler(this.LongAxis_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Lime;
            this.label28.Location = new System.Drawing.Point(736, 530);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Cut Taper";
            // 
            // TaperLength
            // 
            this.TaperLength.BackColor = System.Drawing.Color.White;
            this.TaperLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaperLength.Location = new System.Drawing.Point(675, 636);
            this.TaperLength.MaxLength = 8;
            this.TaperLength.Name = "TaperLength";
            this.TaperLength.Size = new System.Drawing.Size(102, 31);
            this.TaperLength.TabIndex = 80;
            this.TaperLength.Text = "0.5";
            this.TaperLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaperLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Lime;
            this.label27.Location = new System.Drawing.Point(680, 616);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "Long Length";
            // 
            // Ratio
            // 
            this.Ratio.BackColor = System.Drawing.Color.White;
            this.Ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratio.Location = new System.Drawing.Point(675, 581);
            this.Ratio.MaxLength = 8;
            this.Ratio.Name = "Ratio";
            this.Ratio.Size = new System.Drawing.Size(102, 31);
            this.Ratio.TabIndex = 79;
            this.Ratio.Text = "20";
            this.Ratio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ratio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // buttonEnabled
            // 
            this.buttonEnabled.AutoSize = true;
            this.buttonEnabled.ForeColor = System.Drawing.Color.Yellow;
            this.buttonEnabled.Location = new System.Drawing.Point(1402, 954);
            this.buttonEnabled.Name = "buttonEnabled";
            this.buttonEnabled.Size = new System.Drawing.Size(13, 13);
            this.buttonEnabled.TabIndex = 39;
            this.buttonEnabled.Text = "0";
            // 
            // LoadRGCode
            // 
            this.LoadRGCode.BackColor = System.Drawing.Color.Transparent;
            this.LoadRGCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LoadRGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadRGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadRGCode.ForeColor = System.Drawing.Color.Cyan;
            this.LoadRGCode.Location = new System.Drawing.Point(1288, 308);
            this.LoadRGCode.Name = "LoadRGCode";
            this.LoadRGCode.Size = new System.Drawing.Size(121, 30);
            this.LoadRGCode.TabIndex = 150;
            this.LoadRGCode.Text = "Load File";
            this.LoadRGCode.UseVisualStyleBackColor = false;
            this.LoadRGCode.Click += new System.EventHandler(this.loadGcode_Click);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.Lime;
            this.textBox21.Location = new System.Drawing.Point(1284, 61);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(131, 234);
            this.textBox21.TabIndex = 0;
            this.textBox21.Text = "Notes ------->\r\nCut-------->\r\n\r\nCut Speed 1 - 99\r\n\r\nRotation & axis \r\n(-x , -y , " +
    "+z)\r\n\r\nFeed  0.0000\r\n\r\nEx. Format \r\n(22 +x 2.137 )\r\n";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RGcodeRTB
            // 
            this.RGcodeRTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RGcodeRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGcodeRTB.Location = new System.Drawing.Point(1421, 58);
            this.RGcodeRTB.Name = "RGcodeRTB";
            this.RGcodeRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RGcodeRTB.Size = new System.Drawing.Size(468, 910);
            this.RGcodeRTB.TabIndex = 155;
            this.RGcodeRTB.Text = "{notes}\n5 -x 0.08\n{notes}\n10 +y 0.04\n";
            // 
            // CurrentCycle
            // 
            this.CurrentCycle.BackColor = System.Drawing.Color.White;
            this.CurrentCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCycle.Location = new System.Drawing.Point(1288, 809);
            this.CurrentCycle.Name = "CurrentCycle";
            this.CurrentCycle.Size = new System.Drawing.Size(121, 31);
            this.CurrentCycle.TabIndex = 0;
            this.CurrentCycle.Text = "0";
            this.CurrentCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrentCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // ThreadRPM
            // 
            this.ThreadRPM.BackColor = System.Drawing.Color.White;
            this.ThreadRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadRPM.Location = new System.Drawing.Point(407, 291);
            this.ThreadRPM.Name = "ThreadRPM";
            this.ThreadRPM.Size = new System.Drawing.Size(81, 31);
            this.ThreadRPM.TabIndex = 61;
            this.ThreadRPM.Text = "200";
            this.ThreadRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ThreadRPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // ThreadPI
            // 
            this.ThreadPI.BackColor = System.Drawing.Color.White;
            this.ThreadPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadPI.Location = new System.Drawing.Point(407, 346);
            this.ThreadPI.Name = "ThreadPI";
            this.ThreadPI.Size = new System.Drawing.Size(81, 31);
            this.ThreadPI.TabIndex = 62;
            this.ThreadPI.Text = "10";
            this.ThreadPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ThreadPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // CycleCount
            // 
            this.CycleCount.BackColor = System.Drawing.Color.White;
            this.CycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CycleCount.Location = new System.Drawing.Point(1288, 755);
            this.CycleCount.Name = "CycleCount";
            this.CycleCount.Size = new System.Drawing.Size(121, 31);
            this.CycleCount.TabIndex = 58;
            this.CycleCount.Text = "1";
            this.CycleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CycleCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // YnegTB
            // 
            this.YnegTB.BackColor = System.Drawing.Color.White;
            this.YnegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YnegTB.ForeColor = System.Drawing.Color.Black;
            this.YnegTB.Location = new System.Drawing.Point(14, 345);
            this.YnegTB.MaxLength = 6;
            this.YnegTB.Name = "YnegTB";
            this.YnegTB.Size = new System.Drawing.Size(102, 31);
            this.YnegTB.TabIndex = 34;
            this.YnegTB.Text = "0.080";
            this.YnegTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YnegTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // YposTB
            // 
            this.YposTB.BackColor = System.Drawing.Color.White;
            this.YposTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YposTB.ForeColor = System.Drawing.Color.Black;
            this.YposTB.Location = new System.Drawing.Point(14, 382);
            this.YposTB.MaxLength = 6;
            this.YposTB.Name = "YposTB";
            this.YposTB.Size = new System.Drawing.Size(102, 31);
            this.YposTB.TabIndex = 38;
            this.YposTB.Text = "0.080";
            this.YposTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YposTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // XposTB
            // 
            this.XposTB.BackColor = System.Drawing.Color.White;
            this.XposTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XposTB.ForeColor = System.Drawing.Color.Black;
            this.XposTB.Location = new System.Drawing.Point(14, 293);
            this.XposTB.MaxLength = 6;
            this.XposTB.Name = "XposTB";
            this.XposTB.Size = new System.Drawing.Size(102, 31);
            this.XposTB.TabIndex = 30;
            this.XposTB.Text = "0.080";
            this.XposTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.XposTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // XnegTB
            // 
            this.XnegTB.BackColor = System.Drawing.Color.White;
            this.XnegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XnegTB.ForeColor = System.Drawing.Color.Black;
            this.XnegTB.Location = new System.Drawing.Point(14, 256);
            this.XnegTB.MaxLength = 6;
            this.XnegTB.Name = "XnegTB";
            this.XnegTB.Size = new System.Drawing.Size(102, 31);
            this.XnegTB.TabIndex = 26;
            this.XnegTB.Text = "0.080";
            this.XnegTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.XnegTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numonly1_KeyPress);
            // 
            // MetricY
            // 
            this.MetricY.BackColor = System.Drawing.Color.White;
            this.MetricY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricY.ForeColor = System.Drawing.Color.Black;
            this.MetricY.Location = new System.Drawing.Point(100, 83);
            this.MetricY.Name = "MetricY";
            this.MetricY.ReadOnly = true;
            this.MetricY.Size = new System.Drawing.Size(118, 31);
            this.MetricY.TabIndex = 0;
            this.MetricY.Text = "0.000";
            this.MetricY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MetricX
            // 
            this.MetricX.BackColor = System.Drawing.Color.White;
            this.MetricX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricX.ForeColor = System.Drawing.Color.Black;
            this.MetricX.Location = new System.Drawing.Point(100, 39);
            this.MetricX.Name = "MetricX";
            this.MetricX.ReadOnly = true;
            this.MetricX.Size = new System.Drawing.Size(118, 31);
            this.MetricX.TabIndex = 0;
            this.MetricX.Text = "0.000";
            this.MetricX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inchx
            // 
            this.inchx.BackColor = System.Drawing.Color.White;
            this.inchx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchx.ForeColor = System.Drawing.Color.Black;
            this.inchx.Location = new System.Drawing.Point(263, 39);
            this.inchx.Name = "inchx";
            this.inchx.ReadOnly = true;
            this.inchx.Size = new System.Drawing.Size(118, 31);
            this.inchx.TabIndex = 0;
            this.inchx.Text = "0.0000";
            this.inchx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inchx.TextChanged += new System.EventHandler(this.inchX_TextChanged);
            // 
            // inchy
            // 
            this.inchy.BackColor = System.Drawing.Color.White;
            this.inchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchy.ForeColor = System.Drawing.Color.Black;
            this.inchy.Location = new System.Drawing.Point(263, 83);
            this.inchy.Name = "inchy";
            this.inchy.ReadOnly = true;
            this.inchy.Size = new System.Drawing.Size(118, 31);
            this.inchy.TabIndex = 0;
            this.inchy.Text = "0.0000";
            this.inchy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inchy.TextChanged += new System.EventHandler(this.inchY_TextChanged);
            // 
            // RGCodeEStop
            // 
            this.RGCodeEStop.BackColor = System.Drawing.Color.Black;
            this.RGCodeEStop.FlatAppearance.BorderSize = 0;
            this.RGCodeEStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RGCodeEStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGCodeEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGCodeEStop.ForeColor = System.Drawing.Color.Red;
            this.RGCodeEStop.Location = new System.Drawing.Point(1288, 434);
            this.RGCodeEStop.Name = "RGCodeEStop";
            this.RGCodeEStop.Size = new System.Drawing.Size(121, 68);
            this.RGCodeEStop.TabIndex = 152;
            this.RGCodeEStop.Text = "Clear\r\nE-Stop";
            this.RGCodeEStop.UseVisualStyleBackColor = false;
            this.RGCodeEStop.Click += new System.EventHandler(this.ClearEstop_Click);
            // 
            // RunRGcode
            // 
            this.RunRGcode.BackColor = System.Drawing.Color.Yellow;
            this.RunRGcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RunRGcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunRGcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunRGcode.ForeColor = System.Drawing.Color.Black;
            this.RunRGcode.Location = new System.Drawing.Point(1288, 348);
            this.RunRGcode.Name = "RunRGcode";
            this.RunRGcode.Size = new System.Drawing.Size(121, 31);
            this.RunRGcode.TabIndex = 151;
            this.RunRGcode.Text = "Run Code";
            this.RunRGcode.UseVisualStyleBackColor = false;
            this.RunRGcode.Click += new System.EventHandler(this.RunRGcode_Click);
            // 
            // DoubleY
            // 
            this.DoubleY.BackColor = System.Drawing.Color.Transparent;
            this.DoubleY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DoubleY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleY.ForeColor = System.Drawing.Color.Cyan;
            this.DoubleY.Location = new System.Drawing.Point(573, 83);
            this.DoubleY.Name = "DoubleY";
            this.DoubleY.Size = new System.Drawing.Size(58, 31);
            this.DoubleY.TabIndex = 10;
            this.DoubleY.Text = "X 2";
            this.DoubleY.UseVisualStyleBackColor = false;
            this.DoubleY.Click += new System.EventHandler(this.button36_Click);
            // 
            // DoubleX
            // 
            this.DoubleX.BackColor = System.Drawing.Color.Transparent;
            this.DoubleX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DoubleX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleX.ForeColor = System.Drawing.Color.Cyan;
            this.DoubleX.Location = new System.Drawing.Point(573, 38);
            this.DoubleX.Name = "DoubleX";
            this.DoubleX.Size = new System.Drawing.Size(58, 31);
            this.DoubleX.TabIndex = 7;
            this.DoubleX.Text = "X 2";
            this.DoubleX.UseVisualStyleBackColor = false;
            this.DoubleX.Click += new System.EventHandler(this.button35_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.OrangeRed;
            this.label19.Location = new System.Drawing.Point(399, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "To Fast For Stepper";
            this.label19.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Lime;
            this.label26.Location = new System.Drawing.Point(400, 384);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Thread Type";
            // 
            // ThreadType
            // 
            this.ThreadType.BackColor = System.Drawing.Color.White;
            this.ThreadType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ThreadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadType.ForeColor = System.Drawing.Color.Green;
            this.ThreadType.Location = new System.Drawing.Point(407, 405);
            this.ThreadType.Name = "ThreadType";
            this.ThreadType.Size = new System.Drawing.Size(81, 31);
            this.ThreadType.TabIndex = 63;
            this.ThreadType.Text = "External";
            this.ThreadType.UseVisualStyleBackColor = false;
            this.ThreadType.Click += new System.EventHandler(this.button32_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(1306, 791);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Current Count";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(407, 271);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "Lathe RPM";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(433, 327);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "TPI";
            // 
            // ThreadCycle
            // 
            this.ThreadCycle.BackColor = System.Drawing.Color.Yellow;
            this.ThreadCycle.FlatAppearance.BorderSize = 2;
            this.ThreadCycle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ThreadCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreadCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadCycle.ForeColor = System.Drawing.Color.Black;
            this.ThreadCycle.Location = new System.Drawing.Point(407, 470);
            this.ThreadCycle.Name = "ThreadCycle";
            this.ThreadCycle.Size = new System.Drawing.Size(81, 31);
            this.ThreadCycle.TabIndex = 64;
            this.ThreadCycle.Text = "Cycle";
            this.ThreadCycle.UseVisualStyleBackColor = false;
            this.ThreadCycle.Click += new System.EventHandler(this.button25_Click);
            // 
            // Cycle4
            // 
            this.Cycle4.BackColor = System.Drawing.Color.Yellow;
            this.Cycle4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cycle4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Cycle4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cycle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cycle4.ForeColor = System.Drawing.Color.Black;
            this.Cycle4.Location = new System.Drawing.Point(122, 609);
            this.Cycle4.Name = "Cycle4";
            this.Cycle4.Size = new System.Drawing.Size(163, 31);
            this.Cycle4.TabIndex = 59;
            this.Cycle4.Text = "Export";
            this.Cycle4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Cycle4.UseVisualStyleBackColor = false;
            this.Cycle4.Click += new System.EventHandler(this.button24_Click);
            // 
            // YnegIPM
            // 
            this.YnegIPM.BackColor = System.Drawing.Color.Transparent;
            this.YnegIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YnegIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YnegIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YnegIPM.ForeColor = System.Drawing.Color.Cyan;
            this.YnegIPM.Location = new System.Drawing.Point(195, 345);
            this.YnegIPM.Name = "YnegIPM";
            this.YnegIPM.Size = new System.Drawing.Size(90, 31);
            this.YnegIPM.TabIndex = 36;
            this.YnegIPM.Text = "15";
            this.YnegIPM.UseVisualStyleBackColor = false;
            this.YnegIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // YposIPM
            // 
            this.YposIPM.BackColor = System.Drawing.Color.Transparent;
            this.YposIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YposIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YposIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YposIPM.ForeColor = System.Drawing.Color.Cyan;
            this.YposIPM.Location = new System.Drawing.Point(195, 382);
            this.YposIPM.Name = "YposIPM";
            this.YposIPM.Size = new System.Drawing.Size(90, 31);
            this.YposIPM.TabIndex = 40;
            this.YposIPM.Text = "15";
            this.YposIPM.UseVisualStyleBackColor = false;
            this.YposIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // YnegMove
            // 
            this.YnegMove.BackColor = System.Drawing.Color.Transparent;
            this.YnegMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YnegMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YnegMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YnegMove.ForeColor = System.Drawing.Color.Cyan;
            this.YnegMove.Location = new System.Drawing.Point(122, 345);
            this.YnegMove.Name = "YnegMove";
            this.YnegMove.Size = new System.Drawing.Size(67, 31);
            this.YnegMove.TabIndex = 34;
            this.YnegMove.Text = "- Y";
            this.YnegMove.UseVisualStyleBackColor = false;
            this.YnegMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // YposMove
            // 
            this.YposMove.BackColor = System.Drawing.Color.Transparent;
            this.YposMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.YposMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YposMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YposMove.ForeColor = System.Drawing.Color.Cyan;
            this.YposMove.Location = new System.Drawing.Point(122, 382);
            this.YposMove.Name = "YposMove";
            this.YposMove.Size = new System.Drawing.Size(67, 31);
            this.YposMove.TabIndex = 39;
            this.YposMove.Text = "+ Y";
            this.YposMove.UseVisualStyleBackColor = false;
            this.YposMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // XposIPM
            // 
            this.XposIPM.BackColor = System.Drawing.Color.Transparent;
            this.XposIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XposIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XposIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XposIPM.ForeColor = System.Drawing.Color.Cyan;
            this.XposIPM.Location = new System.Drawing.Point(195, 293);
            this.XposIPM.Name = "XposIPM";
            this.XposIPM.Size = new System.Drawing.Size(90, 31);
            this.XposIPM.TabIndex = 32;
            this.XposIPM.Text = "15";
            this.XposIPM.UseVisualStyleBackColor = false;
            this.XposIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(207, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cut speed";
            // 
            // XnegIPM
            // 
            this.XnegIPM.BackColor = System.Drawing.Color.Transparent;
            this.XnegIPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XnegIPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XnegIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XnegIPM.ForeColor = System.Drawing.Color.Cyan;
            this.XnegIPM.Location = new System.Drawing.Point(195, 256);
            this.XnegIPM.Name = "XnegIPM";
            this.XnegIPM.Size = new System.Drawing.Size(90, 31);
            this.XnegIPM.TabIndex = 28;
            this.XnegIPM.Text = "15";
            this.XnegIPM.UseVisualStyleBackColor = false;
            this.XnegIPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttons_MouseDown);
            // 
            // XposMove
            // 
            this.XposMove.BackColor = System.Drawing.Color.Transparent;
            this.XposMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XposMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XposMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XposMove.ForeColor = System.Drawing.Color.Cyan;
            this.XposMove.Location = new System.Drawing.Point(122, 293);
            this.XposMove.Name = "XposMove";
            this.XposMove.Size = new System.Drawing.Size(67, 31);
            this.XposMove.TabIndex = 31;
            this.XposMove.Text = "+ X";
            this.XposMove.UseVisualStyleBackColor = false;
            this.XposMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // XnegMove
            // 
            this.XnegMove.BackColor = System.Drawing.Color.Transparent;
            this.XnegMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XnegMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XnegMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XnegMove.ForeColor = System.Drawing.Color.Cyan;
            this.XnegMove.Location = new System.Drawing.Point(122, 256);
            this.XnegMove.Name = "XnegMove";
            this.XnegMove.Size = new System.Drawing.Size(67, 31);
            this.XnegMove.TabIndex = 27;
            this.XnegMove.Text = "- X";
            this.XnegMove.UseVisualStyleBackColor = false;
            this.XnegMove.Click += new System.EventHandler(this.SteppersGo_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(122, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Metric";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(297, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Inch";
            // 
            // HalfY
            // 
            this.HalfY.BackColor = System.Drawing.Color.Transparent;
            this.HalfY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.HalfY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfY.ForeColor = System.Drawing.Color.Cyan;
            this.HalfY.Location = new System.Drawing.Point(501, 83);
            this.HalfY.Name = "HalfY";
            this.HalfY.Size = new System.Drawing.Size(58, 31);
            this.HalfY.TabIndex = 9;
            this.HalfY.Text = "1/2";
            this.HalfY.UseVisualStyleBackColor = false;
            this.HalfY.Click += new System.EventHandler(this.button13_Click);
            // 
            // HalfX
            // 
            this.HalfX.BackColor = System.Drawing.Color.Transparent;
            this.HalfX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.HalfX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfX.ForeColor = System.Drawing.Color.Cyan;
            this.HalfX.Location = new System.Drawing.Point(501, 38);
            this.HalfX.Name = "HalfX";
            this.HalfX.Size = new System.Drawing.Size(58, 31);
            this.HalfX.TabIndex = 6;
            this.HalfX.Text = "1/2";
            this.HalfX.UseVisualStyleBackColor = false;
            this.HalfX.Click += new System.EventHandler(this.button12_Click);
            // 
            // zeroX
            // 
            this.zeroX.BackColor = System.Drawing.Color.Yellow;
            this.zeroX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.zeroX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroX.ForeColor = System.Drawing.Color.Black;
            this.zeroX.Location = new System.Drawing.Point(14, 39);
            this.zeroX.Name = "zeroX";
            this.zeroX.Size = new System.Drawing.Size(71, 31);
            this.zeroX.TabIndex = 1;
            this.zeroX.Text = "Clear";
            this.zeroX.UseVisualStyleBackColor = false;
            this.zeroX.Click += new System.EventHandler(this.zeroX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(226, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // zeroY
            // 
            this.zeroY.BackColor = System.Drawing.Color.Yellow;
            this.zeroY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.zeroY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroY.ForeColor = System.Drawing.Color.Black;
            this.zeroY.Location = new System.Drawing.Point(14, 83);
            this.zeroY.Name = "zeroY";
            this.zeroY.Size = new System.Drawing.Size(71, 31);
            this.zeroY.TabIndex = 2;
            this.zeroY.Text = "Clear";
            this.zeroY.UseVisualStyleBackColor = false;
            this.zeroY.Click += new System.EventHandler(this.zeroY_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1905, 1000);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1905, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.Lime;
            this.label67.Location = new System.Drawing.Point(1314, 736);
            this.label67.Name = "label67";
            this.label67.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label67.Size = new System.Drawing.Size(71, 13);
            this.label67.TabIndex = 160;
            this.label67.Text = "Run Cycles";
            // 
            // CodeRunning
            // 
            this.CodeRunning.AutoSize = true;
            this.CodeRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeRunning.ForeColor = System.Drawing.Color.Red;
            this.CodeRunning.Location = new System.Drawing.Point(1416, 13);
            this.CodeRunning.Name = "CodeRunning";
            this.CodeRunning.Size = new System.Drawing.Size(0, 25);
            this.CodeRunning.TabIndex = 161;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rummage CNC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox StepMultiplyConvs;
        public System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.TextBox ZConversion;
        public System.Windows.Forms.TextBox YConversion;
        public System.Windows.Forms.TextBox XConversion;
        public System.Windows.Forms.RichTextBox DiagnosticsRTB;
        public System.Windows.Forms.TextBox WriteBuffer;
        public System.Windows.Forms.TextBox ReadBuffer;
        public System.Windows.Forms.Button SaveSettings;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button ConnectSerial;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button SerialReset;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button Baud;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button Com;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button Parity;
        public System.Windows.Forms.Button HandShake;
        public System.Windows.Forms.Button DataBit;
        public System.Windows.Forms.Button StopBit;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button LoadRGCode;
        private System.Windows.Forms.TextBox textBox21;
        public System.Windows.Forms.RichTextBox RGcodeRTB;
        public System.Windows.Forms.TextBox CurrentCycle;
        public System.Windows.Forms.TextBox ThreadRPM;
        public System.Windows.Forms.TextBox ThreadPI;
        public System.Windows.Forms.TextBox CycleCount;
        public System.Windows.Forms.TextBox YnegTB;
        public System.Windows.Forms.TextBox YposTB;
        public System.Windows.Forms.TextBox XposTB;
        public System.Windows.Forms.TextBox XnegTB;
        public System.Windows.Forms.TextBox MetricY;
        public System.Windows.Forms.TextBox MetricX;
        public System.Windows.Forms.TextBox inchx;
        public System.Windows.Forms.TextBox inchy;
        public System.Windows.Forms.Button RGCodeEStop;
        public System.Windows.Forms.Button RunRGcode;
        public System.Windows.Forms.Button DoubleY;
        public System.Windows.Forms.Button DoubleX;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.Button ThreadType;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Button YposOrder;
        public System.Windows.Forms.Button YnegOrder;
        public System.Windows.Forms.Button XposOrder;
        public System.Windows.Forms.Button XnegOrder;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Button ThreadCycle;
        public System.Windows.Forms.Button Cycle4;
        public System.Windows.Forms.Button YnegIPM;
        public System.Windows.Forms.Button YposIPM;
        public System.Windows.Forms.Button YnegMove;
        public System.Windows.Forms.Button YposMove;
        public System.Windows.Forms.Button XposIPM;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Button XnegIPM;
        public System.Windows.Forms.Button XposMove;
        public System.Windows.Forms.Button XnegMove;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button HalfY;
        public System.Windows.Forms.Button HalfX;
        public System.Windows.Forms.Button zeroX;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button zeroY;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label buttonEnabled;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.Button CycleTaper;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.Button LongAxis;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox TaperLength;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox Ratio;
        public System.Windows.Forms.Button Slope;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.TextBox ToRemove;
        public System.Windows.Forms.Button homeY;
        public System.Windows.Forms.Button homeX;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Button manualXn;
        public System.Windows.Forms.Button manualXp;
        public System.Windows.Forms.Button manualYp;
        public System.Windows.Forms.Button manualYn;
        private System.Windows.Forms.Button saveGcode;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox manualIPM;
        public System.Windows.Forms.TextBox CircleRadius;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.Button CycleRadius;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.TextBox DegreeInc;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.Button ExportCode;
        private System.Windows.Forms.Label label37;
        public System.Windows.Forms.TextBox RPM;
        public System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        public System.Windows.Forms.TextBox DOCtaper;
        private System.Windows.Forms.Label label40;
        public System.Windows.Forms.TextBox IPMtaper;
        private System.Windows.Forms.Label label43;
        public System.Windows.Forms.TextBox DegreeIPM;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox drillFeed;
        private System.Windows.Forms.Label label44;
        public System.Windows.Forms.TextBox drillDepth;
        private System.Windows.Forms.Label label42;
        public System.Windows.Forms.Button Drill;
        public System.Windows.Forms.TextBox peckDepth;
        private System.Windows.Forms.Label label45;
        public System.Windows.Forms.TextBox CalcAnswer;
        public System.Windows.Forms.Button CalculatorCalc;
        public System.Windows.Forms.TextBox CalcDOC;
        private System.Windows.Forms.Label label46;
        public System.Windows.Forms.TextBox CalcTagetDiam;
        private System.Windows.Forms.Label label47;
        public System.Windows.Forms.TextBox CalcDiam;
        private System.Windows.Forms.Label Calclabel;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        public System.Windows.Forms.TextBox CalcPass;
        private System.Windows.Forms.Label label51;
        public System.Windows.Forms.TextBox CalcRadius;
        public System.Windows.Forms.Button homeZ;
        public System.Windows.Forms.TextBox MetricZ;
        public System.Windows.Forms.TextBox inchz;
        public System.Windows.Forms.Button DoubleZ;
        public System.Windows.Forms.Button HalfZ;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button zeroZ;
        public System.Windows.Forms.Button homeA;
        public System.Windows.Forms.TextBox MetricA;
        public System.Windows.Forms.TextBox incha;
        public System.Windows.Forms.Button DoubleA;
        public System.Windows.Forms.Button HalfA;
        public System.Windows.Forms.Label label52;
        public System.Windows.Forms.Button zeroA;
        public System.Windows.Forms.Button manualZn;
        public System.Windows.Forms.Button manualZp;
        public System.Windows.Forms.Button manualAn;
        public System.Windows.Forms.Button manualAp;
        public System.Windows.Forms.TextBox AConversion;
        public System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        public System.Windows.Forms.TextBox AnegTB;
        public System.Windows.Forms.TextBox AposTB;
        public System.Windows.Forms.TextBox ZposTB;
        public System.Windows.Forms.TextBox ZnegTB;
        public System.Windows.Forms.Button AposOrder;
        public System.Windows.Forms.Button AnegOrder;
        public System.Windows.Forms.Button ZposOrder;
        public System.Windows.Forms.Button ZnegOrder;
        public System.Windows.Forms.Button AnegIPM;
        public System.Windows.Forms.Button AposIPM;
        public System.Windows.Forms.Button AnegMove;
        public System.Windows.Forms.Button AposMove;
        public System.Windows.Forms.Button ZposIPM;
        public System.Windows.Forms.Button ZnegIPM;
        public System.Windows.Forms.Button ZposMove;
        public System.Windows.Forms.Button ZnegMove;
        private System.Windows.Forms.Label label55;
        public System.Windows.Forms.Button DrillAxis;
        public System.Windows.Forms.TextBox BacklashA;
        public System.Windows.Forms.TextBox BacklashZ;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.TextBox BacklashY;
        public System.Windows.Forms.TextBox BacklashX;
        private System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label GoThread;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        public System.Windows.Forms.TextBox TPI;
        private System.Windows.Forms.Label label62;
        public System.Windows.Forms.TextBox MetricTPI;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label61;
        public System.Windows.Forms.Button DrillRapid;
        public System.Windows.Forms.Button ToolSet;
        public System.Windows.Forms.Button LimitA;
        public System.Windows.Forms.Button LimitZ;
        public System.Windows.Forms.Button LimitY;
        public System.Windows.Forms.Button LimitX;
        public System.Windows.Forms.Button CancelLimit;
        public System.Windows.Forms.TextBox InchConv;
        private System.Windows.Forms.Label label66;
        public System.Windows.Forms.TextBox MetricConv;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox ReturnToStockDiam;
        private System.Windows.Forms.CheckBox IsRadius;
        public System.Windows.Forms.CheckBox ExportsClearCB;
        public System.Windows.Forms.CheckBox checkBoxTaperReturn;
        public System.Windows.Forms.CheckBox ReloadcodeCB;
        public System.Windows.Forms.RichTextBox RepeatBox;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label CodeRunning;
    }
}

