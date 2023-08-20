using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Data_Access_Library.IDALs {
    public interface IDAL_Personas {

        void Insert(Persona persona);

        List<Persona> GetPersonas();
        
    }
}
