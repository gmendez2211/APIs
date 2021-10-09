using EjecicioSeccionB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjecicioSeccionB.Repository.iRepository
{
    public interface iPersonaRepository
    {
        bool CreaPersona(PersonaModel persona); //Metodo para crear personas en la base de datos
        ICollection<PersonaModel> GetPersonaModels(); //Lista todos los registros de la tabla
        PersonaModel GetPersona(int pCodigoInterno); //Busca por código a la persona
        bool ActualizarPersona(PersonaModel persona); //Actualiza el registro en la base de datos
        bool BorrarPersona(PersonaModel persona);//Borra un registro. IMPORTANTE: se debe realizar borrado lógico de los registro.
        bool GuardaPersona();

    }
}
