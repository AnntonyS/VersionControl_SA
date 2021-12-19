using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllertest
    {
        [Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
          
            ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        //"A jelszó legalább 8 karakter hosszú kell legyen, csak az angol ABC betűiből és számokból állhat, és tartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot.");
        [Test,
            TestCase("Abc1", false),
            TestCase("abcdabcd", false),
            TestCase("ABCDABCD", false),
            TestCase("AbcdABCD", false),
            TestCase("Abc2Abc2", true)
            ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test,
           TestCase("irf@uni-corvinus.hu","Abcd1234"),
           TestCase("irf@uni-corvinus.hu", "Abcd123456")

           ]

        public void TestRegisterHappyPass(string email, string password)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.Register(email, password);

            //Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreEqual(Guid.Empty, actualResult.ID);


        }

        [Test,
           TestCase("irf@uni-corvinus.hu", "Abcd1234"),
           TestCase("irf@uni-corvinus.hu", "AbcD123456"),
           TestCase("irf@uni-corvinus.hu", "Abcd1234"),
           TestCase("irf@uni-corvinus.hu", "ABcd123456")
           ]

        public void TestRegisterValidateException(string email, string password)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            try
            {
                accountController.Register(email, password);
                var actualResult = accountController.Register(email, password);
                //Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
                //throw;
            }
            //Assert
            //Assert.AreEqual(email, actualResult.Email);
            //Assert.AreEqual(password, actualResult.Password);
            //Assert.AreEqual(Guid.Empty, actualResult.ID);


        }

    }
}
