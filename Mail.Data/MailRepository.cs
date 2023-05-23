using Mail.Entities;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace Mail.Data
{
    public class MailRepository
    {
       
        public List<Mensaje> SearchInbox(string textToSearch)
        {
            string connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

            string querySql = $"SELECT CorreoId, Asunto, Cuerpo, MailRemitente, NombreRemitente, MailDestinatario, NombreDestinatario FROM dbo.Mails WHERE MailDestinatario LIKE '%{textToSearch}%'";

            var mails = new List<Mensaje>();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(querySql, connection);
         
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var _mails = new Mensaje();
                        var _remitente = new Contacto();
                        var _destinatario = new Contacto();
                        _mails.correoId = Convert.ToInt32(reader[0].ToString());
                        _mails.asunto = reader[1].ToString();
                        _mails.cuerpo = reader[2].ToString();
                        _remitente.mail = reader[4].ToString();
                        _remitente.nombre = reader[3].ToString();
                        _destinatario.mail = reader[4].ToString();
                        _destinatario.nombre = reader[3].ToString();
                        _mails.remitente = _remitente;
                        _mails.destinatario = _destinatario;


                        mails.Add(_mails);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR]{ex.Message}");
                }
                connection.Close();
            }


            return mails;
        }
        public List<Mensaje> SearchOutbox(string textToSearch)
        {
            
            string connectionString =
            "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

            string querySql = $"SELECT CorreoId, Asunto, Cuerpo, MailRemitente, NombreRemitente, MailDestinatario, NombreDestinatario FROM dbo.Mails WHERE MailRemitente LIKE '%{textToSearch}%'";

            var mails = new List<Mensaje>();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(querySql, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var _mails = new Mensaje();
                        var _remitente = new Contacto();
                        var _destinatario = new Contacto();
                        _mails.correoId = Convert.ToInt32(reader[0].ToString());
                        _mails.asunto = reader[1].ToString();
                        _mails.cuerpo = reader[2].ToString();
                        _remitente.mail = reader[4].ToString();
                        _remitente.nombre = reader[3].ToString();
                        _destinatario.mail = reader[4].ToString();
                        _destinatario.nombre = reader[3].ToString();
                        _mails.remitente = _remitente;
                        _mails.destinatario = _destinatario;


                        mails.Add(_mails);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR]{ex.Message}");
                }
                connection.Close();

            }


            return mails;
        }
    }
}