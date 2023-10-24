using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessControls : MonoBehaviour
{
    [SerializeField] private Volume postProcessingVolume;
    
    private Vignette _vignette;
    private ColorAdjustments _colorAdjustments;

    Transform player;
    Transform monster;

    private void Start()
    {
        postProcessingVolume.profile.TryGet(out _vignette);
        postProcessingVolume.profile.TryGet(out _colorAdjustments);
        player = GameObject.FindWithTag("Player").transform;
        monster = GameObject.FindWithTag("Monster").transform;
    }

    private void Update()
    {
        NearMonster();
        
    }

    private void NearMonster()
    {
        if (Vector3.Distance(monster.position, player.position) <= 20)
        {
            _vignette.intensity.value = 0.35f;
            _vignette.smoothness.value = 1f;
            _colorAdjustments.postExposure.value = -2.2f;
            _colorAdjustments.contrast.value = 30f;
        }
        
        else
        {
            _vignette.intensity.value = 0f;
            _vignette.smoothness.value = 0f;
            _colorAdjustments.postExposure.value = 0f;
            _colorAdjustments.contrast.value = 0f;
        }
    }
}
