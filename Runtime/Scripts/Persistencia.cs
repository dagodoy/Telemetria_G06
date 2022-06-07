using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Grupo06
{
    //sistema de persistencia síncrono
    public abstract class Persistence
    {
        public Persistence(Serializer s)
        {
            serializer = s;
        }
        public abstract void Send(Event e);
        protected Serializer serializer;

    }
}
