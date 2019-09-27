using System;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace AssetReference.Editor
{
    public class AssetReferenceDropdownState : AdvancedDropdownState
    {
        public SerializedProperty Property { get; }
        public Type AssetType { get; }

        public AssetReferenceDropdownState(Type assetType,SerializedProperty property):base()
        {
            this.Property = property;
            this.AssetType = assetType;
        }
    }
}