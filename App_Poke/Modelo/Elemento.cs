using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Elemento
    {
        private int id;
        private string descripcion;

        public Elemento()
        {

        }

        public Elemento(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public int Id
        {
            get { return id; }  
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
