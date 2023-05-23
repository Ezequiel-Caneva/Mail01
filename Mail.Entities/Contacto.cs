using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Entities
{
    public class Contacto
    {
        public string nombre { set; get; }
        public string mail { set; get; }

        public Contacto(string nombre, string mail)
        {
            this.nombre = nombre;
            this.mail = mail;
        }
        public Contacto() { }
    }
}
