using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Droga
    {
        public int IdDroga { get; set; }
        public string NombreDroga { get; set; }

        public Droga()
        {

        }

        public Droga(int idDroga, string nombreDroga)
        {
            IdDroga = idDroga;
            NombreDroga = nombreDroga;
        }
    }
}
