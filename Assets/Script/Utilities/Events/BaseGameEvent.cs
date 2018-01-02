using System.Collections.Generic;
using UnityEngine;

namespace Interactive.Utilities.Events
{
    [CreateAssetMenu(menuName = "Events/Base")]
    public class BaseGameEvent : ScriptableObject
    {
        private readonly List<BaseGameEventListener> eventListeners = new List<BaseGameEventListener>();

        public void Raise()
        {
            for (var i = eventListeners.Count - 1; i >= 0; i--)
            {
                eventListeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(BaseGameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
            {
                eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(BaseGameEventListener listener)
        {
            if (eventListeners.Contains(listener))
            {
                eventListeners.Remove(listener);
            }
        }
    }
}