using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            _vignette.intensity.value = 0.1f;
            _vignette.smoothness.value = 0.2f;
            _colorAdjustments.postExposure.value = -0.5f;
            _colorAdjustments.contrast.value = 10f;

            if(Vector3.Distance(monster.position, player.position) <= 15)
            {
                _vignette.intensity.value = 0.15f;
                _vignette.smoothness.value = 0.3f;
                _colorAdjustments.postExposure.value = -1f;
                _colorAdjustments.contrast.value = 15f;   
                    
                if(Vector3.Distance(monster.position, player.position) <= 12)
                {
                    _vignette.intensity.value = 0.2f;
                    _vignette.smoothness.value = 0.4f;
                    _colorAdjustments.postExposure.value = -1.5f;
                    _colorAdjustments.contrast.value = 20f;   

                    if(Vector3.Distance(monster.position, player.position) <= 10)
                    {
                        _vignette.intensity.value = 0.25f;
                        _vignette.smoothness.value = 0.6f;
                        _colorAdjustments.postExposure.value = -1.8f;
                        _colorAdjustments.contrast.value = 25f;

                        if(Vector3.Distance(monster.position, player.position) <= 8)   
                        {
                            _vignette.intensity.value = 0.3f;
                            _vignette.smoothness.value = 0.8f;
                            _colorAdjustments.postExposure.value = -2f;
                            _colorAdjustments.contrast.value = 30f;

                            if (Vector3.Distance(monster.position, player.position) <= 5)
                            {
                                _vignette.intensity.value = 0.35f;
                                _vignette.smoothness.value = 1f;
                                _colorAdjustments.postExposure.value = -2.2f;
                                _colorAdjustments.contrast.value = 30f;
                            }
                        }
                    }  
                }      
            }
            
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
