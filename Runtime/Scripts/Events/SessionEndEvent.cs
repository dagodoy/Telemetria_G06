using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class SessionEndEvent : Event
    {
        public SessionEndEvent()
        {
            tipo = tipoEvento.SESSION_END; nombre = tipo.ToString();
        }
    }
}
