using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(FriendlyArrayAttribute))]
public class FriendlyArrayDrawer : PropertyDrawer
{

    const float helpboxHeight = 24.0f;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {

        //EditorGUI.LabelField(position, label);

        object targetObject = property.serializedObject.targetObject;
        Type parentType = targetObject.GetType();
        System.Reflection.FieldInfo fi = parentType.GetField(property.propertyPath);

        if(TypeUtils.IsSubclassOfRawGeneric(typeof(List<>), fi.FieldType))
        {
            Debug.Log("is array");
            // List<> list = (List)fi.GetValue(targetObject);
            // Debug.Log(list);
            // Debug.Log("here");
            Debug.Log(property.arraySize);
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