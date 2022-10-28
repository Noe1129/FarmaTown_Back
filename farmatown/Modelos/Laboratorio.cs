using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Laboratorio
    {
        public int IdLab { get; set; }
        public string NombreLab { get; set; }

        public Laboratorio()
        {

        }

        public Laboratorio(int idLab, string nombreLab)
        {
            IdLab = idLab;
            NombreLab = nombreLab;
        }
    }
}
