using System;

namespace Expendedoras
{
    internal class Cafe : Expendedora
    {
        public Cafe()
        {
            Marca = "Nescafe";
            Saludar();
            Cleardisplay();
            Console.WriteLine("Despierta con {0}", Marca);
        }

    }
}
