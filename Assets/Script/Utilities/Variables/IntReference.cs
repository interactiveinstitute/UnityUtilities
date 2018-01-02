using System;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class IntReference : GenericReference<int>
    {
        public IntReference()
        { }

        public IntReference(int value) : base(value)
        { }
    }
}