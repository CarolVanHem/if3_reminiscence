using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveMemory : MonoBehaviour
{
    public Material mat;
    
    public void Dissolve(){
        Collider collider = GetComponent<Collider>();
        if(collider != null) collider.enabled = false;
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb != null) rb.useGravity = false;
        StartCoroutine(DoDissolve());
    }
    IEnumerator DoDissolve()
    {
        print("test:D");
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
