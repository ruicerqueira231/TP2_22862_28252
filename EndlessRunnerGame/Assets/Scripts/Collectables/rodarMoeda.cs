using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodarMoeda : MonoBehaviour
{
    public float rotacaoMoeda = 1.4f;
    
    void Update()
    {
        transform.Rotate(0,rotacaoMoeda,0,Space.World);
    }
}
