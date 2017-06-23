using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Partida
    {
       public Int32 IdPartida { get; set; }
       public DateTime DataPartida { get; set; }
       public Int32 QuantidadeRodada { get; set; }
       public Int32 IdVencedor { get; set; }
    }
}
