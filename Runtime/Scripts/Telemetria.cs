using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public class Telemetria
    {
        private static Telemetria instance = null;

        private Persistence[] persistences;

        public static Telemetria Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Telemetria();
                    instance.persistences = new Persistence[1];
                    instance.persistences[0] = new FilePersistence(new JsonSerializer());
                    instance.TrackEvent(new SessionStartEvent());
                }
                return instance;
            }
        }
        //~Telemetria()
        //{
        //    instance.TrackEvent(new SessionEndEvent());
        //}

        public void TrackEvent(Event e)
        {
            foreach(Persistence persistence in persistences)
            {
                persistence.Send(e);
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
}
