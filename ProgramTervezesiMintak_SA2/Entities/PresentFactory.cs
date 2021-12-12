using ProgramTervezesiMintak_SA2.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTervezesiMintak_SA2.Entities
{
    class PresentFactory : IToyFactory
    {

        public Color PresentColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(PresentColor);
            //return new Present();
        }
    }
}
