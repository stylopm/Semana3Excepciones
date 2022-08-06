using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    internal class AddElementException: Exception
    {
        public AddElementException(string message): base(message)
        {
            Console.WriteLine("No puedes agregar elementos no autorizados", message);
        }

    }
}
