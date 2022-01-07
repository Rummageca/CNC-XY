using System;
using System.Linq;
using System.Threading.Tasks;

namespace Rummage_CNC
{
    class RGcode
    {
        double convrt1 = 0;
        double convrt1a = 0;
        bool startagain = false;
        int loopAmount = 1;
        int loopAmountold = 0;


        public void dualmotors()
        {
            string notclear = Form1.self.RGcodeRTB.Text;

            if (notclear.StartsWith("{") && notclear != "")
            {
                string[] lines = Form1.self.RGcodeRTB.Lines;

                string rotate = "";
                string axis = "";

                string first = lines[1].Split(' ').Skip(0).FirstOrDefault(); // IPM
                string sencond = lines[1].Split(' ').Skip(1).FirstOrDefault(); // Axis
                string third = lines[1].Split(' ').Skip(2).FirstOrDefault(); // feed distance
                string forth = lines[1].Split(' ').Skip(3).FirstOrDefault(); // not used ----- feed type  T or R
                string fifth = lines[1].Split(' ').Skip(4).FirstOrDefault(); // Tapers ratio
                string sixth = lines[1].Split(' ').Skip(5).FirstOrDefault(); // not used yet

                string seven = lines[3].Split(' ').Skip(0).FirstOrDefault(); // 2nd IPM
                string eighth = lines[3].Split(' ').Skip(1).FirstOrDefault(); // 2nd Axis
                string ninth = lines[3].Split(' ').Skip(2).FirstOrDefault(); // 2nd feed distance

                int cpeed = Convert.ToInt32(first);
                string axe = Convert.ToString(sencond);
                double thou = Convert.ToDouble(third);

                double ratio = Convert.ToDouble(fifth);

                if (axe.StartsWith("+"))
                {
                    rotate = "ccw";
                }
                if (axe.StartsWith("-"))
                {
                    rotate = "cw";
                }

                //--------------------------------dual motors-----------------------------------------------------                
                string rotate2 = "";
                string axis2 = "";
                int cpeed2 = Convert.ToInt32(seven);
                string axe2 = Convert.ToString(eighth);
                double thou2 = Convert.ToDouble(ninth);

                if (axe2.StartsWith("+"))
                {
                    rotate2 = "ccw";
                }
                if (axe2.StartsWith("-"))
                {
                    rotate2 = "cw";
                }

                //--------------------------------------------------axis----------------------------------------------------------------
                if (axe.EndsWith("x"))
                {
                    axis = "x";
                    convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);//convertion factor
                }

                if (axe.EndsWith("z"))
                {
                    axis = "z";
                    convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);//convertion factor
                }

                //--------------------------------------------------axis----------------------------------------------------------------
                if (axe2.EndsWith("x"))
                {
                    axis2 = "x";
                    convrt1a = Convert.ToDouble(Form1.self.XConversion.Text);//convertion factor
                }

                if (axe2.EndsWith("z"))
                {
                    axis2 = "z";
                    convrt1a = Convert.ToDouble(Form1.self.ZConversion.Text);//convertion factor
                }

                double convrt2 = thou / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                int convrt4 = Convert.ToInt32(convrt2 / convrt3);


                double convrt2a = thou2 / convrt1a;
                double convrt3a = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                int convrt4a = Convert.ToInt32(convrt2a / convrt3a);

                Form1.self.DiagnosticsRTB.Text += "Taper Values:  X: " + convrt4.ToString() + " Z: " + convrt4a.ToString() + "\r";

                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write(string.Format("{0}\r", cpeed));
                    Form1.self.serialPort1.Write(rotate + axis + "\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0.0}", convrt4 + "\r")));
                    Form1.self.serialPort1.Write("Taper " + "\r");
                    Form1.self.serialPort1.Write(ratio + "\r");
                    Form1.self.serialPort1.Write(rotate2 + axis2 + "\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0.0}", convrt4a + "\r")));
                    Form1.self.serialPort1.Write("Taper\r");
                }

                while (Form1.self.buttonEnabled.Text == "1")
                {
                    Task.Delay(10).Wait();
                }

                removeAllBlock();

            }
            else if (notclear == "" || notclear.StartsWith("N"))
            {
                Form1.self.RGcodeRTB.Text = "No code!";
            }
        }

        public void removeAllBlock()
        {
            while (true)
            {
                string notclear = Form1.self.RGcodeRTB.Text;

                if (notclear.StartsWith("{"))
                {

                    int numOfLines = 4;
                    var lines = Form1.self.RGcodeRTB.Lines;
                    var newLines = lines.Skip(numOfLines);

                    Form1.self.RGcodeRTB.Lines = newLines.ToArray();//remove old lines

                    //resetbuttons();
                    break;
                }
                else
                {
                    break;
                }
            }
            Readcode();
        }
        //-----------------------------------------read GCODE------------------------------------------------------------------------
        public void Readcode()
        {

            string[] lines = Form1.self.RGcodeRTB.Lines;
            string notclear = Form1.self.RGcodeRTB.Text;

            if (notclear.StartsWith("{") && notclear != "")
            {
                if (lines[1].Contains("T"))
                {
                    dualmotors();
                }
                //-------------------------------rotation and axis-----------------------------------------------------------------------
                if (!lines[1].Contains("T"))
                {
                    string rotate = "";
                    string axis = "";

                    string first = lines[1].Split(' ').Skip(0).FirstOrDefault(); // IPM
                    string sencond = lines[1].Split(' ').Skip(1).FirstOrDefault(); // Axis
                    string third = lines[1].Split(' ').Skip(2).FirstOrDefault(); // feed distance
                    string forth = lines[1].Split(' ').Skip(3).FirstOrDefault(); // not used ----- feed type  T or R
                    string fifth = lines[1].Split(' ').Skip(4).FirstOrDefault(); // not used here ---- Tapers ratio
                    string sixth = lines[1].Split(' ').Skip(5).FirstOrDefault(); // not used yet

                    double cpeed = Convert.ToDouble(first);
                    string axe = Convert.ToString(sencond);
                    double thou = Convert.ToDouble(third);

                    if (axe.StartsWith("+"))
                    {
                        rotate = "ccw";
                    }
                    if (axe.StartsWith("-"))
                    {
                        rotate = "cw";
                    }

                    //--------------------------------------------------axis----------------------------------------------------------------
                    if (axe.EndsWith("x"))
                    {
                        axis = "x";
                        convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);//convertion factor
                    }

                    if (axe.EndsWith("y"))
                    {
                        axis = "y";
                        convrt1 = Convert.ToDouble(Form1.self.YConversion.Text);//convertion factor
                    }
                    if (axe.EndsWith("z"))
                    {
                        axis = "z";
                        convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);//convertion factor
                    }
                    if (axe.EndsWith("a"))
                    {
                        axis = "a";
                        convrt1 = Convert.ToDouble(Form1.self.AConversion.Text);//convertion factor
                    }

                    //-------------------------------------------Converstion----------------------------------------------------------------

                    double convrt2 = thou / convrt1;
                    double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                    int convrt4 = Convert.ToInt32(convrt2 / convrt3);

                    Form1.self.buttonEnabled.Text = "1";

                    if (Form1.self.serialPort1.IsOpen == true)
                    {
                        Form1.self.serialPort1.Write(string.Format("{0}\r", cpeed));
                        Form1.self.serialPort1.Write(rotate + axis + "\r");
                        Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}", convrt4 + "\r")));
                    }

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(10).Wait();
                    }

                    removeblock();
                }
                else if (notclear == "" || notclear.StartsWith("N"))
                {
                    Form1.self.RGcodeRTB.Text = "No code!";
                }
            }
            else if (notclear == "" || notclear.StartsWith("N"))
            {
                Form1.self.RGcodeRTB.Text = "No code!";
            }

        }
        //-----------------------------------------------block 2--------------------------------------------------------------
        public void removeblock()
        {
            while (true)
            {
                string notclear = Form1.self.RGcodeRTB.Text;

                if (notclear.StartsWith("{"))
                {

                    int numOfLines = 2;
                    var lines = Form1.self.RGcodeRTB.Lines;
                    var newLines = lines.Skip(numOfLines);

                    Form1.self.RGcodeRTB.Lines = newLines.ToArray();//remove old lines

                    //resetbuttons();
                    break;
                }
                else
                {
                    break;
                }
            }
            Readcode();
        }
        //---------------------------------------------------Export Gcode to Cycle--------------------------------------------
        int times = 0;

        public void ExportGcode()
        {

            Form1.self.XnegOrder.Text = "0";
            Form1.self.XposOrder.Text = "0";
            Form1.self.YnegOrder.Text = "0";
            Form1.self.YposOrder.Text = "0";
            Form1.self.ZnegOrder.Text = "0";
            Form1.self.ZposOrder.Text = "0";
            Form1.self.AnegOrder.Text = "0";
            Form1.self.AposOrder.Text = "0";

            for (int i = 0; i < 9; i++)
            {
                string notclear = Form1.self.RGcodeRTB.Text;

                if (notclear.StartsWith("{") && notclear != "")
                {
                    string[] lines = Form1.self.RGcodeRTB.Lines;

                    string first = lines[1].Split(' ').Skip(0).FirstOrDefault(); // IPM
                    string sencond = lines[1].Split(' ').Skip(1).FirstOrDefault(); // Axis
                    string third = lines[1].Split(' ').Skip(2).FirstOrDefault(); // feed distance               

                    //-------------------------------rotation and axis-----------------------------------------------------------------------                
                    int cpeed = Convert.ToInt32(first);
                    string rot = Convert.ToString(sencond);//zero over ----- one long-----------                
                    double thou = Convert.ToDouble(third);


                    times++;

                    if (rot == "-x") { Form1.self.XnegOrder.Text = Convert.ToString(times); }
                    if (rot == "+x") { Form1.self.XposOrder.Text = Convert.ToString(times); }
                    if (rot == "-y") { Form1.self.YnegOrder.Text = Convert.ToString(times); }
                    if (rot == "+y") { Form1.self.YposOrder.Text = Convert.ToString(times); }
                    if (rot == "-z") { Form1.self.ZnegOrder.Text = Convert.ToString(times); }
                    if (rot == "+z") { Form1.self.ZposOrder.Text = Convert.ToString(times); }
                    if (rot == "-a") { Form1.self.AnegOrder.Text = Convert.ToString(times); }
                    if (rot == "+a") { Form1.self.AposOrder.Text = Convert.ToString(times); }

                    if (rot == "-x")
                    {
                        Form1.self.XnegTB.Text = Convert.ToString(thou);
                        Form1.self.XnegIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "+x")
                    {
                        Form1.self.XposTB.Text = Convert.ToString(thou);
                        Form1.self.XposIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "-y")
                    {
                        Form1.self.YnegTB.Text = Convert.ToString(thou);
                        Form1.self.YnegIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "+y")
                    {
                        Form1.self.YposTB.Text = Convert.ToString(thou);
                        Form1.self.YposIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "-z")
                    {
                        Form1.self.ZnegTB.Text = Convert.ToString(thou);
                        Form1.self.ZnegIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "+z")
                    {
                        Form1.self.ZposTB.Text = Convert.ToString(thou);
                        Form1.self.ZposIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "-a")
                    {
                        Form1.self.AnegTB.Text = Convert.ToString(thou);
                        Form1.self.AnegIPM.Text = Convert.ToString(cpeed);
                    }
                    if (rot == "+a")
                    {
                        Form1.self.AposTB.Text = Convert.ToString(thou);
                        Form1.self.AposIPM.Text = Convert.ToString(cpeed);
                    }

                    if (notclear.StartsWith("{"))
                    {

                        int numOfLines = 2;
                        var nextlines = Form1.self.RGcodeRTB.Lines;
                        var newLines = nextlines.Skip(numOfLines);
                        Form1.self.RGcodeRTB.Lines = newLines.ToArray();//remove old lines
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public void block()
        {
            while (true)
            {
                string notclear = Form1.self.RGcodeRTB.Text;

                if (notclear.StartsWith("{"))
                {

                    int numOfLines = 2;
                    var nextlines = Form1.self.RGcodeRTB.Lines;
                    var newLines = nextlines.Skip(numOfLines);
                    Form1.self.RGcodeRTB.Lines = newLines.ToArray();//remove old lines

                    break;
                }
                else
                {
                    break;
                }
            }
            ExportGcode();
        }
    }
}

