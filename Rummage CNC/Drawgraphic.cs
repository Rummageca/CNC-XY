using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rummage_CNC
{
    class Drawgraphic
    {
        public void DrawRotatedTextAt(Graphics gr, float angle,
        string txt, int x, int y, Font the_font, Brush the_brush)
        {
            GraphicsState state = gr.Save();// Save the graphics state.
            gr.ResetTransform();
            gr.RotateTransform(angle);// Rotate.
            // Translate to desired position. Be sure to append
            // the rotation so it occurs after the rotation.
            gr.TranslateTransform(x, y, MatrixOrder.Append);
            gr.DrawString(txt, the_font, the_brush, 0, 0); // Draw the text at the origin.           
            gr.Restore(state);// Restore the graphics state.
        }

        public void Painttab1(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            e.Graphics.DrawLine(blackPen, 0, 220, 1270, 220);//horizontal line 1 
            e.Graphics.DrawLine(blackPen, 685, 520, 1270, 520);//horizontal line 2 
            e.Graphics.DrawLine(blackPen, 0, 650, 370, 650);//horizontal line 3

            e.Graphics.DrawLine(blackPen, 370, 220, 370, 520);//vertical line   1 
            e.Graphics.DrawLine(blackPen, 370, 520, 370, 980);//vertical line   1 bottom

            e.Graphics.DrawLine(blackPen, 520, 220, 520, 520);//vertical line   2 
            e.Graphics.DrawLine(blackPen, 520, 520, 520, 980);//vertical line   3 bottom


            e.Graphics.DrawLine(blackPen, 960, 520, 960, 980);//vertical line   3             
            e.Graphics.DrawLine(blackPen, 870, 220, 870, 520);//vertical line   3 Middle 
            e.Graphics.DrawLine(blackPen, 685, 220, 685, 980);//vertical line   3a bottom

            e.Graphics.DrawLine(blackPen, 1100, 520, 1100, 980);//vertical line   3b bottom

            e.Graphics.DrawLine(blackPen, 1270, 0, 1270, 980);//vertical line 4
            e.Graphics.DrawLine(blackPen, 1100, 220, 1100, 520);//vertical line 4 Middle 



            using (Font the_font = new Font("Comic Sans MS", 15))// Rotate text.
            {
                DrawRotatedTextAt(e.Graphics, +90, "Loop Sequence",
                360, 260, the_font, Brushes.LightGreen);
            }

            





            /* draw arc types-----------------------------------------------------
            //-----------------------corner round---------------------------------
            blackPen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(blackPen, 290, 740, 290, 870);
            e.Graphics.DrawLine(blackPen, 355, 755, 355, 770);
            e.Graphics.DrawLine(blackPen, 355, 820, 355, 870);
            e.Graphics.DrawLine(blackPen, 355, 870, 290, 870);

            blackPen = new Pen(Color.LightGray, 2);
            e.Graphics.DrawArc(blackPen, 329, 740, 25, 30, 270, 90);
            //-----------------------Corner concave-------------------------------
            blackPen = new Pen(Color.Green, 2);
            e.Graphics.DrawArc(blackPen, 340, 725, 25, 30, 90, 90);
            //-----------------------end concave----------------------------------
            blackPen = new Pen(Color.Red, 2);
            e.Graphics.DrawArc(blackPen, 290, 730, 50, 20, 0, 180);
            //-----------------------side concave---------------------------------
            blackPen = new Pen(Color.Orange, 2);
            e.Graphics.DrawArc(blackPen, 344, 770, 20, 50, 90, 180);
            */
        }
        public void Painttab2(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            e.Graphics.DrawLine(blackPen, 560, 510, 1480, 510);//horizontal line 1 
            e.Graphics.DrawLine(blackPen, 560, 0, 560, 980);//vertical line   1 
            e.Graphics.DrawLine(blackPen, 1480, 0, 1480, 980);//vertical line   2

            //------------------------------- pinouts------------------------------------

            using (Font the_font = new Font("Microsoft Sans Serif", 15))// Rotate text.
            {
                e.Graphics.DrawString("Use", the_font, Brushes.Red, 580, 525);
                e.Graphics.DrawString("Pin", the_font, Brushes.Red, 700, 525);
                e.Graphics.DrawString("Type", the_font, Brushes.Red, 780, 525);

                e.Graphics.DrawString("Enab", the_font, Brushes.Black, 580, 550);
                e.Graphics.DrawString("50", the_font, Brushes.Black, 700, 550);
                e.Graphics.DrawString("5 Volt", the_font, Brushes.Black, 780, 550);

                e.Graphics.DrawString("Tool Probe", the_font, Brushes.Black, 580, 575);
                e.Graphics.DrawString("45", the_font, Brushes.Black, 700, 575);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 780, 575);
                
                e.Graphics.DrawString("Rpm", the_font, Brushes.Black, 580, 600);
                e.Graphics.DrawString("19", the_font, Brushes.Black, 700, 600);
                e.Graphics.DrawString("Pulse V+", the_font, Brushes.Black, 780, 600);

                e.Graphics.DrawString("Estop", the_font, Brushes.Black, 580, 625);
                e.Graphics.DrawString("49", the_font, Brushes.Black, 700, 625);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 780, 625);



                e.Graphics.DrawString("LCD SDA", the_font, Brushes.Black, 580, 675);
                e.Graphics.DrawString("20", the_font, Brushes.Black, 700, 675);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 780, 675);

                e.Graphics.DrawString("LCD SCL", the_font, Brushes.Black, 580, 700);
                e.Graphics.DrawString("21", the_font, Brushes.Black, 700, 700);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 780, 700);
                //-----------------------X
                e.Graphics.DrawString("Home X", the_font, Brushes.Black, 900, 550);
                e.Graphics.DrawString("40", the_font, Brushes.Black, 1020, 550);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 1100, 550);

                e.Graphics.DrawString("Direction X", the_font, Brushes.Black, 900, 575);
                e.Graphics.DrawString("30", the_font, Brushes.Black, 1020, 575);
                e.Graphics.DrawString("High/Low", the_font, Brushes.Black, 1100, 575);
                
                e.Graphics.DrawString("Step X", the_font, Brushes.Black, 900, 600);
                e.Graphics.DrawString("31", the_font, Brushes.Black, 1020, 600);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 1100, 600);
                //-----------------------Y
                e.Graphics.DrawString("Home Y", the_font, Brushes.Black, 900, 650);
                e.Graphics.DrawString("41", the_font, Brushes.Black, 1020, 650);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 1100, 650);

                e.Graphics.DrawString("Direction Y", the_font, Brushes.Black, 900, 675);
                e.Graphics.DrawString("34", the_font, Brushes.Black, 1020, 675);
                e.Graphics.DrawString("High/Low", the_font, Brushes.Black, 1100, 675);

                e.Graphics.DrawString("Step Y", the_font, Brushes.Black, 900, 700);
                e.Graphics.DrawString("35", the_font, Brushes.Black, 1020, 700);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 1100, 700);
                //-----------------------Line
                e.Graphics.DrawLine(blackPen, 880, 510, 880, 1080);//horizontal line 1 
                e.Graphics.DrawString("Use", the_font, Brushes.Red, 900, 525);
                e.Graphics.DrawString("Pin", the_font, Brushes.Red, 1020, 525);
                e.Graphics.DrawString("Type", the_font, Brushes.Red, 1100, 525);
                //------------------------Z
                e.Graphics.DrawString("Home Z", the_font, Brushes.Black, 900, 750);
                e.Graphics.DrawString("42", the_font, Brushes.Black, 1020, 750);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 1100, 750);

                e.Graphics.DrawString("Direction Z", the_font, Brushes.Black, 900, 775);
                e.Graphics.DrawString("32", the_font, Brushes.Black, 1020, 775);
                e.Graphics.DrawString("High/Low", the_font, Brushes.Black, 1100, 775);

                e.Graphics.DrawString("Step Z", the_font, Brushes.Black, 900, 800);
                e.Graphics.DrawString("33", the_font, Brushes.Black, 1020, 800);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 1100, 800);
                //------------------------A
                e.Graphics.DrawString("Home A", the_font, Brushes.Black, 900, 850);
                e.Graphics.DrawString("43", the_font, Brushes.Black, 1020, 850);
                e.Graphics.DrawString("Ground", the_font, Brushes.Black, 1100, 850);

                e.Graphics.DrawString("Direction A", the_font, Brushes.Black, 900, 875);
                e.Graphics.DrawString("36", the_font, Brushes.Black, 1020, 875);
                e.Graphics.DrawString("High/Low", the_font, Brushes.Black, 1100, 875);

                e.Graphics.DrawString("Step A", the_font, Brushes.Black, 900, 900);
                e.Graphics.DrawString("37", the_font, Brushes.Black, 1020, 900);
                e.Graphics.DrawString("Data", the_font, Brushes.Black, 1100, 900);

            }
        }
    }
}
