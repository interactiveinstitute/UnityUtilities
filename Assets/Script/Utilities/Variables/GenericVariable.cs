using UnityEngine;

namespace Interactive.Utilities.Variables
{
    public abstract class GenericVariable<T> : ScriptableObject
    {
        [Multiline]
        [SerializeField]
        public string developerDescription = "";

        [SerializeField]
        public T defaultValue;

        [SerializeField]
        private T currentValue;

        public T Value
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public virtual void OnEnable()
        {
            currentValue = defaultValue;
        }
    }
}