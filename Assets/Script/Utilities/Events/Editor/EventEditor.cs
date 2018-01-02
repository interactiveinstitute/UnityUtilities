using UnityEngine;
using UnityEditor;

namespace Interactive.Utilities.Events
{
    [CustomEditor(typeof(BaseGameEvent))]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var e = target as BaseGameEvent;

            if (e != null && GUILayout.Button("Raise"))
            {
                e.Raise();
            }
        }
    }
}