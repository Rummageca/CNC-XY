using System;

namespace Rummage_CNC
{
    class Tapers
    {
        public void setTaper(object sender, EventArgs e)
        {

            Form1.self.RGcodeRTB.Text = "";

            double totSteps = Convert.ToDouble(Form1.self.ToRemove.Text);

            double taperlength = Convert.ToDouble(Form1.self.TaperLength.Text);
            double taperRatio = Convert.ToDouble(Form1.self.Ratio.Text);
            double cutSpeed = Convert.ToDouble(Form1.self.IPMtaper.Text);
            double depthcut = Convert.ToDouble(Form1.self.DOCtaper.Text);

            double taperdivide = taperlength / taperRatio;

            double MoveShort = taperdivide / 2; //shortmove
            double MoveLong = (MoveShort * taperRatio) * 2; //long move        

            int passes = Convert.ToInt32(totSteps / depthcut);

            string warn = "";


            if (cutSpeed > 18)
            {
                warn = "DANGER!! Return cut speed TO FAST!!";
            }
            if (cutSpeed > 15 && cutSpeed <= 18)
            {
                warn = "WARNING!! Return cut speed FAST";
            }

            for (int i = 0; i < passes; i++)
            {
                if (Form1.self.LongAxis.Text == "X Axis" && Form1.self.Slope.Text == "Out")
                {
                    // Form1.self.richTextBox3.Text = "";

                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -x " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " +z " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                    Form1.self.RGcodeRTB.Text += "{------" + warn + "---------home}" + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +x " + (string.Format("{0:0.0000}", taperlength) + "\n");
                    Form1.self.RGcodeRTB.Text += "{-------------- home  ---- -" + depthcut + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " -z " + (string.Format("{0:0.0000}", MoveShort + depthcut) + "\n");
                }

                if (Form1.self.LongAxis.Text == "X Axis" && Form1.self.Slope.Text == "In")
                {
                    // Form1.self.richTextBox3.Text = "";

                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -x " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -z " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                    Form1.self.RGcodeRTB.Text += "{------" + warn + "---------home}" + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +x " + (string.Format("{0:0.0000}", taperlength) + "\n");
                    Form1.self.RGcodeRTB.Text += "{-------------- home ---- +" + depthcut + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +z " + (string.Format("{0:0.0000}", MoveShort + depthcut) + "\n");

                }

                if (Form1.self.LongAxis.Text == "Z Axis" && Form1.self.Slope.Text == "Out")
                {

                    // Form1.self.richTextBox3.Text = "";

                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -z " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " +x " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                    Form1.self.RGcodeRTB.Text += "{------" + warn + "---------home}" + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +z " + (string.Format("{0:0.0000}", taperlength) + "\n");
                    Form1.self.RGcodeRTB.Text += "{-------------- home ---- -" + depthcut + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " -x " + (string.Format("{0:0.0000}", MoveShort + depthcut) + "\n");

                }
                if (Form1.self.LongAxis.Text == "Z Axis" && Form1.self.Slope.Text == "In")
                {
                    //Form1.self.richTextBox3.Text = "";

                    Form1.self.RGcodeRTB.Text += "{---------------Taper Home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -z " + (string.Format("{0:0.0000}", MoveLong) + " T " + taperRatio + "\n");
                    Form1.self.RGcodeRTB.Text += "{---------------Taper home}" + "\n";
                    Form1.self.RGcodeRTB.Text += string.Format("{0:00}", cutSpeed) + " -x " + (string.Format("{0:0.0000}", MoveShort) + "\n");

                    Form1.self.RGcodeRTB.Text += "{------" + warn + "---------home}" + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +z " + (string.Format("{0:0.0000}", taperlength) + "\n");
                    Form1.self.RGcodeRTB.Text += "{-------------- home ---- +" + depthcut + "\n";
                    Form1.self.RGcodeRTB.Text += (cutSpeed * 2) + " +x " + (string.Format("{0:0.0000}", MoveShort + depthcut) + "\n");

                }

            }
        }
        /* 
          public void setTaper(object sender, EventArgs e)
          {
              double taperlength = Convert.ToDouble(Form1.self.TaperLength.Text);
              double taperRatio = Convert.ToDouble(Form1.self.Ratio.Text);            
              double cutSpeed = Convert.ToDouble(Form1.self.IPMtaper.Text);
              double depthcut = Convert.ToDouble(Form1.self.DOCtaper.Text);

             double taperdivide = taperlength / taperRatio;
             double Moves = taperdivide / depthcut;
             double MoveLong = taperlength / Moves; //long move        
             double MoveShort = (taperdivide / Moves) / 2;




              if (Form1.self.LongAxis.Text == "X Axis" && Form1.self.Slope.Text == "Out")
              {             

                  Form1.self.richTextBox3.Text = "";

                  for (int i=0; i < Moves; i++)
                  {
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -x " + string.Format("{0:00.0000}\r", MoveLong);
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " +y " + string.Format("{0:00.0000}\r", MoveShort);
                  }
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +x " + string.Format("{0:00.0000}\r", taperlength);
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " -y " + string.Format("{0:00.0000}\r", taperdivide / 2);

                  if (Form1.self.checkBox1.Checked)
                  {
                      Form1.self.richTextBox3.Text += "{------Set next Cut}" + "\n";
                      Form1.self.richTextBox3.Text += "33" + " -y " + "00.0004";                    
                  }
              }
              if (Form1.self.LongAxis.Text == "X Axis" && Form1.self.Slope.Text == "In")
              {

                  Form1.self.richTextBox3.Text = "";

                  for (int i = 0; i < Moves; i++)
                  {
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -x " + string.Format("{0:00.0000}\r", MoveLong);
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -y " + string.Format("{0:00.0000}\r", MoveShort);
                  }
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +x " + string.Format("{0:00.0000}\r", taperlength);
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +y " + string.Format("{0:00.0000}\r", taperdivide / 2);

                  if (Form1.self.checkBox1.Checked)
                  {
                      Form1.self.richTextBox3.Text += "{------Set next Cut}" + "\n";
                      Form1.self.richTextBox3.Text += "33" + " +y " + "00.0004";                   

                  }
              }


              if (Form1.self.LongAxis.Text == "Y Axis" && Form1.self.Slope.Text == "Out")
              {

                  Form1.self.richTextBox3.Text = "";

                  for (int i = 0; i < Moves; i++)
                  {
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -y " + string.Format("{0:00.0000}\r", MoveLong);
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " +x " + string.Format("{0:00.0000}\r", MoveShort);
                  }
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +y " + string.Format("{0:00.0000}\r", taperlength);
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " -x " + string.Format("{0:00.0000}\r", taperdivide / 2);

                  if (Form1.self.checkBox1.Checked)
                  {
                      Form1.self.richTextBox3.Text += "{------Set next Cut}" + "\n";
                      Form1.self.richTextBox3.Text += "33" + " -x " + "00.0004";

                  }
              }

              if (Form1.self.LongAxis.Text == "Y Axis" && Form1.self.Slope.Text == "In")
              {

                  Form1.self.richTextBox3.Text = "";

                  for (int i = 0; i < Moves; i++)
                  {
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -y " + string.Format("{0:00.0000}\r", MoveLong);
                      Form1.self.richTextBox3.Text += "{taper}" + "\n";
                      Form1.self.richTextBox3.Text += string.Format("{0:00}", cutSpeed) + " -x " + string.Format("{0:00.0000}\r", MoveShort);
                  }
                  Form1.self.richTextBox3.Text += "{---------------Taper Home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +y " + string.Format("{0:00.0000}\r", taperlength);
                  Form1.self.richTextBox3.Text += "{---------------Taper home}" + "\n";
                  Form1.self.richTextBox3.Text += "33" + " +x " + string.Format("{0:00.0000}\r", taperdivide / 2);

                  if (Form1.self.checkBox1.Checked)
                  {
                      Form1.self.richTextBox3.Text += "{------Set next Cut}" + "\n";
                      Form1.self.richTextBox3.Text += "33" + " +x " + "00.0004";
                  }
              }

          }                 
      }*/

    }

}