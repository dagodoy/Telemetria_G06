using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public abstract class Event
    {
        public enum tipoEvento { SESSION_START, SESSION_END, LEVEL_START, LEVEL_END, PAUSE, UNPAUSE, DEATH, JUMP, COLLISION, PLAYER_POSITION}

        public tipoEvento tipo;
        public string nombre;
        public float tiempo;
        public long sesion;
        public Event()
        {
            tiempo = Time.realtimeSinceStartup;
            sesion = UnityEngine.Analytics.AnalyticsSessionInfo.sessionId;
        }
    }
}

