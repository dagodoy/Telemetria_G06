using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public interface Serializer
    {
        public string Serialize(Event e);
        public string getExtension();
    }
}
