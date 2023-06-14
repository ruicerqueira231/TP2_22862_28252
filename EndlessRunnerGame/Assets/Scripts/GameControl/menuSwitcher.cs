using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSwitcher : MonoBehaviour
{
    public void switchForMenu(string name){
        SceneManager.LoadScene(name);
    }
}
