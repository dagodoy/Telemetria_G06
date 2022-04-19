using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    [System.Serializable]
    public abstract class Event
    {
        public enum tipoEvento { SESSIONSTART, SESSIONEND, LEVELSTART, LEVELEND, PAUSE, DEATH, JUMP, COLLISION }

        public tipoEvento tipo;
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
        public SessionStartEvent() { tipo = tipoEvento.SESSIONSTART; }
    }
    [System.Serializable]
    public class SessionEndEvent : Event
    {
        public SessionEndEvent() { tipo = tipoEvento.SESSIONEND; }
    }
    [System.Serializable]
    public class LevelStartEvent : Event
    {
        //Guarda el indice de la escena en la que ocurre
        public int nivel;
        public LevelStartEvent()
        {
            tipo = tipoEvento.LEVELSTART;
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
            tipo = tipoEvento.LEVELEND;
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

