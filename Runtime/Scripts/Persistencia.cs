using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    //sistema de persistencia síncrono
    public interface Persistence
    {
        public void Send(Event e);
    }

    public class FilePersistence : Persistence
    {
        public void Send(Event e)
        {
            //llamar a la serializacion

        }
    }
}
