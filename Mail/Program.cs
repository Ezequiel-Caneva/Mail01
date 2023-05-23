using Mail;
using Mail.Business;


var mailBusiness = new MailBusiness();
var mail= "eze@gmail.com";



var inbox = mailBusiness.SearchInbox(mail);
var outbox = mailBusiness.SearchOutbox(mail);



Console.WriteLine("----Bandeja de Entrada----");
foreach (var e in inbox)
{
    Console.WriteLine($"Asunto: {e.asunto}\nCuerpo: {e.cuerpo}\nRemitente: {e.remitente.nombre}\nCorreo del remitente: {e.remitente.mail}\nDestinatario: {e.destinatario.nombre}\nCorreo del destinatario:{e.destinatario.mail}\n-------------------");

}

Console.WriteLine("----Bandeja de Salida----");
foreach (var e in outbox)
{
    Console.WriteLine($"Asunto: {e.asunto}\nCuerpo: {e.cuerpo}\nRemitente: {e.remitente.nombre}\nCorreo del remitente: {e.remitente.mail}\nDestinatario: {e.destinatario.nombre}\nCorreo del destinatario:{e.destinatario.mail}\n-------------------");
}



Console.ReadKey();
