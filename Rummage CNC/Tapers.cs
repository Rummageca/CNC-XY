using System;

namespace Rummage_CNC
{
    class Tapers
    {
        public void setTaper(object sender, EventArgs e)
        {

            if (Form1.self.ExportsClearCB.Checked == true)
            {
                Form1.self.RGcodeRTB.Text = "";
            }

            double taperlength = Convert.ToDouble(Form1.self.TaperLength.Text);
            double taperRatio = Convert.ToDouble(Form1.self.Ratio.Text);
            double cutSpeed = Convert.ToDouble(Form1.self.IPMtaper.Text);
            double returnSpeed = Convert.ToDouble(Form1.self.ReturnIPMTaper.Text);
            double pullBack = Convert.ToDouble(Form1.self.TaperPullBack.Text);
            double depthcut = Convert.ToDouble(Form1.self.DOCtaper.Text);

            double taperdivide = taperlength / taperRatio;

            double MoveShort = 0;
            double MoveLong = 0;

            if (Form1.self.TaperIsRadius.Checked == true)
            {
                MoveShort = taperdivide / 2; //shortmove
                MoveLong = (MoveShort * taperRatio) * 2;
                taperRatio = taperRatio * 2;
            }
            else
            {
                MoveShort = taperdivide;
                MoveLong = MoveShort * taperRatio;
            }

            string LongSide = Form1.self.LongAxis.Text;
            string ShortSide = Form1.self.ShortAxis.Text;

            if (LongSide == ShortSide)
            {
                Form1.self.RGcodeRTB.Text += "Long Axis And short Axis the same\n";
                return;
            }

            if (ShortSide.StartsWith("X")) { ShortSide = "x"; }
            if (ShortSide.StartsWith("Y")) { ShortSide = "y"; }
            if (ShortSide.StartsWith("Z")) { ShortSide = "z"; }

            if (LongSide.StartsWith("X")) { LongSide = "x"; }
            if (LongSide.StartsWith("Y")) { LongSide = "y"; }
            if (LongSide.StartsWith("Z")) { LongSide = "z"; }

            string warn = "";

            if (cutSpeed > 28)
            {
                warn = "DANGER!! Cut speed TO FAST!!";
            }
            if (cutSpeed > 15 && cutSpeed <= 28)
            {
                warn = "WARNING!! Cut speed Very FAST";
            }


            if (Form1.self.Slope.Text == "Out")
            {
                // Form1.self.richTextBox3.Text = "";

                Form1.self.RGcodeRTB.Text += "{--------Taper Out--------}" + warn + "\n";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -" + LongSide + " " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                Form1.self.RGcodeRTB.Text += "{-------Second Axis--------}" + "\n";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " +" + ShortSide + " " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                if (Form1.self.checkBoxTaperReturn.Checked == true)
                {
                    Form1.self.RGcodeRTB.Text += "{----Zero home-----}" + "\n";
                    Form1.self.RGcodeRTB.Text += "Home " + LongSide + "\r";
                    //Form1.self.RGcodeRTB.Text += returnSpeed + " +" + LongSide + " " + (string.Format("{0:0.0000}", taperlength) + "\n");
                    Form1.self.RGcodeRTB.Text += "{-----Move Up-----}" + "\n";
                    Form1.self.RGcodeRTB.Text += returnSpeed + " -" + ShortSide + " " + (string.Format("{0:0.0000}", MoveShort + depthcut) + "\n");
                }
            }

            if (Form1.self.Slope.Text == "In")
            {
                // Form1.self.richTextBox3.Text = "";

                Form1.self.RGcodeRTB.Text += "{--------Taper Out--------}" + warn + "\n";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -" + LongSide + " " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                Form1.self.RGcodeRTB.Text += "{-------Second Axis--------}" + "\n";
                Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -" + ShortSide + " " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                if (Form1.self.checkBoxTaperReturn.Checked == true)
                {
                    Form1.self.RGcodeRTB.Text += "{-----Pull Back-----}" + "\n";
                    Form1.self.RGcodeRTB.Text += returnSpeed + " +" + ShortSide + " " + (string.Format("{0:0.0000}", MoveShort + pullBack) + "\n");
                    Form1.self.RGcodeRTB.Text += "{---" + warn + "-Zero home-----}" + "\n";
                    Form1.self.RGcodeRTB.Text += "Home " + LongSide + "\r";
                    Form1.self.RGcodeRTB.Text += "{-----Move Up-----}" + "\n";
                    Form1.self.RGcodeRTB.Text += returnSpeed + " -" + ShortSide + " " + (string.Format("{0:0.0000}", depthcut + pullBack) + "\n");
                }
            }
        }
    }
}