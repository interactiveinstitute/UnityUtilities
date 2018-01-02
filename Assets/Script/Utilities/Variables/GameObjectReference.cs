using System;
using UnityEngine;

namespace Interactive.Utilities.Variables
{
    [Serializable]
    public class GameObjectRefernece : GenericReference<GameObject>
    {
        public GameObjectRefernece()
        { }

        public GameObjectRefernece(GameObject value) : base(value)
        { }
    }
}