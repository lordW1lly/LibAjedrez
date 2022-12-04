using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Derivada
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "A-2";
        }
    }
}
