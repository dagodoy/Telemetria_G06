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
                    instance.persistences = new Persistence[2];
                    instance.persistences[0] = new FilePersistence(new JsonSerializer());
                    instance.persistences[1] = new FilePersistence(new BinarySerializer());
                }
                return instance;
            }
        }

        public void TrackEvent(Event e)
        {
            //Debug.Log(e.name);
            foreach(Persistence persistence in persistences)
            {
                persistence.Send(e);
            }
        }
        public SessionStartEvent SessionStart()
        {
            return new SessionStartEvent();
        }
        public SessionEndEvent SessionEnd()
        {
            return new SessionEndEvent();
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
        public UnPauseEvent UnPause()
        {
            return new UnPauseEvent();
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
        public PlayerPosEvent PlayerPosition()
        {
            return new PlayerPosEvent();
        }
    }
}
