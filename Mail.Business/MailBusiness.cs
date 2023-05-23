using Mail.Data;
using Mail.Entities;


namespace Mail.Business
{
    public class MailBusiness
    {
        private MailRepository _mailRepository;
       

        public MailBusiness()
        {
            _mailRepository = new MailRepository();
        }
        public List<Mensaje> SearchInbox(string textToSearch)
        {
            return _mailRepository.SearchInbox(textToSearch);
        }
        public List<Mensaje> SearchOutbox(string textToSearch)
        {
            return _mailRepository.SearchOutbox(textToSearch);
        }
     
    }
}