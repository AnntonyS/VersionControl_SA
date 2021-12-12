using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTervezesiMintak_SA2.Abstractions
{
    public interface IToyFactory
    {
        //int MyProperty { get; set; }

        Toy CreateNew();
    }



}
