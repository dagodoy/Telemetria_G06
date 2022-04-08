using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public class FilePersistence : Persistence
    {
        public FilePersistence(Serializer s) : base(s) { }
        public override void Send(Event e)
        {
            serializer.Serialize(e);
        }

    }
}
