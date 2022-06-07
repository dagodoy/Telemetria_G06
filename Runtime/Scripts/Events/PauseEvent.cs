using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class PauseEvent : Event
    {
        public PauseEvent()
        {
            tipo = tipoEvento.PAUSE;
            nombre = tipo.ToString();

        }
    }
}
