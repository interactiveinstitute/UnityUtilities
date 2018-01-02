#pragma warning disable 0649

using System;
using UnityEngine;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public abstract class GenericReference<T>
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private T constantValue;
        [SerializeField]
        private GenericVariable<T> variable;

        protected GenericReference()
        { }

        protected GenericReference(T value)
        {
            useConstant = true;
            constantValue = value;
        }

        public T Value
        {
            get { return useConstant ? constantValue : variable.Value; }
        }

        public static implicit operator T(GenericReference<T> reference)
        {
            return reference.Value;
        }
    }
}