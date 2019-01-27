using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(FriendlyArrayAttribute))]
public class FriendlyArrayDrawer : PropertyDrawer
{

    const float helpboxHeight = 24.0f;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //EditorGUI.LabelField(position, label);
        
        if(property.isArray)
        {
            Debug.Log("is array");
        }
        else
        {
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.HelpBox(position, "ERROR: '" + label.text + "' field is not Array or List.", MessageType.Error);
            position.y += helpboxHeight;
            EditorGUI.EndProperty();
        }
        //// First get the attribute since it contains the range for the slider
        //MyRangeAttribute range = (MyRangeAttribute)attribute;

        //// Now draw the property as a Slider or an IntSlider based on whether it's a float or integer.
        //if (property.propertyType == SerializedPropertyType.Float)
        //    EditorGUI.Slider(position, property, range.min, range.max, label);
        //else if (property.propertyType == SerializedPropertyType.Integer)
        //    EditorGUI.IntSlider(position, property, (int)range.min, (int)range.max, label);
        //else
        //EditorGUI.LabelField(position, label.text, "Use MyRange with float or int.");
    }
}