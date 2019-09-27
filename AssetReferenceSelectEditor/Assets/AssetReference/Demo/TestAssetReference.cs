using System.Collections;
using System.Collections.Generic;
using AssetReference.Runtime.References;
using UnityEngine;

public class TestAssetReference : MonoBehaviour
{
    [SerializeField] private AssetReferenceMaterial _material;

    [SerializeField] private AssetReferencePrefab _prefab;

    [SerializeField] private AssetReferenceAudioClip _audio;
    [SerializeField] private AssetReferenceTextAsset _textAsset;
    [SerializeField] private AssetReferenceRuntimeAnimatorController _animator;

    [SerializeField] private AssetReferenceTexture _reference;
    [SerializeField] private AssetReferenceShader _assetReferenceShader;
}