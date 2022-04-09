using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public abstract class Event
    {
        public enum tipoEvento { LEVELSTART, LEVELEND, PAUSE, DEATH, JUMP, COLLISION }

        public float tiempo;
        public tipoEvento tipo;
        public long sesion;
        public Event()
        {
            tiempo = Time.realtimeSinceStartup;
            sesion = UnityEngine.Analytics.AnalyticsSessionInfo.sessionId;
        }
        public virtual string toJson() { return "pingo"; }
    }

    public class LevelStartEvent : Event
    {
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

        public override string toJson()
        {
            return "LevelStart " + base.toJson() + nivel; 
        }
    }

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

    public class PauseEvent : Event {
        public PauseEvent()
        {
            tipo = tipoEvento.PAUSE;
        }
    }

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

        public CollisionEvent Id(string etiqueta)
        {
            tag = etiqueta;
            return this;
        }
    }
}

