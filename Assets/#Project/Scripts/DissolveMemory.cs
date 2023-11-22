using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveMemory : MonoBehaviour
{
    public Material mat;
        
    IEnumerator DoDissolve()
    {
        GetComponent<Renderer>().material = mat;
        mat.SetFloat("_Dissolve_Level", 0);
        
        float dissolveLevel = 0f;
        float dissolveDuration = 5f;

        float startTime = Time.time;

        while(Time.time < startTime + dissolveDuration){
            dissolveLevel = Mathf.Lerp(0, 1, (Time.time - startTime) / dissolveDuration);
            mat.SetFloat("_Dissolve_Level", dissolveLevel);
            yield return null;
        }

        mat.SetFloat("_Dissolve_Level", 1);
        Destroy(gameObject);

        Debug.Log("Dissolving");
    }
}
