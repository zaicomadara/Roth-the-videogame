using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision_Disparo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
       
        if (collision.gameObject.tag == "Line")
        {
            
        }
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Grafito")
        {
            //collision.gameObject.
        }
        if (collision.gameObject.tag == "LineEscudo")
        {
           // Destroy(collision.gameObject);
           // Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.CompareTag("ColFuego"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "LineEscudo")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Line")
        {
           // Destroy(col.gameObject);
        }
    }
}
