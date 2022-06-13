using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class CollisionEvent : Event
    {
        public int id;

        public CollisionEvent()
        {
            tipo = tipoEvento.COLLISION;
            nombre = tipo.ToString();

        }

        public CollisionEvent Id(int identificador)
        {
            id = identificador;
            return this;
        }
    }
}
