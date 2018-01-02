using UnityEditor;

namespace Interactive.Utilities.Variables
{
    [CustomPropertyDrawer(typeof(ColorReference))]
    [CustomPropertyDrawer(typeof(BoolReference))]
    [CustomPropertyDrawer(typeof(IntReference))]
    [CustomPropertyDrawer(typeof(FloatReference))]
    [CustomPropertyDrawer(typeof(StringReference))]
    public class GenericReferenceDrawer : AbstractReferenceDrawer
    { }
}