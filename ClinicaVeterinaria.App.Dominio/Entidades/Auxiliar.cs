using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Auxiliar : Persona
    {
        public DateTime HorarioLaboral{get; set;}
        public string LicenciaProfesional{get; set;}
        public string Especializacion{get; set;}
        public int EstadoVeterinario{get; set;}
        //public Mascota mascota{get; set;}
    }
}