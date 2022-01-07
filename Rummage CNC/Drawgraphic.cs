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
            e.Graphics.DrawLine(blackPen, 370, 520, 1270, 520);//horizontal line 2 

            e.Graphics.DrawLine(blackPen, 370, 220, 370, 520);//vertical line   1 
            e.Graphics.DrawLine(blackPen, 370, 520, 370, 980);//vertical line   1 bottom

            e.Graphics.DrawLine(blackPen, 520, 220, 520, 520);//vertical line   2 
            e.Graphics.DrawLine(blackPen, 520, 520, 520, 980);//vertical line   3 bottom


            e.Graphics.DrawLine(blackPen, 920, 520, 920, 980);//vertical line   3             
            e.Graphics.DrawLine(blackPen, 650, 520, 650, 980);//vertical line   3a bottom

            e.Graphics.DrawLine(blackPen, 1100, 520, 1100, 980);//vertical line   3b bottom

            e.Graphics.DrawLine(blackPen, 1270, 0, 1270, 980);//vertical line 4


            using (Font the_font = new Font("Comic Sans MS", 15))// Rotate text.
            {
                DrawRotatedTextAt(e.Graphics, +90, "Loop Sequence",
                360, 260, the_font, Brushes.LightGreen);
            }

            // draw arc types-----------------------------------------------------
            //-----------------------corner round---------------------------------
            blackPen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(blackPen, 410, 740, 410, 870);
            e.Graphics.DrawLine(blackPen, 475, 755, 475, 770);
            e.Graphics.DrawLine(blackPen, 475, 820, 475, 870);
            e.Graphics.DrawLine(blackPen, 475, 870, 410, 870);

            blackPen = new Pen(Color.LightGray, 2);
            e.Graphics.DrawArc(blackPen, 449, 740, 25, 30, 270, 90);
            //-----------------------Corner concave-------------------------------
            blackPen = new Pen(Color.Green, 2);
            e.Graphics.DrawArc(blackPen, 460, 725, 25, 30, 90, 90);
            //-----------------------end concave----------------------------------
            blackPen = new Pen(Color.Red, 2);
            e.Graphics.DrawArc(blackPen, 410, 730, 50, 20, 0, 180);
            //-----------------------side concave---------------------------------
            blackPen = new Pen(Color.Orange, 2);
            e.Graphics.DrawArc(blackPen, 464, 770, 20, 50, 90, 180);
        }
        public void Painttab2(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            e.Graphics.DrawLine(blackPen, 560, 510, 1480, 510);//horizontal line 1 
            e.Graphics.DrawLine(blackPen, 560, 0, 560, 980);//vertical line   1 
            e.Graphics.DrawLine(blackPen, 1480, 0, 1480, 980);//vertical line   2

        }
    }
}
