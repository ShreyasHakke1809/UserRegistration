using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UserRegMSTest
    {
        [TestMethod]
        [TestCategory("User FirstName")]
        [DataRow("Shubham", "Shubham")]
        [DataRow("shreyas", "First Name is not Valid")]
        [DataRow(" ", "First Name is not Valid")]
        public void FirstNameTest(string userInput, string expected)
        {
            //Act
            string actual = UserReg.ValidFirstName(userInput);

            //Asert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("User LastName")]
        [DataRow("Patil", "Patil")]
        [DataRow("hakke", "Last Name is not Valid")]
        [DataRow(" ", "Last Name is not Valid")]
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
        [TestCategory("User EmailId")]
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", "Email is not Valid")]
        [DataRow("abc@.com.my", "Email is not Valid")]
        [DataRow("abc123@.com", "Email is not Valid")]
        [DataRow("abc123@.com.com", "Email is not Valid")]
        [DataRow("abc()*@gmail.com", "Email is not Valid")]
        [DataRow(".abc@abc.com", "Email is not Valid")]
        [DataRow("abc@%*.com", "Email is not Valid")]
        [DataRow("abc..2002@gmail.com", "Email is not Valid")]
        [DataRow("abc.@gmail.com", "Email is not Valid")]
        [DataRow("abc@abc@gmail.com", "Email is not Valid")]
        [DataRow("abc@gmail.com.1a", "Email is not Valid")]
        [DataRow("abc@gmail.com.aa.au", "Email is not Valid")]
        public void TestUserEmailId(string userData, string expected)
        {
            ///Act
            string actual = UserReg.ValidEmail(userData);

            ///Asert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("User Password")]
        [TestMethod]
        [DataRow("Abcd@1234", "Abcd@1234")]
        [DataRow("hjGHJv12#", "hjGHJv12#")]
        [DataRow("?hjghjGHJGHgj21345GH", "?hjghjGHJGHgj21345GH")]
        [DataRow("GHJKFGJFYJ", "Password is not Valid")]
        [DataRow("GHJGHjghjfgj", "Password is not Valid")]
        [DataRow("hgfgh#123554", "Password is not Valid")]
        [DataRow("HGgf@#1", "Password is not Valid")]
        [DataRow(" ", "Password is not Valid")]
        public void TestUserPassword(string userInput, string expected)
        {
            ///Act
            string actual = UserReg.ValidPassword(userInput);

            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}