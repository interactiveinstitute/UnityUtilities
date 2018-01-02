using UnityEngine;

namespace Interactive.Utilities.Events
{
    public abstract class GenericListener<T> : MonoBehaviour
    {
        public abstract void OnEventRaised(T value);
    }
}