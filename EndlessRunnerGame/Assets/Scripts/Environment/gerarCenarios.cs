using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarCenarios : MonoBehaviour
{
    public GameObject[] cenarios;
    public float pos;
    public bool criaCenario = false;
    public int numCen;

    void Start()
    {
        pos = 172.4f;
    }

    void Update()
    {
        if (!criaCenario)
        {
            criaCenario = true;
            StartCoroutine(gerarCenario());
        }
    }

    IEnumerator gerarCenario()
    {
        numCen = Random.Range(0, 5);
        Instantiate(cenarios[numCen], new Vector3((float)17.5607, (float)11.78792, pos), Quaternion.identity);
        pos += 37.7f; // Increase the position by the desired value
        yield return new WaitForSeconds(2);
        criaCenario = false;
    }
}

