using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public class Telemetria : MonoBehaviour
    {
        private static Telemetria instance = null;

        private Telemetria() { }

        public static Telemetria Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Telemetria();
                }
                return instance;
            }
        }

        public LevelStartEvent LevelStart()
        {
            return new LevelStartEvent();
        }
        public LevelEndEvent LevelEnd()
        {
            return new LevelEndEvent();
        }
        public PauseEvent Pause()
        {
            return new PauseEvent();
        }
        public DeathEvent Death()
        {
            return new DeathEvent();
        }
        public JumpEvent Jump()
        {
            return new JumpEvent();
        }
        public CollisionEvent Collision()
        {
            return new CollisionEvent();
        }
    }

    /// <summary>
    /// DOLOR
    /// </summary>

    public abstract class Event
    {
        public float tiempo { get; set; }
        public int sesion { get; set; }

        public Event()
        {
            tiempo = Time.realtimeSinceStartup;
            sesion = 3;
        }
    }

    public class LevelStartEvent : Event
    {
        public int nivel;

        public LevelStartEvent Nivel(int n)
        {
            nivel = n;
            return this;
        }
    }

    public class LevelEndEvent : Event
    {
        public int nivel;

        public LevelEndEvent Nivel(int n)
        {
            nivel = n;
            return this;
        }
    }

    public class PauseEvent : Event { }

    public class DeathEvent : Event
    {
        public float x;
        public float y;

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
