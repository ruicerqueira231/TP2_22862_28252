using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName= transform.name;
        StartCoroutine(DestroyCenario());
            
    }

    IEnumerator DestroyCenario()
    {
        yield return new WaitForSeconds(50);
        if(parentName == "Cenario(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
