using System.Diagnostics.Contracts;

namespace Mail.Entities
{
    public class Mensaje
    {
        public int correoId { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }


        public Contacto destinatario { get; set; }
        public Contacto remitente { get; set; }

        public Mensaje() { }
    }
}