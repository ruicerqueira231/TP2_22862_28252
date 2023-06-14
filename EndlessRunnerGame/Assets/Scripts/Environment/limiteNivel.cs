using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limiteNivel : MonoBehaviour
{

    public static float leftSide = -2.8f;
    public static float rightSide = 2.8f;
    public float internalLeft;
    public float internalRight;
    

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
