using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public class JumpEvent : Event
    {
        public float x;
        public float y;

        public JumpEvent()
        {
            tipo = tipoEvento.JUMP;
            nombre = tipo.ToString();

        }

        public JumpEvent X(float X)
        {
            x = X;
            return this;
        }

        public JumpEvent Y(float Y)
        {
            y = Y;
            return this;
        }
    }
}
