using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


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
                Form1.self.ReloadcodeCB.Checked = false;
                Form1.self.ExportsClearCB.Checked = true;

                double rpm = Convert.ToDouble(Form1.self.ThreadRPM.Text);
                double tpi = Convert.ToDouble(Form1.self.ThreadPI.Text);
                double travelin = Convert.ToDouble(Form1.self.XnegTB.Text);

                string ttype = Convert.ToString(Form1.self.ThreadType.Text);

                double ipm = rpm / tpi;

                string[] NewData = new string[9];

                NewData[1] = Form1.self.XnegIPM.Text + " -x " + Form1.self.XnegTB.Text;

                NewData[2] = Form1.self.XposIPM.Text + " +x " + Form1.self.XposTB.Text;

                NewData[3] = Form1.self.ZnegIPM.Text + " -z " + Form1.self.ZnegTB.Text;

                NewData[4] = Form1.self.ZposIPM.Text + " +z " + Form1.self.ZposTB.Text;

                if (ipm < 75 && ttype == "External")
                {
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + ipm + " -x " + travelin + "\r";

                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[4]) + "\r";
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[2]) + "\r";
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[3]) + "\r";

                    Form1.self.RunRGcode_Click(sender ,e);
                }

                if (ipm < 75 && ttype == "Internal")
                {
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + ipm + " -x " + travelin + "\r";

                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[3]) + "\r";
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[2]) + "\r";
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[4]) + "\r";

                    Form1.self.RunRGcode_Click(sender, e);
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
                }
            });
        }
    }
}
