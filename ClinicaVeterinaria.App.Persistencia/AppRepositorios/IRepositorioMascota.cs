using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;


namespace ClinicaVeterinaria.App.Persistencia
{

    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> getAllMascotas();
        Mascota getMascotas(int IdMascota);
        Mascota addMascotas(Mascota mascota);
        Mascota editMascotas(Mascota mascota);
        void removeMascotas(int IdMascota);
        void AddMascota(Mascota mascota);
    }
}