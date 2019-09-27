using System;
using UnityEditor;
using UnityEngine;
using WeakReference = AssetReference.Runtime.References.WeakReference;

namespace AssetReference.Editor
{
    [CustomPropertyDrawer(typeof(WeakReference), true)]
    public class WeakReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Type referenceType = fieldInfo.FieldType.BaseType.GenericTypeArguments[0];
            SerializedProperty guidProperty = property.FindPropertyRelative("_addressGuid");
            Rect guidRect = new Rect()
            {
                x = position.x,
                y = position.y,
                height = 16,
                width = position.width
            };

            string guid = guidProperty.stringValue;
            
            EditorGUI.BeginChangeCheck();
            {
                guid = FileField(property,guidRect, property.displayName, guidProperty.stringValue, referenceType);
            }
            if (EditorGUI.EndChangeCheck())
            {
                guidProperty.stringValue = guid;
            }

            property.serializedObject.ApplyModifiedProperties();
        }
        
        private string FileField(SerializedProperty property, Rect position, string label, string guid, Type type)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            UnityEngine.Object file = AssetDatabase.LoadAssetAtPath(path, type);
            EditorGUI.BeginChangeCheck();
            {
                file = EditorGUI.ObjectField(new Rect(position.x,position.y,position.width - 80,position.height), label, file, type, false);
                if (EditorGUI.DropdownButton(new Rect(position.xMax - 80,position.y,60,position.height), new GUIContent("Select"),FocusType.Passive))
                {
                    SelectAssetReferenceWindow.Show(new AssetReferenceDropdownState(type,property), position);
                }

                if (GUI.Button(new Rect(position.xMax - 20,position.y,20,position.height), new GUIContent("X")))
                {
                    file = null;
                    path = string.Empty;
                    guid = string.Empty;
                }
            }

            if (EditorGUI.EndChangeCheck())
            {
                path = AssetDatabase.GetAssetPath(file);
                guid = AssetDatabase.AssetPathToGUID(path);
            }
            return guid;
        }
    }
}