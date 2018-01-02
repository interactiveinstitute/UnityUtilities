using System;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class BoolReference : GenericReference<bool>
    {
        public BoolReference()
        { }

        public BoolReference(bool value) : base(value)
        { }
    }
}