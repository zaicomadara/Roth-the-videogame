using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activargif : MonoBehaviour
{
    public GameObject imagen;
    public GameObject imagen2;
    public GameObject imagen3;
    public GameObject imagen4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            imagen.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.V))
            {
                imagen.SetActive(false);
                imagen2.SetActive(true);
                imagen3.SetActive(true);
                imagen4.SetActive(true);
            }
            if (Input.GetKey(KeyCode.C))
            {
                imagen.SetActive(false);
                imagen2.SetActive(false);
                imagen3.SetActive(false);
                imagen4.SetActive(false);
            }

        }
    }
    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            imagen.SetActive(false);
            imagen2.SetActive(false);
            imagen3.SetActive(false);
            imagen3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            imagen2.SetActive(false);
            imagen3.SetActive(false);
            imagen3.SetActive(false);
        }
    }

}
