using NUnit.Framework;
namespace myLibrary
{
    [TestFixture]
    internal class CustomerNUnitTest
    {
        [Test]
        public void FullName_ReturnFullName()
        {
            //1. Iniciar la prueba, Arrange
            Customer customer = new Customer();

            //2. Act, lo que vamos a comprobar
            string result = customer.FullName;

            //3. Assert, comprobar que salga lo que le estamos pasando
            Assert.That(result, Is.WhiteSpace);


        }

        [Test]
        public void FullName_ReturnFullName2()
        {
            Customer customer = new Customer()
            {
                FirstName = "Jhon",
                LastName = "Fhilip"
            };

            string result = customer.FullName;

            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.Contain("Jhon"));
            Assert.That(result, Does.EndWith("Fhilip"));
            Assert.That(result, Is.EqualTo("jhon fhilip").IgnoreCase);

        }
    }
}
