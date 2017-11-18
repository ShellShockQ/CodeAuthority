using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA.DataAccess
{
    using System.Data.Entity;

    using CA.BusinessLogic;

    public class ContactRepository
    {

        public CodeAuthorityEntities db = new CodeAuthorityEntities();
        public string InsertAddToDatabase(Contact contact)
        {
          string resultingID=  this.db.InsertUpdateNewContact(
                contact.FirstName,
                contact.LastName,
                contact.EmailAddress,
                contact.PhoneNumber,
                contact.BesTimeToCall.ToString()).First();

            return resultingID;
        }
    
    }


}
