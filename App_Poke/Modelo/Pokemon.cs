using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pokemon
    {
        
        private int num;
        private string name;
        private string descrip;
        private string urlImag;
        private bool activo;
        private Elemento tipo;
        private Elemento debilidad;

        public Pokemon() { }

        public Pokemon(int num, string name, string descrip, string urlImag, bool activo)
        {
            this.num = num;
            this.name = name;
            this.descrip = descrip;
            this.urlImag = urlImag;
            this.activo = activo;
        }

        public Pokemon(int num, string name, string descrip, string urlImag, bool activo, Elemento tipo, Elemento debilidad)
        {
            this.num = num;
            this.name = name;
            this.descrip = descrip;
            this.urlImag = urlImag;
            this.activo = activo;
            this.tipo = tipo;
            this.debilidad = debilidad;
        }


        [DisplayName("Numero")]
        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        [DisplayName("Nombre")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Descripcion")]
        public string Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }

        [DisplayName("ImagenURL")]
        public string UrlImag
        {
            get { return urlImag; }
            set { urlImag = value; }
        }

        [DisplayName("Activo")]
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        [DisplayName("Tipo")]
        public Elemento Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DisplayName("Debilidad")]
        public Elemento Debilidad
        {
            get { return debilidad; }
            set { debilidad = value; }

        }


        public string mostrar()
        {
            return "Num: " + num +
                   "\nName: " + name +
                   "\nDescrip: " + descrip +
                   "\nUrlImag: " + urlImag;

        }
    }
}
