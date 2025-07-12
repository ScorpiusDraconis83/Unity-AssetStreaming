// Copyright (c) Meta Platforms, Inc. and affiliates.
// Use of the material below is subject to the terms of the MIT License
// https://github.com/oculus-samples/Unity-AssetStreaming/tree/main/Assets/AssetStreaming/LICENSE

using Meta.XR.Samples;
using UnityEngine;
using UnityEngine.AddressableAssets;

[MetaCodeSample("AssetStreaming")]
public class Startup : MonoBehaviour
{
    [SerializeField]
    private AssetReference nextScene = null;
    void Start()
    {
        nextScene.LoadSceneAsync();
    }
}
