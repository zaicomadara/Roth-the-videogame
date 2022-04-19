using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activadorbrujula : MonoBehaviour
{
    public GameObject brujula;
    public GameObject panelreglas;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            brujula.SetActive(true);
            panelreglas.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            brujula.SetActive(false);
            panelreglas.SetActive(false);
        }
    }
}
