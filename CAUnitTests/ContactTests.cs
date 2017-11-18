using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAUnitTests
{
    using CA.BusinessLogic;

    [TestClass]
    public class ContactTests
    {
        [TestMethod]
        public void Successfully_Create_A_Contact()
        {
            //Arrange
            var contact = new Contact();
            //Act
            
            //Assert
            Assert.IsNotNull(contact);
        }
        [TestMethod]
        public void EmailAddressIsValid_Handles_A_Correctly_Formatted_Email_Address()
        {
            //Arrange
            var contact = new Contact();
            string testemailaddress = "test@email.com";
            //Act
            bool isEmailValid = contact.EmailAddressIsValid(testemailaddress);
            
            Assert.IsTrue(isEmailValid);
        }

        [TestMethod]
        public void EmailAddressIsValid_Rejects_A_InCorrectly_Formatted_Email_Address()
        {
            //Arrange
            var contact = new Contact();
            string testemailaddress = "test@emai#l.com";
            //Act
            bool isEmailValid = contact.EmailAddressIsValid(testemailaddress);

            Assert.IsFalse(isEmailValid);
        }

        [TestMethod]
        public void ContactFirstName_Is_AllAlphaCharacters_IsTrue()
        {
            //Arrange
            var contact = new Contact();
            contact.FirstName = "Abcdojy";
            //Act
            bool isAllAlphaCharacters = contact.FirstNameIsValid();

            Assert.IsTrue(isAllAlphaCharacters);
        }

        [TestMethod]
        public void ContactFirstName_Is_AllAlphaCharacters_IsFalse()
        {
            //Arrange
            var contact = new Contact();
            contact.FirstName = "Abc2dojy";
            //Act
            bool isAllAlphaCharacters = contact.FirstNameIsValid();

            Assert.IsFalse(isAllAlphaCharacters);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FirstNameIsValid_Is_Blank_IsFalse()
        {
            //Arrange
            var contact = new Contact();
            contact.FirstName = "";
            //Act
            try
            {
                bool isBlank = contact.FirstNameIsValid();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("First Name Cannot Be Null",ex.Message);    
                throw;
            }
            

        }

        [TestMethod]
        public void LastNameIsValid_Is_AllAlphaCharacters_IsTrue()
        {
            //Arrange
            var contact = new Contact();
            string lastName = "Abcdojy";
            //Act
            bool isAllAlphaCharacters = contact.LastNameIsValid(lastName);

            Assert.IsTrue(isAllAlphaCharacters);
        }

        [TestMethod]
        public void LastNameIsValid_Is_AllAlphaCharacters_IsFalse()
        {
            //Arrange
            var contact = new Contact();
            string lastName = "Abc2dojy";
            //Act
            bool isAllAlphaCharacters = contact.LastNameIsValid(lastName);

            Assert.IsFalse(isAllAlphaCharacters);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LastNameIsValid_Is_Blank_IsFalse()
        {
            //Arrange
            var contact = new Contact();
            string lastName = "";
            //Act
            try
            {
                bool isBlank = contact.LastNameIsValid(lastName);

            }
            catch (Exception ex)
            {
                    
                Assert.AreEqual("Last Name Cannot Be Null",ex.Message);
                throw;
            }
           

        }

        [TestMethod]
        public void PhoneNumberIsValid_Handles_A_Correctly_Formatted_Phone()
        {
            //Arrange
            var contact = new Contact();
            string phoneNumber = "453-875-8476";
            //Act
            bool isPhoneValid = contact.PhoneNumberIsValid(phoneNumber);

            Assert.IsTrue(isPhoneValid);
        }

    }
}
