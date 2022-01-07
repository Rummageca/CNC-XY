using System;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Rummage_CNC
{

    class Steppers
    {

        public void turn(object sender, EventArgs e)//-------------------------------- X CW Axis----------------------------------------------------
        {

            string rotation = "No data";
            string setspeed = "";
            int steps = 0;

            //--------------------------constants-------------------------------------------------------------------------------

            string cpeed = "";
            double thou = 0;

            double convrt1 = 0;
            double convrt2;
            double convrt3;
            double convrt4;

            //---------------------------------------------------------X axis ---------------------------------------------------

            if ((sender as Button).Text == "- X")
            {
                rotation = "cwx";
                thou = Convert.ToDouble(Form1.self.XnegTB.Text);   // move distance        
                convrt1 = Convert.ToDouble(Form1.self.XConversion.Text); //encoder converstion               
                cpeed = Convert.ToString(Form1.self.XnegIPM.Text);

            }
            //---------------------------------------------------------x axis ---------------------------------------------------
            if ((sender as Button).Text == "+ X")
            {
                rotation = "ccwx";
                thou = Convert.ToDouble(Form1.self.XposTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);
                cpeed = Convert.ToString(Form1.self.XposIPM.Text);


            }
            //---------------------------------------------------------Y axis ---------------------------------------------------
            if ((sender as Button).Text == "- Y")
            {
                rotation = "cwy";
                thou = Convert.ToDouble(Form1.self.YnegTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.YConversion.Text);
                cpeed = Convert.ToString(Form1.self.YnegIPM.Text);

            }
            //---------------------------------------------------------Y axis ---------------------------------------------------
            if ((sender as Button).Text == "+ Y")
            {
                rotation = "ccwy";
                thou = Convert.ToDouble(Form1.self.YposTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.YConversion.Text);
                cpeed = Convert.ToString(Form1.self.YposIPM.Text);

            }
            //---------------------------------------------------------Z axis ---------------------------------------------------
            if ((sender as Button).Text == "- Z")
            {
                rotation = "cwz";
                thou = Convert.ToDouble(Form1.self.ZnegTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);
                cpeed = Convert.ToString(Form1.self.ZnegIPM.Text);

            }
            //---------------------------------------------------------Z axis ---------------------------------------------------
            if ((sender as Button).Text == "+ Z")
            {
                rotation = "ccwz";
                thou = Convert.ToDouble(Form1.self.ZposTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);
                cpeed = Convert.ToString(Form1.self.ZposIPM.Text);
            }
            //---------------------------------------------------------A axis ---------------------------------------------------
            if ((sender as Button).Text == "- A")
            {
                rotation = "cwa";
                thou = Convert.ToDouble(Form1.self.AnegTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.AConversion.Text);
                cpeed = Convert.ToString(Form1.self.AnegIPM.Text);
            }
            //---------------------------------------------------------A axis ---------------------------------------------------
            if ((sender as Button).Text == "+ A")
            {
                rotation = "ccwa";
                thou = Convert.ToDouble(Form1.self.AposTB.Text);
                convrt1 = Convert.ToDouble(Form1.self.AConversion.Text);
                cpeed = Convert.ToString(Form1.self.AposIPM.Text);
            }

            //----------------------------------------------------work the values-------------------------------------------------------------------------

            convrt2 = thou / convrt1;
            convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion factor   ---    
            convrt4 = convrt2 / convrt3;

            setspeed = cpeed;
            steps = Convert.ToInt32(convrt4);

            if (Form1.self.serialPort1.IsOpen == false)
            {
                Form1.self.serialPort1.Open();
            }

            Form1.self.buttonEnabled.Text = "1";

            if (Form1.self.serialPort1.IsOpen == true)
            {
                Form1.self.serialPort1.Write(string.Format("{0}\r", setspeed));
                Form1.self.serialPort1.Write(rotation + "\r");
                Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", steps)));

                while (Form1.self.buttonEnabled.Text == "1")
                {
                    Task.Delay(5).Wait();
                }

            }

            Form1.self.DiagnosticsRTB.Text += "data sent" + Environment.NewLine;
        }

        //-----------------------------------------------Move Motors to Zero----------------------------------------------------------
        public void motorMoves(object sender, EventArgs e)
        {
            Form1.self.ButtonDisabled();
            string rotation;
            double steps;

            double thoux = Convert.ToDouble(Form1.self.inchx.Text);
            double thouy = Convert.ToDouble(Form1.self.inchy.Text);
            double thouz = Convert.ToDouble(Form1.self.inchz.Text);
            double thoua = Convert.ToDouble(Form1.self.incha.Text);

            //------------------Home X-------------------------------
            if (sender as Button == Form1.self.homeX)
            {

                if (thoux < 0)
                {
                    rotation = "ccw";
                    double invertthoux = thoux * -1;
                    thoux = invertthoux;
                }
                else
                {
                    rotation = "cw";
                }

                double convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);
                double convrt2 = thoux / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                double convrt4 = convrt2 / convrt3;
                steps = Convert.ToInt32(convrt4);

                if (Form1.self.serialPort1.IsOpen == false)
                {
                    Form1.self.serialPort1.Open();
                }

                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("20\r");
                    Form1.self.serialPort1.Write(rotation + "x\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", steps)));

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(5).Wait();
                    }

                }

            }
            //------------------Home Y-------------------------------
            if (sender as Button == Form1.self.homeY)
            {

                if (thouy < 0)
                {
                    rotation = "ccw";
                    double invertthouy = thouy * -1;
                    thouy = invertthouy;
                }
                else
                {
                    rotation = "cw";
                }

                double convrt1 = Convert.ToDouble(Form1.self.YConversion.Text);
                double convrt2 = thouy / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                double convrt4 = convrt2 / convrt3;
                steps = Convert.ToInt32(convrt4);

                if (Form1.self.serialPort1.IsOpen == false)
                {
                    Form1.self.serialPort1.Open();
                }

                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("20\r");
                    Form1.self.serialPort1.Write(rotation + "y\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", steps)));

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(5).Wait();
                    }
                }

            }
            //------------------Home Z-------------------------------
            if (sender as Button == Form1.self.homeZ)
            {

                if (thouz < 0)
                {
                    rotation = "ccw";
                    double invertthouz = thouz * -1;
                    thouz = invertthouz;
                }
                else
                {
                    rotation = "cw";
                }

                double convrt1 = Convert.ToDouble(Form1.self.ZConversion.Text);
                double convrt2 = thouz / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                double convrt4 = convrt2 / convrt3;
                steps = Convert.ToInt32(convrt4);

                if (Form1.self.serialPort1.IsOpen == false)
                {
                    Form1.self.serialPort1.Open();
                }

                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("20\r");
                    Form1.self.serialPort1.Write(rotation + "z\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", steps)));

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(5).Wait();
                    }
                }
            }
            //------------------Home A-------------------------------
            if (sender as Button == Form1.self.homeA)
            {
                if (thoua < 0)
                {
                    rotation = "ccw";
                    double invertthoua = thoua * -1;
                    thoua = invertthoua;
                }
                else
                {
                    rotation = "cw";
                }

                double convrt1 = Convert.ToDouble(Form1.self.AConversion.Text);
                double convrt2 = thoua / convrt1;
                double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);//------- conversion 2.5x-----------
                double convrt4 = convrt2 / convrt3;
                steps = Convert.ToInt32(convrt4);

                if (Form1.self.serialPort1.IsOpen == false)
                {
                    Form1.self.serialPort1.Open();
                }

                Form1.self.buttonEnabled.Text = "1";

                if (Form1.self.serialPort1.IsOpen == true)
                {
                    Form1.self.serialPort1.Write("20\r");
                    Form1.self.serialPort1.Write(rotation + "a\r");
                    Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", steps)));

                    while (Form1.self.buttonEnabled.Text == "1")
                    {
                        Task.Delay(5).Wait();
                    }

                }

            }
            Form1.self.ButtonEnabled();

        }
        //--------------------------------------------------Manual axis moves-------------------------------------------------------------

        public void manualMotorMoves(object sender, EventArgs e)
        {
            Form1.self.ButtonDisabled();
            string rotation = "";
            double manualIPM = Convert.ToDouble(Form1.self.manualIPM.Text);


            if (sender as Button == Form1.self.manualXn) { rotation = "cw" + "x"; Form1.self.manualXn.Enabled = true; }
            if (sender as Button == Form1.self.manualXp) { rotation = "ccw" + "x"; Form1.self.manualXp.Enabled = true; }
            if (sender as Button == Form1.self.manualYn) { rotation = "cw" + "y"; Form1.self.manualYn.Enabled = true; }
            if (sender as Button == Form1.self.manualYp) { rotation = "ccw" + "y"; Form1.self.manualYp.Enabled = true; }
            if (sender as Button == Form1.self.manualZn) { rotation = "cw" + "z"; Form1.self.manualZn.Enabled = true; }
            if (sender as Button == Form1.self.manualZp) { rotation = "ccw" + "z"; Form1.self.manualZp.Enabled = true; }
            if (sender as Button == Form1.self.manualAn) { rotation = "cw" + "a"; Form1.self.manualAn.Enabled = true; }
            if (sender as Button == Form1.self.manualAp) { rotation = "ccw" + "a"; Form1.self.manualAp.Enabled = true; }

            if (Form1.self.serialPort1.IsOpen == false)
            {
                Form1.self.serialPort1.Open();
            }

            Form1.self.buttonEnabled.Text = "1";

            if (Form1.self.serialPort1.IsOpen == true)
            {
                Form1.self.serialPort1.Write(manualIPM + "\r");
                Form1.self.serialPort1.Write(rotation + "\r");
                Form1.self.serialPort1.Write("0\r");
                Form1.self.serialPort1.Write("Manual On\r");

                while (Form1.self.buttonEnabled.Text == "1")
                {
                    Task.Delay(5).Wait();
                }

            }
            Form1.self.ButtonEnabled();
        }
    }

}

