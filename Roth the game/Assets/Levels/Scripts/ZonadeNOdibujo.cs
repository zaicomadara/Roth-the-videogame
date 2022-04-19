using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonadeNOdibujo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
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
