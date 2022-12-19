using System;
using System.Linq;
using System.Threading.Tasks;
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

        public void smartloop(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                string[] NewData = new string[9];

                if (Form1.self.XnegOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.XnegOrder.Text);
                    NewData[order] = Form1.self.XnegIPM.Text + " -x " + Form1.self.XnegTB.Text;
                }
                if (Form1.self.XposOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.XposOrder.Text);
                    NewData[order] = Form1.self.XposIPM.Text + " +x " + Form1.self.XposTB.Text;
                }
                if (Form1.self.YnegOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.YnegOrder.Text);
                    NewData[order] = Form1.self.YnegIPM.Text + " -y " + Form1.self.YnegTB.Text;
                }
                if (Form1.self.YposOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.YposOrder.Text);
                    NewData[order] = Form1.self.YposIPM.Text + " +y " + Form1.self.YposTB.Text;
                }
                if (Form1.self.ZnegOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.ZnegOrder.Text);
                    NewData[order] = Form1.self.ZnegIPM.Text + " -z " + Form1.self.ZnegTB.Text;
                }
                if (Form1.self.ZposOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.ZposOrder.Text);
                    NewData[order] = Form1.self.ZposIPM.Text + " +z " + Form1.self.ZposTB.Text;
                }
                if (Form1.self.AnegOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.AnegOrder.Text);
                    NewData[order] = Form1.self.AnegIPM.Text + " -a " + Form1.self.AnegTB.Text;
                }
                if (Form1.self.AposOrder.Text != "0")
                {
                    int order = Convert.ToInt32(Form1.self.AposOrder.Text);
                    NewData[order] = Form1.self.AposIPM.Text + " +a " + Form1.self.AposTB.Text;
                }

                NewData = NewData.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                int[] allorders = new int[]
                {
                    Convert.ToInt32(Form1.self.XnegOrder.Text),
                    Convert.ToInt32(Form1.self.XposOrder.Text),
                    Convert.ToInt32(Form1.self.YnegOrder.Text),
                    Convert.ToInt32(Form1.self.YposOrder.Text),
                    Convert.ToInt32(Form1.self.ZnegOrder.Text),
                    Convert.ToInt32(Form1.self.ZposOrder.Text),
                    Convert.ToInt32(Form1.self.AnegOrder.Text),
                    Convert.ToInt32(Form1.self.AposOrder.Text)
                };

                allorders = allorders.Where(x => x != 0).ToArray();

                for (int i = 0; i < allorders.Length; i++)
                {
                    for (int j = i + 1; j < allorders.Length; j++)
                    {

                        if (allorders[i] == allorders[j])
                        {
                            MessageBox.Show("More than one : " + allorders[i] + " Change The Duplicate To 0 or Other Non Duplicate Number", "Duplicate Loop Sequence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (Form1.self.ExportsClearCB.Checked == true)
                {
                    Form1.self.RGcodeRTB.Text = "";
                }

                for (int i = 0; i < NewData.Length; i++)
                {
                    Form1.self.RGcodeRTB.Text += "{------Exported from Cycles-------}\r" + Convert.ToString(NewData[i]) + "\r";
                }

            });

        }
    }
}
