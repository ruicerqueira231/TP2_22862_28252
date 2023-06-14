using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoObstaculo : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public GameObject levelControl;
    public GameObject endScreen;

    private bool collided = false;

    void OnTriggerEnter(Collider other)
    {
        if (!collided && other.gameObject == player)
        {
            collided = true;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            player.GetComponent<PlayerMove>().enabled = false;
            charModel.GetComponent<Animator>().Play("Dying Backwards");
            levelControl.GetComponent<EndLevelSequece>().SetCollided();
            levelControl.GetComponent<LevelDistance>().enabled = false;
        }
    }

}

