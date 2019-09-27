using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace AssetReference.Editor
{
    public class AssetReferenceDropdownAssetItem : AdvancedDropdownItem
    {
        public string AssetPath { get; }
        
        public string FolderPath { get; }

        public AssetReferenceDropdownFolderItem ParentFolder { get; set; }
        
        public AssetReferenceDropdownAssetItem(string assetPath,string ItemName) : base(ItemName)
        {
            this.AssetPath = assetPath;
            this.FolderPath = PathUtility.GetAssetDirectoryName(assetPath);
            this.icon = AssetDatabase.GetCachedIcon(assetPath) as Texture2D;
        }
    }
}