using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightMemory : MonoBehaviour
{
    public Material mat;
    
    public void Highlight()
    {
        StartCoroutine(DoHighlight());
    }
    IEnumerator DoHighlight()
    {
        GetComponent<Renderer>().material = mat;
        mat.SetFloat("_Highlight_Level", 1);
        
        yield return null;

    }
}
