using ProgramTervezesiMintak_SA2.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramTervezesiMintak_SA2.Entities
{
    public class Ball: Toy
    {
        public SolidBrush BallBrush { get; private set; }

        public Ball(Color kivantszin)
        {
            BallBrush = new SolidBrush(kivantszin);
        }

        protected override void DrawImage(Graphics g)
        {
            //g.FillEllipse(new SolidBrush(Color.Red), 0, 0, Width, Height);
            g.FillEllipse(BallBrush, 0, 0, Width, Height);
        }

        //public Ball()
        //{
        //    AutoSize = false;
        //    Width = Height = 50;
        //    Paint += Ball_Paint;
        //}

        //private void Ball_Paint(object sender, PaintEventArgs e)
        //{
        //    DrawImage(e.Graphics);
        //}

        //public void MoveBall()
        //{
        //    Left++;
        //}

        //protected override void DrawImage(Graphics g)
        //{
        //    throw new NotImplementedException();
        //}
    }



}
