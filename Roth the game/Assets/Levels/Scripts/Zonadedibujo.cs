using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zonadedibujo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Nuevalinea.dibujar = 1;
            Nuevalineaescudo.dibujar = 1;

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Nuevalinea.dibujar = 1;
            Nuevalineaescudo.dibujar = 1;

        }
    }
    private void OnTriggerEXIT2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Nuevalinea.dibujar = 0;
            Nuevalineaescudo.dibujar = 0;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
