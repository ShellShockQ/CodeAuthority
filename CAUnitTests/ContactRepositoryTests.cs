using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA.BusinessLogic;
using CA.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CAUnitTests
{
    using System.Runtime.InteropServices.ComTypes;

    [TestClass]
    public class ContactRepositoryTests
    {
        [TestMethod]
        public void InsertUpdateNewContactIsCalled_AContact_ContactIsAdded()
        {
            //Arrange
            DateTime bestTimeToCall = Convert.ToDateTime("12/25/2020 1:00PM");
            var contact = new Contact{FirstName = "Paul",LastName = "Jackson",EmailAddress = "tester@test.com",PhoneNumber = "214-234-5678",BesTimeToCall = bestTimeToCall};
            var contactRepository = new ContactRepository();
            //Act
            string resultID = contactRepository.InsertAddToDatabase(contact);
            //Assert
            Assert.IsNotNull(resultID);
        }
    }
}
