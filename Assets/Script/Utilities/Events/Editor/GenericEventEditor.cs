using UnityEngine;
using UnityEditor;

namespace Interactive.Utilities.Events
{
    public abstract class GenericEventEditor<TType, TEvent> : Editor where TEvent : GenericGameEvent<TType>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var e = target as TEvent;

            if (e != null && GUILayout.Button("Raise"))
            {
                e.Raise(e.TestValue);
            }
        }
    }
}