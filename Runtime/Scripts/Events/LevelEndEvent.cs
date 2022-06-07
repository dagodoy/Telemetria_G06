using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class LevelEndEvent : Event
    {
        public int nivel;

        public LevelEndEvent()
        {
            tipo = tipoEvento.LEVEL_END;
            nombre = tipo.ToString();

        }

        public LevelEndEvent Nivel(int n)
        {
            nivel = n;
            return this;
        }
    }
}
