using System;
using System.IO;
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
        public async void threadright(object sender, EventArgs e)//------------------------threading loop------------------------------------
        {

            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {

                        double rpm = Convert.ToDouble(Form1.self.ThreadRPM.Text);
                        double tpi = Convert.ToDouble(Form1.self.ThreadPI.Text);
                        double travelin = Convert.ToDouble(Form1.self.XnegTB.Text);

                        string ttype = Convert.ToString(Form1.self.ThreadType.Text);

                        double ipm = rpm / tpi;

                        double convrt1 = Convert.ToDouble(Form1.self.XConversion.Text);
                        double convrt2 = travelin / convrt1;
                        double convrt3 = Convert.ToDouble(Form1.self.StepMultiplyConvs.Text);
                        int convrt4 = Convert.ToInt32(convrt2 / convrt3);

                        Form1.self.buttonEnabled.Text = "1";

                        if (ipm < 75 && Form1.self.serialPort1.IsOpen == true && ttype == "External")
                        {
                            Form1.self.serialPort1.Write(string.Format("{0}\r", ipm));
                            Form1.self.serialPort1.Write("cwx\r");
                            Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", convrt4)));

                            Form1.self.DiagnosticsRTB.Text += "Clockwise X data sent" + Environment.NewLine;

                            while (Form1.self.buttonEnabled.Text == "1")
                            {
                                Task.Delay(10).Wait();
                            }

                            Form1.self.ZposMove.PerformClick();
                            Form1.self.XposMove.PerformClick();
                            Form1.self.ZnegMove.PerformClick();
                            break;
                        }

                        if (ipm < 75 && Form1.self.serialPort1.IsOpen == true && ttype == "Internal")
                        {
                            Form1.self.serialPort1.Write(string.Format("{0}\r", ipm));
                            Form1.self.serialPort1.Write("cwx\r");
                            Form1.self.serialPort1.Write(Convert.ToString(string.Format("{0:0}\r", convrt4)));

                            Form1.self.DiagnosticsRTB.Text += "Clockwise X data sent" + Environment.NewLine;

                            while (Form1.self.buttonEnabled.Text == "1")
                            {
                                Task.Delay(10).Wait();
                            }

                            Form1.self.ZnegMove.PerformClick();
                            Form1.self.XposMove.PerformClick();
                            Form1.self.ZposMove.PerformClick();
                            break;
                        }

                        if (ipm > 75)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                Form1.self.label19.Visible = true;
                                Form1.self.Update();
                                Form1.self.ThreadPI.BackColor = System.Drawing.Color.Red;
                                Form1.self.ThreadRPM.BackColor = System.Drawing.Color.Red;

                                Task.Delay(300).Wait();
                                Form1.self.ThreadPI.BackColor = System.Drawing.Color.White;
                                Form1.self.ThreadRPM.BackColor = System.Drawing.Color.White;
                                Task.Delay(300).Wait();
                            }
                            Form1.self.label19.Visible = false;
                            Form1.self.Update();
                            break;
                        }

                        break;

                    }
                    catch (Exception ex)
                    {
                        string path = @"c:\dro\ErrorThreadingreport.rep";

                        using (StreamWriter writer = new StreamWriter(path, true))
                        {
                            writer.WriteLine("-----------------------------------------------------------------------------");
                            writer.WriteLine("Date : " + DateTime.Now.ToString());
                            writer.WriteLine();

                            while (ex != null)
                            {
                                writer.WriteLine(ex.GetType().FullName);
                                writer.WriteLine("Message : " + ex.Message);
                                writer.WriteLine("StackTrace : " + ex.StackTrace);

                                ex = ex.InnerException;
                            }
                        }
                        break;
                    }
                }
            });
        }
    }
}
