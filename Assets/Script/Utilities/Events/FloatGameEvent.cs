using UnityEngine;
using System;

namespace Interactive.Utilities.Events
{
    [Serializable]
    [CreateAssetMenu(menuName = "Events/Float")]
    public class FloatGameEvent : GenericGameEvent<float>
    {
    }
}