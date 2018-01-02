using UnityEngine;
using UnityEngine.Events;

namespace Interactive.Utilities.Events
{
    public class BaseGameEventListener : MonoBehaviour
    {
        public BaseGameEvent gameEvent;
        public UnityEvent response;

        private void OnEnable()
        {
            if (gameEvent != null)
            {
                gameEvent.RegisterListener(this);
            }
        }

        private void OnDisable()
        {
            if (gameEvent != null)
            {
                gameEvent.UnregisterListener(this);
            }
        }

        public virtual void OnEventRaised()
        {
            response.Invoke();
        }
    }
}