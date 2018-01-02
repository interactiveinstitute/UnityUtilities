using System;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class StringReference : GenericReference<string>
    {
        public StringReference()
        { }

        public StringReference(string value) : base(value)
        { }
    }
}