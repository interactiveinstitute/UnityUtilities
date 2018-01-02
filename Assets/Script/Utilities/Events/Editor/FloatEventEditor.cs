using UnityEditor;

namespace Interactive.Utilities.Events
{
    [CustomEditor(typeof(FloatGameEvent))]
    public class FloatEventEditor : GenericEventEditor<float, FloatGameEvent>
    {
    }
}
