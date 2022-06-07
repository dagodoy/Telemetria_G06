using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class LevelStartEvent : Event
    {
        //Guarda el indice de la escena en la que ocurre
        public int nivel;
        public LevelStartEvent()
        {
            tipo = tipoEvento.LEVEL_START;
            nombre = tipo.ToString();

        }

        public LevelStartEvent Nivel(int n)
        {
            nivel = n;
            return this;
        }

    }
}
