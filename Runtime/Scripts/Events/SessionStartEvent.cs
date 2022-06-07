using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class SessionStartEvent : Event
    {
        public SessionStartEvent()
        {
            tipo = tipoEvento.SESSION_START; nombre = tipo.ToString();
        }
    }
}
