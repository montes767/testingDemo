using NUnit.Framework;

namespace myLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        //Las pruebas han de ser atomicas, solo probar un metodo, pero son independientes, basicamente lo que esta en una prueba no esta al nivel de una clase
        public void Add_InputNumbers_ReturnsNumber()
        {
            //1. Arrange, organizar
            var operations = new Operations();

            //2. Act, 
            int result = operations.Add(2, 5);

            //3. Assert

            Assert.That(result, Is.EqualTo(7));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }
        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]

        public void IsEven_InputNumber_ReturnsTrue(int number)
        {
            var operations = new Operations();


            var result = operations.isEven(number);

            Assert.That(result, Is.True);
        }
        [Test]
        [TestCase(2.2, 1.2)]
        [TestCase(2.23, 1.24)]
        public void AddDecimal_InputDoubleNumbers_ReturnsDoubleNumber(double number, double number1)
        {
            {
                Operations operations = new Operations();

                var result = operations.AddDecimal(number, number1);

                Assert.That(result, Is.EqualTo(3.4).Within(0.1));
                //Within= margen de error
                //Assert , lo que sirve para comprobar

            }
        }

        [Test]
        public void GetEvenNumbers_ImputRange_ReturnEvenNumbers()
        {
            //1. Arrange
            Operations operations = new();
            int start = 0;
            int end = 10;

            //2. Act
            var result=operations.GetEvenNumbers(start, end);

            //3. Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result, Is.Not.LessThan(0));
            Assert.That(result, Does.Contain(8));

        }
    }
}
