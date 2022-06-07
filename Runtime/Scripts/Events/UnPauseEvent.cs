using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class UnPauseEvent : Event
    {
        public UnPauseEvent()
        {
            tipo = tipoEvento.UNPAUSE;
            nombre = tipo.ToString();

        }
    }
}
