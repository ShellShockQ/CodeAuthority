using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA.BusinessLogic;
namespace CAUnitTests
{
    using CA.BusinessLogic.Helpers;
   
    [TestClass]
    public class HelpersTests
    {

        [TestMethod]
        public void WhenAValidContactDateIsPassedInTheValidationHelperReturnsTrue ()
        {
            //Arrange
            ValidContactDate validContactDate = new ValidContactDate();
            DateTime tommorrow = DateTime.Today.AddDays(1);
            string sDay = tommorrow.ToShortDateString();
            string sNoon = "12:00PM";
            DateTime testDate = Convert.ToDateTime(sDay+" "+sNoon);
     
            //Act
            bool isValid = validContactDate.IsValid(testDate);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void WhenAInValidContactDateIsPassedInTheValidationHelperReturnsTrue()
        {
            //Arrange
            ValidContactDate validContactDate = new ValidContactDate();
            DateTime tommorrow = DateTime.Today.AddDays(1);
            string sDay = tommorrow.ToShortDateString();
            string sNoon = "7:00PM";
            DateTime testDate = Convert.ToDateTime(sDay + " " + sNoon);

            //Act
            bool isValid = validContactDate.IsValid(testDate);

            //Assert
            Assert.IsFalse(isValid);
        }
   
        [TestMethod]
        public void WhenAContactDateThatHasPassedIsGivenTheValidationHelperReturnsTrue()
        {
            //Arrange
            ValidContactDate validContactDate = new ValidContactDate();
            DateTime tommorrow = DateTime.Today.AddDays(-1);
            string sDay = tommorrow.ToShortDateString();
            string sNoon = "12:00PM";
            DateTime testDate = Convert.ToDateTime(sDay + " " + sNoon);

            //Act
            bool isValid = validContactDate.IsValid(testDate);

            //Assert
            Assert.IsFalse(isValid);
        }
    }
}
