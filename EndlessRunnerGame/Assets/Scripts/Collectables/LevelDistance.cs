using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public static int disRun;
    public bool addingDis = false;


    void Update()
    {
        if(addingDis == false){
            addingDis = true;
            StartCoroutine(AddingDis());
        }        
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        disEndDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(0.50f);
        addingDis = false;
    }
}
