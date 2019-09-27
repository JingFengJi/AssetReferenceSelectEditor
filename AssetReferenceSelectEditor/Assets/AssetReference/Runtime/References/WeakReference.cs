using System;
using UnityEngine;

namespace AssetReference.Runtime.References
{
    [Serializable]
    public abstract class WeakReference
    {
        /// <summary>
        /// 资源Guid
        /// </summary>
        [SerializeField] protected string _addressGuid;
        
        /// <summary>
        /// 资源Guid，也作为该资源的加载地址
        /// </summary>
        public string AddressGuid
        {
            get { return _addressGuid; }
            set { _addressGuid = value; }
        }
        
        //TODO:Your Load Function
        
        //TODO:Your Unload Function
    }
}