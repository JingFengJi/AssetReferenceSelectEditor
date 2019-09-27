using System;

namespace AssetReference.Runtime.References
{
    [Serializable]
    public class AssetReference<T> : WeakReference where T : UnityEngine.Object
    {
        
    }
}