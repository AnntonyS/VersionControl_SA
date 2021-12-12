using ProgramTervezesiMintak_SA2.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTervezesiMintak_SA2.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentBrush { get; private set; }

        public Present(Color kivantszin)
        {
            PresentBrush = new SolidBrush(kivantszin);
            //RibbonBrush = new SolidBrush(kivantszin);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentBrush, 0, 0, Width, Height);
            //g.FillRectangle(RibbonBrush, 0, 20, Width-40, Height-40);
        }
    }
}
