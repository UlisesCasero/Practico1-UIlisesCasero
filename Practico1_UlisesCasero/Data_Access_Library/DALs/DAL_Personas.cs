using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Data_Access_Library.IDALs;

namespace Data_Access_Library.DALs
{
    public class DAL_Personas : IDAL_Personas {
        private List<Persona> personas = new List<Persona>();

        public List<Persona> ordendarPorEdad(List<Persona> personas)
        {
            List<Persona> Ordendados = personas.OrderBy(p => calcularEdad(p.nacimiento)).ToList();
            return Ordendados;
        }

        public int calcularEdad(DateTime nacimiento) {
            DateTime actual = DateTime.Today;
            int edad = actual.Year - nacimiento.Year;

            if (actual < nacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public List<Persona> GetPersonas() {
            List<Persona> personasOrdenado = this.ordendarPorEdad(personas);

            return personasOrdenado;
        }

        public void Insert(Persona persona)
        {
            personas.Add(persona);
        }
        
    }
}
