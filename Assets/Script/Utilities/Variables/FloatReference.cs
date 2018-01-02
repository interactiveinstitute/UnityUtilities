using System;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class FloatReference : GenericReference<float>
    {
        public FloatReference()
        { }

        public FloatReference(float value) : base(value)
        { }
    }
}