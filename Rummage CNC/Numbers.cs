using System;
using System.Windows.Forms;


namespace Rummage_CNC
{
    class Numbers
    {
        public void KeyDown1(object sender, KeyEventArgs e)// arrow keys to change numbers up and down
        {
            double up = Convert.ToDouble((sender as TextBox).Text);

            if (e.KeyCode == Keys.Up && up <= 10000)
            {

                up += 1;
                (sender as TextBox).Text = Convert.ToString(up);
            }
            if (e.KeyCode == Keys.Down && up >= 1)
            {

                up -= 1;
                (sender as TextBox).Text = Convert.ToString(up);
            }

        }
        public void KeyDown2(object sender, KeyEventArgs e)// arrow keys to change numbers up and down 0.10
        {
            double up = Convert.ToDouble((sender as TextBox).Text);

            if (e.KeyCode == Keys.Up && up <= 100)
            {

                up += 0.1;
                (sender as TextBox).Text = Convert.ToString(up);
            }
            if (e.KeyCode == Keys.Down && up >= 0.1)
            {

                up -= 0.1;
                (sender as TextBox).Text = Convert.ToString(up);
            }

        }
        public void number_KeyPress(object sender, KeyPressEventArgs e)// numbes only plus decimal place
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
