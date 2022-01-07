using System;
using System.Windows.Forms;

namespace Rummage_CNC
{
    class Smartcontrol
    {
        public int count;
        public int loopcount;

        public void looporder(object sender, MouseEventArgs e)
        {
            double loopnum = Convert.ToDouble((sender as Button).Text);

            if (e.Button == MouseButtons.Left)
            {
                double newloop = loopnum + 1;
                (sender as Button).Text = Convert.ToString(newloop);
                if (loopnum >= 8)
                {
                    loopnum = 0;
                    (sender as Button).Text = Convert.ToString(loopnum);
                }

            }

            if (e.Button == MouseButtons.Right)
            {
                if (loopnum >= 0 && loopnum <= 8)
                {
                    double newloop = loopnum - 1;
                    (sender as Button).Text = Convert.ToString(newloop);
                    if (loopnum <= 0)
                    {
                        loopnum = 8;
                        (sender as Button).Text = Convert.ToString(loopnum);
                    }
                }
            }

        }

        public void loop(object sender, EventArgs e)
        {
            count = 1;
            loopcount = 1;
            Form1.self.ButtonDisabled();
            Form1.self.EStopWasClicked = false;
            Form1.self.CurrentCycle.Text = "0";

            smartloop();
        }
        public void smartloop()
        {
            int execsequence = 9;

            string[] runorder = new string[execsequence];

            int NumberOfLines = 9;//-----------------------------How many lines should be loaded?---------------------------            
            string[] ListLines = new string[NumberOfLines];//------Make our array for each line------------------------------                                      

            ListLines[1] = Form1.self.XnegOrder.Text;
            ListLines[2] = Form1.self.XposOrder.Text;
            ListLines[3] = Form1.self.YnegOrder.Text;
            ListLines[4] = Form1.self.YposOrder.Text;

            ListLines[5] = Form1.self.ZnegOrder.Text;
            ListLines[6] = Form1.self.ZposOrder.Text;
            ListLines[7] = Form1.self.AnegOrder.Text;
            ListLines[8] = Form1.self.AposOrder.Text;

            //--------------------------------------------axis sequence placement------------------------------------ 
            if (ListLines[1] != "0") { runorder[Convert.ToInt32(ListLines[1])] = "-X"; }
            if (ListLines[2] != "0") { runorder[Convert.ToInt32(ListLines[2])] = "+X"; }
            if (ListLines[3] != "0") { runorder[Convert.ToInt32(ListLines[3])] = "-Y"; }
            if (ListLines[4] != "0") { runorder[Convert.ToInt32(ListLines[4])] = "+Y"; }
            if (ListLines[5] != "0") { runorder[Convert.ToInt32(ListLines[5])] = "-Z"; }
            if (ListLines[6] != "0") { runorder[Convert.ToInt32(ListLines[6])] = "+Z"; }
            if (ListLines[7] != "0") { runorder[Convert.ToInt32(ListLines[7])] = "-A"; }
            if (ListLines[8] != "0") { runorder[Convert.ToInt32(ListLines[8])] = "+A"; }

            //--------------------------------------------axis -X ------------------------------------------------------
            if (count == 1 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[1] == "-X") { Form1.self.XnegMove.PerformClick(); count = 2; }
                if (runorder[1] == "+X") { Form1.self.XposMove.PerformClick(); count = 2; }
                if (runorder[1] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 2; }
                if (runorder[1] == "+Y") { Form1.self.YposMove.PerformClick(); count = 2; }
                if (runorder[1] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 2; }
                if (runorder[1] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 2; }
                if (runorder[1] == "-A") { Form1.self.AnegMove.PerformClick(); count = 2; }
                if (runorder[1] == "+A") { Form1.self.AposMove.PerformClick(); count = 2; }
            }

            if (count == 2 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[2] == "-X") { Form1.self.XnegMove.PerformClick(); count = 3; }
                if (runorder[2] == "+X") { Form1.self.XposMove.PerformClick(); count = 3; }
                if (runorder[2] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 3; }
                if (runorder[2] == "+Y") { Form1.self.YposMove.PerformClick(); count = 3; }
                if (runorder[2] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 3; }
                if (runorder[2] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 3; }
                if (runorder[2] == "-A") { Form1.self.AnegMove.PerformClick(); count = 3; }
                if (runorder[2] == "+A") { Form1.self.AposMove.PerformClick(); count = 3; }
            }

            if (count == 3 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[3] == "-X") { Form1.self.XnegMove.PerformClick(); count = 4; }
                if (runorder[3] == "+X") { Form1.self.XposMove.PerformClick(); count = 4; }
                if (runorder[3] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 4; }
                if (runorder[3] == "+Y") { Form1.self.YposMove.PerformClick(); count = 4; }
                if (runorder[3] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 4; }
                if (runorder[3] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 4; }
                if (runorder[3] == "-A") { Form1.self.AnegMove.PerformClick(); count = 4; }
                if (runorder[3] == "+A") { Form1.self.AposMove.PerformClick(); count = 4; }
            }

            if (count == 4 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[4] == "-X") { Form1.self.XnegMove.PerformClick(); count = 5; }
                if (runorder[4] == "+X") { Form1.self.XposMove.PerformClick(); count = 5; }
                if (runorder[4] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 5; }
                if (runorder[4] == "+Y") { Form1.self.YposMove.PerformClick(); count = 5; }
                if (runorder[4] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 5; }
                if (runorder[4] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 5; }
                if (runorder[4] == "-A") { Form1.self.AnegMove.PerformClick(); count = 5; }
                if (runorder[4] == "+A") { Form1.self.AposMove.PerformClick(); count = 5; }
            }

            if (count == 5 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[5] == "-X") { Form1.self.XnegMove.PerformClick(); count = 6; }
                if (runorder[5] == "+X") { Form1.self.XposMove.PerformClick(); count = 6; }
                if (runorder[5] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 6; }
                if (runorder[5] == "+Y") { Form1.self.YposMove.PerformClick(); count = 6; }
                if (runorder[5] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 6; }
                if (runorder[5] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 6; }
                if (runorder[5] == "-A") { Form1.self.AnegMove.PerformClick(); count = 6; }
                if (runorder[5] == "+A") { Form1.self.AposMove.PerformClick(); count = 6; }
            }
            if (count == 6 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[6] == "-X") { Form1.self.XnegMove.PerformClick(); count = 7; }
                if (runorder[6] == "+X") { Form1.self.XposMove.PerformClick(); count = 7; }
                if (runorder[6] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 7; }
                if (runorder[6] == "+Y") { Form1.self.YposMove.PerformClick(); count = 7; }
                if (runorder[6] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 7; }
                if (runorder[6] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 7; }
                if (runorder[6] == "-A") { Form1.self.AnegMove.PerformClick(); count = 7; }
                if (runorder[6] == "+A") { Form1.self.AposMove.PerformClick(); count = 7; }
            }
            if (count == 7 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[7] == "-X") { Form1.self.XnegMove.PerformClick(); count = 8; }
                if (runorder[7] == "+X") { Form1.self.XposMove.PerformClick(); count = 8; }
                if (runorder[7] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 8; }
                if (runorder[7] == "+Y") { Form1.self.YposMove.PerformClick(); count = 8; }
                if (runorder[7] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 8; }
                if (runorder[7] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 8; }
                if (runorder[7] == "-A") { Form1.self.AnegMove.PerformClick(); count = 8; }
                if (runorder[7] == "+A") { Form1.self.AposMove.PerformClick(); count = 8; }
            }
            if (count == 8 && Form1.self.buttonEnabled.Text == "0")
            {
                if (runorder[8] == "-X") { Form1.self.XnegMove.PerformClick(); count = 9; }
                if (runorder[8] == "+X") { Form1.self.XposMove.PerformClick(); count = 9; }
                if (runorder[8] == "-Y") { Form1.self.YnegMove.PerformClick(); count = 9; }
                if (runorder[8] == "+Y") { Form1.self.YposMove.PerformClick(); count = 9; }
                if (runorder[8] == "-Z") { Form1.self.ZnegMove.PerformClick(); count = 9; }
                if (runorder[8] == "+Z") { Form1.self.ZposMove.PerformClick(); count = 9; }
                if (runorder[8] == "-A") { Form1.self.AnegMove.PerformClick(); count = 9; }
                if (runorder[8] == "+A") { Form1.self.AposMove.PerformClick(); count = 9; }
            }

            int times = Convert.ToInt32(Form1.self.CycleCount.Text); //  should be zerro at this point 0


            if (loopcount < times && Form1.self.EStopWasClicked == false)
            {
                Form1.self.CurrentCycle.Text = Convert.ToString(loopcount + 1);
                loopcount++;
                count = 1;
                smartloop();
            }

            if (loopcount == times || Form1.self.EStopWasClicked == true)
            {
                Form1.self.EStopWasClicked = false;
                Form1.self.ButtonEnabled();
            }

        }
    }
}
