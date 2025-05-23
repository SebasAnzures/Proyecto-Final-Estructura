using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Estructura.Model
{
    class Rate
    {
        public int? id { get; set; }
        public int idgame { get; set; }
        public int score { get; set; }
        public string? comment { get; set; }
    }
}
