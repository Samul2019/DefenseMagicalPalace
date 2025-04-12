/*using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(PlayerThings))]
public class EditorScript : Editor
{
    protected static bool ShowOffsetSettings = true;
    public override void OnInspectorGUI()
    {
        var offsetProperty = serializedObject.FindProperty("water");
        var fireProperty = serializedObject.FindProperty("fire");
        var tornadoProperty = serializedObject.FindProperty("tornado");

        ShowOffsetSettings = EditorGUILayout.Foldout(ShowOffsetSettings, "Offset Settings");

        if (ShowOffsetSettings)
        {
            EditorGUILayout.PropertyField(offsetProperty);
            EditorGUILayout.PropertyField(fireProperty);
            EditorGUILayout.PropertyField(tornadoProperty);

        }

        serializedObject.ApplyModifiedProperties();
    }
}
*/