using System;
using System.Windows.Forms;

namespace Rummage_CNC
{
    //just testing notes-----------------------------------------------------
    //just testing notes-----------------------------------------------------
    //just testing notes-----------------------------------------------------
    //just testing notes-----------------------------------------------------
    //just testing notes-----------------------------------------------------

    class Radius
    {
        public void radius(object sender, EventArgs e)
        {
            string warning = "";
            string warning2 = "";

            double radius = Convert.ToDouble(Form1.self.CircleRadius.Text);
            double degree = Convert.ToDouble(Form1.self.DegreeInc.Text);
            double degreeconst = Convert.ToDouble(Form1.self.DegreeInc.Text);
            double feed = Convert.ToDouble(Form1.self.DegreeIPM.Text);

            double backlashx = Convert.ToDouble(Form1.self.BacklashX.Text);
            double backlashy = Convert.ToDouble(Form1.self.BacklashY.Text);

            double fromradians;

            //   double fromradians1 = Math.PI * (degree + 95) / 180;

            //double X = radius * Math.Sin(fromradians);

            double xold = 0;
            double yold = 0;


            double checkmove = 0;
            //  double Xconst = radius * Math.Sin(fromradians);

            Form1.self.RGcodeRTB.Text = "";

            //-------------------------------------------------Outside corner-------------------------------------------------------------

            // needs testing


            if (Form1.self.checkBox1.Checked == true)
            {

                for (double i = 90; i > 0; i = (i - degreeconst))
                {
                    fromradians = Math.PI * (90 - degree) / 180;

                    double Y = radius * Math.Sin(fromradians);
                    double X = radius * Math.Cos(fromradians);

                    double Ynew = radius - Y;

                    if (yold < Ynew)
                    {
                        checkmove = (Ynew - yold);
                    }

                    if (yold > Ynew)
                    {
                        checkmove = (yold - Ynew);
                    }


                    if (checkmove > 0.01)
                    {
                        warning = (string.Format("{0:0.0000} ", checkmove)) + " WARNING! Cut over 0.010";
                    }
                    double outX = radius - X;

                    //----------------------backlash off----------------------------
                    if (Form1.self.checkBox5.Checked == false)
                    {
                        Form1.self.RGcodeRTB.Text += "{--- " + (0 + degree) + " Total Degrees -- " + warning + " --}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -x " + (string.Format("{0:0.0000}", checkmove) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{---------" + warning2 + "-------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -z " + (string.Format("{0:0.0000}", outX) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{----------------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " +z " + (string.Format("{0:0.0000}", outX) + " R\n");
                    }
                    yold = Ynew;
                    degree += degreeconst;
                }


            }
            // ----------------------------------------------half circle  Face concave-------------------------------------------------------------
            //-- needs testing

            if (Form1.self.checkBox2.Checked == true)
            {

                for (double i = 270; i < 360; i = (i + degreeconst))
                {
                    fromradians = Math.PI * (270 + degree) / 180;
                    double Y = radius * Math.Cos(fromradians);
                    double X = radius * Math.Sin(fromradians);

                    checkmove = (yold - Y);

                    if (-checkmove > 0.01)
                    {
                        warning = (string.Format("{0:0.0000} ", checkmove)) + " WARNING! Cut over 0.010";
                    }

                    //----------------------backlash off----------------------------
                    if (Form1.self.checkBox5.Checked == false)
                    {
                        Form1.self.RGcodeRTB.Text += "{--- " + (90 + degree) + " Total Degrees --" + warning + "--}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -x " + (string.Format("{0:0.0000}", -checkmove) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{---------" + warning2 + "-------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " +z " + (string.Format("{0:0.0000}", -X) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{----------------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -z " + (string.Format("{0:0.0000}", -X) + " R\n");

                    }
                    yold = Y;
                    degree += degreeconst;
                }


            }
            // ----------------------------------------------half circle  Edge concave-------------------------------------------------------------
            //-----perfect---------------

            if (Form1.self.checkBox3.Checked == true)
            {
                for (double i = 90; i < 180; i = (i + degreeconst))
                {
                    fromradians = Math.PI * (degree + 90) / 180;

                    double X = (radius * Math.Sin(fromradians));
                    double Y = (radius * Math.Cos(fromradians));

                    checkmove = (yold - Y);

                    if (checkmove > 0.01)
                    {
                        warning = (string.Format("{0:0.0000} ", checkmove)) + " WARNING! Cut over 0.010";
                    }


                    //----------------------backlash off----------------------------
                    if (Form1.self.checkBox5.Checked == false)
                    {
                        Form1.self.RGcodeRTB.Text += "{--- " + (90 + degree) + " Total Degrees --" + warning + "--}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -z " + (string.Format("{0:0.0000}", checkmove) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{---------" + warning2 + "-------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -x " + (string.Format("{0:0.0000}", X) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{----------------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " +x " + (string.Format("{0:0.0000}", X * 2) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{----------------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed * 5) + " -x " + (string.Format("{0:0.0000}", X) + " R\n");
                    }
                    yold = Y;
                    degree += degreeconst;
                }




            }

            // ----------------------------------------------------corner concave-----------------------------------------------------------------
            // works perfect

            if (Form1.self.checkBox4.Checked == true)
            {
                for (double i = 180; i < 270; i = (i + degreeconst))
                {
                    fromradians = Math.PI * (180 + degree) / 180;
                    double Y = radius * Math.Sin(fromradians);
                    double X = radius * Math.Cos(fromradians);

                    //-----y info----------------------------------------------------------------------------------------

                    checkmove = (yold - Y);

                    if (checkmove > 0.01)
                    {
                        warning = (string.Format("{0:0.0000} ", checkmove)) + " WARNING! Cut over 0.010";
                    }


                    //----------------------backlash off----------------------------
                    if (Form1.self.checkBox5.Checked == false)
                    {
                        Form1.self.RGcodeRTB.Text += "{--- " + (90 + degree) + " Total Degrees --" + warning + "--}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -x " + (string.Format("{0:0.0000}", checkmove) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{---------" + warning2 + "-------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " -z " + (string.Format("{0:0.0000}", -X) + " R\n");
                        Form1.self.RGcodeRTB.Text += "{----------------}\r";
                        Form1.self.RGcodeRTB.Text += string.Format("{0:00}", feed) + " +z " + (string.Format("{0:0.0000}", -X) + " R\n");
                    }
                    yold = Y;
                    degree += degreeconst;
                }

            }
        }

        public void Radius_MouseClick(object sender, MouseEventArgs e)
        {
            if (Form1.self.checkBox1.Checked == true)
            {
                Form1.self.checkBox2.Checked = false;
                Form1.self.checkBox3.Checked = false;
                Form1.self.checkBox4.Checked = false;
            }
            if (Form1.self.checkBox2.Checked == true)
            {
                Form1.self.checkBox1.Checked = false;
                Form1.self.checkBox3.Checked = false;
                Form1.self.checkBox4.Checked = false;
            }
            if (Form1.self.checkBox3.Checked == true)
            {
                Form1.self.checkBox1.Checked = false;
                Form1.self.checkBox2.Checked = false;
                Form1.self.checkBox4.Checked = false;
            }
            if (Form1.self.checkBox4.Checked == true)
            {
                Form1.self.checkBox1.Checked = false;
                Form1.self.checkBox2.Checked = false;
                Form1.self.checkBox3.Checked = false;
            }

        }
    }
}
