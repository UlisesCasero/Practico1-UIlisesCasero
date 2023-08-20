using Shared;
using Data_Access_Library.DALs;
using Data_Access_Library.IDALs;
using System;

IDAL_Personas personas = new DAL_Personas();

do
{
    try
    {
        Persona persona = new Persona();
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Ingrese su nombre");
        persona.nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su documento");
        persona.Documento = Console.ReadLine();
        Console.WriteLine("Ingrese su fecha de nacimiento");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime nacimiento))
        {
            persona.nacimiento = nacimiento;
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido. Ingresar en formato yyyy-MM-dd.");
            continue;
        }

        personas.Insert(persona);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Desea continuar (S/N): ");

    }
}
while (Console.ReadLine().ToUpper() == "S");
Console.Clear();
personas.GetPersonas().ForEach(persona => persona.imprimir(persona));

