using System;
using UnityEngine;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class ColorReference : GenericReference<Color>
    {
        public ColorReference()
        { }

        public ColorReference(Color value) : base(value)
        { }
    }
}