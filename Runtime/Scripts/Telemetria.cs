using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grupo06
{
    public class Telemetria : MonoBehaviour
    {
        private static Telemetria instance = null;

        private Persistence[] persistences;

        private Telemetria() 
        {
            persistences = new Persistence[1];
            persistences[0] = new FilePersistence(new JsonSerializer());

        }

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

        public void TrackEvent()
        {

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
