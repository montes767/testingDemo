using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Operations
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecimal(double number, double number2)
        {
            return number + number2;
        }

        // Uso de IList porque es la interfaz, sirve para cambiar el tipo de lista, no tener que devolver siempre un list, puedes devolver todos los usos de esa interfaz, por ejemplo ArrayList
        public IList<int> GetEvenNumbers(int start, int end)
        {
            return Enumerable.Range(start, end)
                .Where(isEven)
                .ToList();
            //Hacer metodo de prueba sobre esta lista que devuelve, buscar por internet metodos NUnit para arrays

        }

    }
}
