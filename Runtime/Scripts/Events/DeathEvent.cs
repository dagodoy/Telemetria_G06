using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class DeathEvent : Event
    {
        public float x;
        public float y;

        public DeathEvent()
        {
            tipo = tipoEvento.DEATH;
            nombre = tipo.ToString();

        }

        public DeathEvent X(float X)
        {
            x = X;
            return this;
        }

        public DeathEvent Y(float Y)
        {
            y = Y;
            return this;
        }
    }
}
