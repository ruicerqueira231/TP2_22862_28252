using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelSequece : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;

    private bool collided = false;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    public void SetCollided()
    {
        collided = true;
    }

    IEnumerator EndSequence()
    {
        while (true)
        {
            yield return null;
            if (collided)
            {
                yield return new WaitForSeconds(5);
                liveCoins.SetActive(false);
                liveDis.SetActive(false);
                endScreen.SetActive(true);
                yield break;
            }
        }
    }
}

