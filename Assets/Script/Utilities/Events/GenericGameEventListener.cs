using UnityEngine.Events;

namespace Interactive.Utilities.Events
{
    public abstract class GenericGameEventListener<T, TGameEvent, TUnityEvent> : GenericListener<T> where TGameEvent : GenericGameEvent<T> where TUnityEvent : UnityEvent<T>
    {
        public TGameEvent gameEvent;
        public TUnityEvent response;

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

        public override void OnEventRaised(T value)
        {
            response.Invoke(value);
        }
    }
}