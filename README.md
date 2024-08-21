# Primera expendedora
Código en C# de máquina expendedora
  [Harry Styles](youtube.com/harrystylesvevo)
  [
  ![image](https://github.com/user-attachments/assets/0197cb49-73a2-43f9-8269-f1b7b7ad2f82)
  
  ] (https://m.media-amazon.com/images/I/61v6lSOpccL._UF1000,1000_QL80_.jpg)
````
using System;
using System.Threading; //sirve para el tiempo de espera de la pantalla

namespace Expendedoras
{
    //clase
    public abstract class Expendedora
    {
        #region atributos
        //atributos 
        private string _marca;
        private sbyte _temperatura;
        private ushort _cantproductos;
        private float _precios;
        #endregion
        #region encapsulado
        public sbyte Temperatura //nos sirve para encapsular la propiedad o atributo y protegerla de valores que no queremos que tome
        { 
            get => _temperatura;
            set
            {
                if (value >= 10 && value < 21)
                {
                    _temperatura = value;
                }
                else//hace que no nos salgamos del intervalo y en caso de ello nos manda a un valor por default
                {
                    _temperatura = 18;
                }
             
            }
        }
        public string Marca { get => _marca; set => _marca = value; }
        #endregion

        #region constructores
        public Expendedora() 
          
            //CONSTRUCTOR BASE
            //en el constructor inicializamos todos los atributos
        {
            /*
          Temperatura = 25;
          _precios = 15;
          Marca = "AWS";
          Saludar();
          string codigo = Mostrarproductos();
          //Cleardisplay();
          Mostrarprecio(codigo);
          */
        }

        public Expendedora ( bool mantenimiento) //podemos poner otro constructor siempre y cuando tenga un atributo
        { 
            if (mantenimiento)
            {
                Console.WriteLine("Ingresa la nueva temperatura: ");
                Temperatura = sbyte.Parse (Console.ReadLine());
                Cleardisplay();
                Console.WriteLine("La nueva temperatura es: {0} [°C]", Temperatura);
            }
        }
        #endregion
        #region metodos
        public void Saludar()
        {
            Console.WriteLine("{0}  Bienvenido, elige tu producto  \n temperatura {1} [°C]: ", Marca, Temperatura);
        }
        public string Mostrarproductos()
        {
            string codigo; //variable local porque la declaramos dentro de un método, no la podemos ocupar si no se ha inicializado
            Console.WriteLine("2A: Papas \t 3C: Chocolate");
            Console.WriteLine("Ingrese el código del producto");
            codigo = Console.ReadLine();
            return codigo;
        }
        public void Mostrarprecio(string codigo)
        {
            switch (codigo)
            {
                case "2A":
                    Console.WriteLine("El precio es : {0}", _precios);
                    break;
                case "3C":
                    Console.WriteLine("El precio es: {0}", _precios += 5);
                    break;
                default:
                    Console.WriteLine("El producto no fue encontrado");
                    break;
            }
        }
        public void Cleardisplay()
        {
            Thread.Sleep(5000);
            Console.Clear();
        }
        #endregion



       

        

        
    }
}

````
