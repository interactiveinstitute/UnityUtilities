using System.Collections.Generic;
using UnityEngine;

namespace Interactive.Utilities.Events
{
    public abstract class GenericGameEvent<T> : ScriptableObject
    {
        [SerializeField]
        public T TestValue;

        private readonly List<GenericListener<T>> eventListeners = new List<GenericListener<T>>();

        public void Raise(T value)
        {
            for (var i = eventListeners.Count - 1; i >= 0; i--)
            {
                eventListeners[i].OnEventRaised(value);
            }
        }

        public void RegisterListener(GenericListener<T> listener)
        {
            if (!eventListeners.Contains(listener))
            {
                eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(GenericListener<T> listener)
        {
            if (eventListeners.Contains(listener))
            {
                eventListeners.Remove(listener);
            }
        }
    }
}