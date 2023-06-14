using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletarMoeda : MonoBehaviour
{
    public AudioSource coinSound;
    void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        CollectableControl.coinCount += 1;
        this.gameObject.SetActive(false);
        
    }
}

