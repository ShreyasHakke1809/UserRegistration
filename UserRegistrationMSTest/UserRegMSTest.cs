using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UserRegMSTest
    {
        [TestMethod]
        [TestCategory("User FirstName")]
        [DataRow("Shreyas", "Shreyas")]
        [DataRow("shreyas", "First Name is not Valid")]
        [DataRow("", "First Name is not Valid")]
        public void FirstNameTest(string userInput, string expected)
        {
            //Act
            string actual = UserReg.ValidFirstName(userInput);

            //Asert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("User LastName")]
        [DataRow("Hakke", "Hakke")]
        [DataRow("Patil", "Patil")]
        [DataRow("hakke", "Last Name is not Valid")]
        [DataRow("", "Last Name is not Valid")]
        public void LastNameTest(string userInput, string expected)
        {
            //Act
            string actual = UserReg.ValidLastName(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("User PhoneNumber")]
        [DataRow("+91-9673215173", "+91-9673215173")]
        [DataRow("91-9673215173", "91-9673215173")]
        [DataRow("+919673215173", "Mobile Number is not Valid")]
        [DataRow("9673215173", "Mobile Number is not Valid")]
        [DataRow("919673215173", "Mobile Number is not Valid")]
        [DataRow(" ", "Mobile Number is not Valid")]

        public void PhoneNumberTest(string userInput, string expected)
        {
            //Act
            string actual = UserReg.ValidMobileNumber(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}