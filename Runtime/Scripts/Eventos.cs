using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public abstract class Event
    {
        public enum tipoEvento { SESSION_START, SESSION_END, LEVEL_START, LEVEL_END, PAUSE, UNPAUSE, DEATH, JUMP, COLLISION }

        protected tipoEvento tipo;
        public string nombre;
        public float tiempo;
        public long sesion;
        public Event()
        {
            tiempo = Time.realtimeSinceStartup;
            sesion = UnityEngine.Analytics.AnalyticsSessionInfo.sessionId;
        }
    }
    [System.Serializable]
    public class SessionStartEvent : Event
    {
        public SessionStartEvent() { tipo = tipoEvento.SESSION_START; nombre = tipo.ToString();
        }
    }
    [System.Serializable]
    public class SessionEndEvent : Event
    {
        public SessionEndEvent() { tipo = tipoEvento.SESSION_END; nombre = tipo.ToString();
        }
    }
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

    [System.Serializable]
    public class PauseEvent : Event {
        public PauseEvent()
        {
            tipo = tipoEvento.PAUSE;
            nombre = tipo.ToString();

        }
    }

    [System.Serializable]
    public class UnPauseEvent : Event
    {
        public UnPauseEvent()
        {
            tipo = tipoEvento.UNPAUSE;
            nombre = tipo.ToString();

        }
    }

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

    [System.Serializable]
    public class CollisionEvent : Event
    {
        public int id;
        public string tag;

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

        public CollisionEvent Tag(string etiqueta)
        {
            tag = etiqueta;
            return this;
        }
    }
}

