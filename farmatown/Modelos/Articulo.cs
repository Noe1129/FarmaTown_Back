using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmatown.Modelos
{
    public class Articulo
    {
        public Articulo(int idArticulo, double preUnitario, string nomArticulo, TipoArticulo tipoArticulo,Droga droga,Laboratorio laboratorio)
        {
            this.idArticulo = idArticulo;
            this.preUnitario = preUnitario;
            this.nomArticulo = nomArticulo;
            this.tipoArticulo = tipoArticulo;
            this.droga = droga;
            this.laboratorio = laboratorio;
        }

        public Articulo(double preUnitario, string nomArticulo,int stock,TipoArticulo tipoArticulo,Droga droga,Laboratorio laboratorio)
        {
            this.preUnitario = preUnitario;
            this.nomArticulo = nomArticulo;
            this.tipoArticulo = tipoArticulo;
            this.Stock = stock;
            this.droga = droga;
            this.laboratorio = laboratorio;
        }

        public Articulo(int idArticulo, double preUnitario, string nomArticulo, int stock, TipoArticulo tipoArticulo, Droga droga, Laboratorio laboratorio)
        {
            this.idArticulo = idArticulo;
            this.preUnitario = preUnitario;
            this.nomArticulo = nomArticulo;
            Stock = stock;
            this.tipoArticulo = tipoArticulo;
            this.droga = droga;
            this.laboratorio = laboratorio;
        }


        public int idArticulo { get; set; }
        public double preUnitario { get; set; }
        public string nomArticulo { get; set; }
        public int Stock { get; set; }
        public TipoArticulo tipoArticulo { get; set; }
        public Droga droga { get; set; }
        public Laboratorio laboratorio { get; set; }


    }
}
