using System;
using UnityEngine;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    [CreateAssetMenu(menuName = "Variables/Color")]
    public class ColorVariable : GenericVariable<Color>
    {
    }
}