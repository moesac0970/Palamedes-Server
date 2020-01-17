using NUnit.Framework;
using Palamedes.Lib.Extensions;

namespace Palamedes.UnitTests
{
    public class ValidationTest
    {
        private Validation _validation;


        [SetUp]
        public void Setup()
        {
            _validation = new Validation();
        }

        [Test]
        public void ValidEmailTest()
        {
            string email = "SeppeHollants@pm.me";
            bool result;

            result = _validation.IsValidEmailAddress(email);

            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidEmailTest()
        {
            string email = "Vroem/Vroem@Tuut\\Tuut";
            bool result;

            result = _validation.IsValidEmailAddress(email);

            Assert.IsFalse(result);
        }

        [Test]
        public void ValidPasswordTest()
        {
            string password = "SRePPeX123#";
            bool result;

            result = _validation.IsValidPassworld(password);

            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidPasswordTest()
        {
            string password = "cumquat";
            bool result;

            result = _validation.IsValidPassworld(password);

            Assert.IsFalse(result);
        }

        [Test]
        public void ValidUrlTest()
        {
            string url = "http://dl.sepp.dev/fy";
            bool result;

            result = _validation.IsValidUrl(url);

            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidUrlTest()
        {
            string url = "Taco/bel";
            bool result;

            result = _validation.IsValidUrl(url);

            Assert.IsFalse(result);
        }

        [Test]
        public void HtmlTest()
        {
            string inject = "this very long strong does not contain html trust me i am very valid and trustworthy xoxox";
            bool result;

            result = _validation.ContainsHtmlTags(inject);

            Assert.IsFalse(result);
        }

        [Test]
        public void ContainsHtmlTest()
        {
            string inject = "</input><script>alert('Injected!');</script>";
            bool result;

            result = _validation.ContainsHtmlTags(inject);

            Assert.IsTrue(result);
        }

        [Test]
        public void ValidPhoneTest()
        {
            string number = "+32468000666";
            bool result;

            result = _validation.IsValidPhoneNumber(number);

            Assert.IsTrue(result);
        }

        [Test]
        public void InvalidPhoneTest()
        {
            string number = "46800666";
            bool result;

            result = _validation.IsValidPhoneNumber(number);

            Assert.IsFalse(result);
        }

    }
}
