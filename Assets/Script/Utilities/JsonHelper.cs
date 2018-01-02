using UnityEngine;
using System;

namespace Interactive.Utilities
{
    public static class JsonHelper
    {
        public static T[] GetJsonArray<T>(string json)
        {
            var newJson = "{ \"array\": " + json + "}";
            var wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
            return wrapper.array;
        }

        [Serializable]
        private class Wrapper<T>
        {
            //Array is assigned to from the json deserializer so disable warning that array is never accessed
            #pragma warning disable 0649
            public T[] array;
        }
    }
}