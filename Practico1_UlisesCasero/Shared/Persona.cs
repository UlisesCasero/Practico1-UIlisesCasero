namespace Shared
{
    public class Persona
    {
        public string nombre { get; set; }

        private string documento = "";
        public string Documento {
            get { return documento; } 
            set {
                if (value.Length < 7)
                    throw new Exception("Formato de documento incorrecto.");
                else
                    documento = value.ToUpper();
            }
        }

        public DateTime nacimiento;

        /*private int edad = 0;
        public int Edad {
            get { return edad; }
            set {
                if (value > 110)
                    throw new Exception("La edad no debe ser mayor a 110.");
                if (value < 1)
                    throw new Exception("La edad no debe ser menor a 1.");
                else
                    edad = value;
            }
        }*/

        public void imprimir(Persona persona) {
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.WriteLine("Documento: " + persona.Documento);
            Console.WriteLine("Fecha nacimiento: " + persona.nacimiento);
            Console.WriteLine("------------------------------------");
        }

    }
}