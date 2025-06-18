using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOM
{
    class MoveForm
    {
        Point lastPoint;
        public void Move(object sender, MouseEventArgs e, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - lastPoint.X;
                form.Top += e.Y - lastPoint.Y;

            }
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
