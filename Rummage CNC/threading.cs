using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rummage_CNC
{
    class threading
    {
        public void threadtype(object sender, EventArgs e)//-----------------------------set threading type-----------------------------
        {
            string type = Convert.ToString((sender as Button).Text);

            if (type == "Internal")
            {
                (sender as Button).Text = "External";
            }
            if (type == "External")
            {
                (sender as Button).Text = "Internal";
            }
        }

        public void threadDirection(object sender, EventArgs e)//-----------------------------set threading type-----------------------------
        {
            string type = Convert.ToString((sender as Button).Text);

            if (type == "Right")
            {
                (sender as Button).Text = "Left";
            }
            if (type == "Left")
            {
                (sender as Button).Text = "Right";
            }
        }
        public async void threadright(object sender, EventArgs e)//------------------------threading loop------------------------------------
        {
            await Task.Run(() =>
            {
                if (Form1.self.ExportsClearCB.Checked == true)
                {
                    Form1.self.RGcodeRTB.Text = "";
                }

                //Form1.self.ReloadcodeCB.Checked = false;

                double rpm = Convert.ToDouble(Form1.self.ThreadRPM.Text);
                double tpi = Convert.ToDouble(Form1.self.TPI.Text);
                double travelin = Convert.ToDouble(Form1.self.ThreadLength.Text);
                double travelRetract = Convert.ToDouble(Form1.self.ThreadRetractLength.Text);
                double DOCThread = Convert.ToDouble(Form1.self.ThreadDOC.Text);
                double ThreadRetractSpeed = Convert.ToDouble(Form1.self.ThreadRetractIPM.Text);

                string Axis = Form1.self.ThreadAxisBT.Text;
                string retractAxis = Form1.self.ThreadRetractAxisBT.Text;

                string ttype = Convert.ToString(Form1.self.ThreadType.Text);
                string tDirection = Convert.ToString(Form1.self.ThreadDirection.Text);

                double ipm = rpm / tpi;

                string[] NewData = new string[9];

                NewData[1] = ThreadRetractSpeed + " -" + Axis + " " + string.Format("{0:0.0000}", travelin);

                NewData[2] = ThreadRetractSpeed + " +" + Axis + " " + string.Format("{0:0.0000}", travelin);

                NewData[3] = ThreadRetractSpeed / 2 + " -" + retractAxis + " " + string.Format("{0:0.0000}", travelRetract);

                NewData[4] = ThreadRetractSpeed / 2 + " +" + retractAxis + " " + string.Format("{0:0.0000}", travelRetract);

                NewData[5] = ThreadRetractSpeed / 2 + " -" + retractAxis + " " + string.Format("{0:0.0000}", DOCThread);

                NewData[6] = ThreadRetractSpeed / 2 + " +" + retractAxis + " " + string.Format("{0:0.0000}", DOCThread);

                if (Form1.self.DOCTableCheck.Checked == false)
                {
                    //-------------------------------------------------------------Right---------------------------------------------------
                    if (ipm < 75 && ttype == "External" && tDirection == "Right")
                    {
                        Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " -" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[2]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + Convert.ToString(NewData[5]) + "\r";
                        // Form1.self.RunRGcode_Click(sender, e);
                    }

                    if (ipm < 75 && ttype == "Internal" && tDirection == "Right")
                    {
                        Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " -" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[2]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + Convert.ToString(NewData[6]) + "\r";

                        //Form1.self.RunRGcode_Click(sender, e);
                    }
                    //-------------------------------------------------------------Left---------------------------------------------------
                    if (ipm < 75 && ttype == "External" && tDirection == "Left")
                    {
                        Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " +" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[1]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + Convert.ToString(NewData[5]) + "\r";

                    }
                    if (ipm < 75 && ttype == "Internal" && tDirection == "Left")
                    {
                        Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " +" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[1]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                        Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + Convert.ToString(NewData[6]) + "\r";
                    }
                }
                //----------------------------------------------use DOC table----------------------------------------------------------------------

                if (Form1.self.DOCTableCheck.Checked == true)
                {

                    string GetLines = Form1.self.DOCRTB.Text;

                    string[] lines = GetLines.Split('\n');
                    //-------------------------------------------------------------Right---------------------------------------------------

                    if (ipm < 75 && ttype == "External" && tDirection == "Right" && lines[0] != "")
                    {
                        for (int i = 0; i < lines.Length - 1; i++)
                        {
                            Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " -" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[2]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + ThreadRetractSpeed / 2 + " -" + retractAxis + " " + string.Format("{0:0.0000}", lines[i]) + "\r";

                        }
                    }

                    if (ipm < 75 && ttype == "Internal" && tDirection == "Right" && lines[0] != "")
                    {
                        for (int i = 0; i < lines.Length - 1; i++)
                        {
                            Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " -" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[2]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + ThreadRetractSpeed / 2 + " +" + retractAxis + " " + string.Format("{0:0.0000}", lines[i]) + "\r";

                        }
                    }
                    //-------------------------------------------------------------Left---------------------------------------------------
                    if (ipm < 75 && ttype == "External" && tDirection == "Left" && lines[0] != "")
                    {
                        for (int i = 0; i < lines.Length - 1; i++)
                        {
                            Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " +" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[1]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + ThreadRetractSpeed / 2 + " -" + retractAxis + " " + string.Format("{0:0.0000}", lines[i]) + "\r";

                        }
                    }
                    if (ipm < 75 && ttype == "Internal" && tDirection == "Left" && lines[0] != "")
                    {
                        for (int i = 0; i < lines.Length - 1; i++)
                        {
                            Form1.self.RGcodeRTB.Text += "{------TDC Threading-------}\r" + "Delay\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + string.Format("{0:0.00}", ipm) + " +" + Axis + " " + string.Format("{0:0.0000}", travelin) + "\r";

                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[3]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[1]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------Exported from Threading-------}\r" + Convert.ToString(NewData[4]) + "\r";
                            Form1.self.RGcodeRTB.Text += "{------DOC Threading-------}\r" + ThreadRetractSpeed / 2 + " +" + retractAxis + " " + string.Format("{0:0.0000}", lines[i]) + "\r";

                        }
                    }
                }

                if (ipm > 75)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        Form1.self.label19.Visible = true;
                        Form1.self.Update();
                        Form1.self.TPI.BackColor = System.Drawing.Color.Red;
                        Form1.self.ThreadRPM.BackColor = System.Drawing.Color.Red;

                        Task.Delay(300).Wait();
                        Form1.self.TPI.BackColor = System.Drawing.Color.White;
                        Form1.self.ThreadRPM.BackColor = System.Drawing.Color.White;
                        Task.Delay(300).Wait();
                    }
                    Form1.self.label19.Visible = false;
                    Form1.self.Update();
                }
            });
        }
    }
}
