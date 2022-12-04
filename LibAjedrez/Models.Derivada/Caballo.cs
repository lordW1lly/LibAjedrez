using LibAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAjedrez.Models.Derivada
{
    public class Caballo : PiezaAjedrez
    {
        public override string Mover()
        {
            return "B-2";
        }
    }
}
