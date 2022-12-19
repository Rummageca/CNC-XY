using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Rummage_CNC
{
    class Saveload
    {
        public void saveset(object sender, EventArgs e)
        {

            Form1.self.richTextBox2.Text = "";

            string xa = Convert.ToString(Form1.self.XConversion.Text);
            string ya = Convert.ToString(Form1.self.YConversion.Text);
            string za = Convert.ToString(Form1.self.ZConversion.Text);
            string aa = Convert.ToString(Form1.self.AConversion.Text);
            string Conv = Convert.ToString(Form1.self.StepMultiplyConvs.Text);

            double baud = Convert.ToDouble(Form1.self.Baud.Text);
            string com = Convert.ToString(Form1.self.Com.Text);
            string par = Convert.ToString(Form1.self.Parity.Text);

            double wbuff = Convert.ToDouble(Form1.self.WriteBuffer.Text);
            double rbuff = Convert.ToDouble(Form1.self.ReadBuffer.Text);

            string sbits = Convert.ToString(Form1.self.StopBit.Text);
            double databits = Convert.ToDouble(Form1.self.DataBit.Text);
            string hshake = Convert.ToString(Form1.self.HandShake.Text);

            double LashX = Convert.ToDouble(Form1.self.BacklashX.Text);
            double LashY = Convert.ToDouble(Form1.self.BacklashY.Text);
            double LashZ = Convert.ToDouble(Form1.self.BacklashZ.Text);
            double LashA = Convert.ToDouble(Form1.self.BacklashA.Text);

            string CutAxis1 = Form1.self.LongFeedAxisBT.Text;
            string CutAxis2 = Form1.self.ShortFeedAxisBT.Text;
            string ThreadAxis1 = Form1.self.ThreadAxisBT.Text;
            string ThreadAxis2 = Form1.self.ThreadRetractAxisBT.Text;


            Form1.self.richTextBox2.Text += (xa + "\r" + ya + "\r" + za + "\r" + aa + "\r" + Conv + "\r" + baud + "\r" + com + "\r" + par + "\r" + wbuff + "\r" +
                                  rbuff + "\r" + sbits + "\r" + databits + "\r" + hshake + "\r" + LashX + "\r" + LashY + "\r" + LashZ + "\r" + LashA + "\r"
                                  + CutAxis1 + "\r" + CutAxis2 + "\r" + ThreadAxis1 + "\r" + ThreadAxis2 + "\r");

            SaveFileDialog SaveFile = new SaveFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            SaveFile.FileName = "Settings.cfg";
            SaveFile.Filter = "config files (*.cfg)|*.cfg|All files (*.*)|*.*";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                //Form1.self.richTextBox2.Text;
                SaveFile.InitialDirectory = @"c:\dro";
                Form1.self.richTextBox2.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText);
            }

        }
        public void loadset()
        {
            if (File.Exists(@"c:\dro\Settings.cfg") == true)
            {
                StreamReader txt = new StreamReader(@"c:\dro\settings.cfg");

                int NumberOfLines = 22;//-----------------------------How many lines should be loaded?---------------------------            
                string[] ListLines = new string[NumberOfLines];//------Make our array for each line------------------------------            

                if (ListLines[1] != " ")
                {
                    for (int i = 1; i < NumberOfLines; i++)//-------Read the number of lines and put them in the array---------------
                    {
                        ListLines[i] = txt.ReadLine();
                    }

                    txt.Close();

                    Form1.self.XConversion.Text = ListLines[1];
                    Form1.self.YConversion.Text = ListLines[2];
                    Form1.self.ZConversion.Text = ListLines[3];
                    Form1.self.AConversion.Text = ListLines[4];
                    Form1.self.StepMultiplyConvs.Text = ListLines[5];

                    Form1.self.Baud.Text = ListLines[6];
                    Form1.self.serialPort1.BaudRate = Convert.ToInt32(Form1.self.Baud.Text);//----buad----------------------------
                    Form1.self.Com.Text = ListLines[7];
                    Form1.self.serialPort1.PortName = Form1.self.Com.Text;//---------------------com-----------------------------
                    Form1.self.Parity.Text = ListLines[8];
                    Form1.self.serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Form1.self.Parity.Text); //--parity----------


                    Form1.self.WriteBuffer.Text = ListLines[9];
                    Form1.self.serialPort1.WriteBufferSize = Convert.ToInt32(Form1.self.WriteBuffer.Text); //---------- write buff------
                    Form1.self.ReadBuffer.Text = ListLines[10];
                    Form1.self.serialPort1.ReadBufferSize = Convert.ToInt32(Form1.self.ReadBuffer.Text); //----------- read buff-------

                    Form1.self.StopBit.Text = ListLines[11];
                    Form1.self.serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Form1.self.StopBit.Text);//--stop bits--
                    Form1.self.DataBit.Text = ListLines[12];
                    Form1.self.serialPort1.DataBits = Convert.ToInt32(Form1.self.DataBit.Text);//-------------------------data bits--
                    Form1.self.HandShake.Text = ListLines[13];
                    Form1.self.serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), Form1.self.HandShake.Text);//----handshake--                                       

                    Form1.self.BacklashX.Text = ListLines[14];
                    Form1.self.BacklashY.Text = ListLines[15];
                    Form1.self.BacklashZ.Text = ListLines[16];
                    Form1.self.BacklashA.Text = ListLines[17];

                    Form1.self.LongFeedAxisBT.Text = ListLines[18];
                    Form1.self.ShortFeedAxisBT.Text = ListLines[19];
                    Form1.self.ThreadAxisBT.Text = ListLines[20];
                    Form1.self.ThreadRetractAxisBT.Text = ListLines[21];

                    Form1.self.DiagnosticsRTB.Text += "Loaded Saved Settings" + Environment.NewLine;

                    //txt.Close();

                }
                if (ListLines[1] == " ")
                {
                    Form1.self.DiagnosticsRTB.Text += "No Saved Settings!" + Environment.NewLine;
                }
            }
            else if (File.Exists(@"c:\dro\DROsetting.txt") == false)
            {
                Form1.self.DiagnosticsRTB.Text += "No File to load" + Environment.NewLine;
            }

        }
    }
}
