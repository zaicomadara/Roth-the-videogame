using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class podercojido : MonoBehaviour
{
    public static int contador=3;
    public static int contvidas=3;
    public Text Borrar;
    public Text Vidas;
    Rigidbody2D rib;
    Rigidbody2D ribvid;


    public GameObject imagen;
    public GameObject imagen2;
    public GameObject imagen3;
    public GameObject imagen4;

    public static podercojido vidas;
    public static podercojido borrador;

    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Borrador"))
        { 
            Destroy(other.gameObject);
            contador = contador + 1;
            Borrar.text = "Borrar:" + contador;
        }
        if (other.CompareTag("corazon"))
        {
            Destroy(other.gameObject);
            contvidas = contvidas + 1;
            Vidas.text = "Vidas:" + contvidas;
        }
        if (other.CompareTag("Flamita"))
        {
            Destroy(other.gameObject);
            contvidas -= 1;
            Vidas.text = "Vidas:" + contvidas;
        }
        if (other.CompareTag("Grafito"))
        {
            Destroy(other.gameObject);
            contvidas -= 1;
            Vidas.text = "Vidas:" + contvidas;
        }
        if (other.CompareTag("Poder1"))
        {
            Destroy(other.gameObject);
            imagen.SetActive(true);
            imagen3.SetActive(true);
        }
        if (other.CompareTag("Poder2"))
        {
            Destroy(other.gameObject);
            imagen2.SetActive(true);
            imagen4.SetActive(true);
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Pinchos")
        {
            contvidas -= 1;
            Vidas.text = "Vidas:" + contvidas;
        }
        if (collision.gameObject.tag == "Grafito")
        {
            contvidas -= 1;
            Vidas.text = "Vidas:" + contvidas;
        }
        if (collision.gameObject.tag == "Fuego")
        {
            contvidas -= 1;
            Vidas.text = "Vidas:" + contvidas;
        }

    }
    public void Awake()
    {
        ribvid = GetComponent<Rigidbody2D>();
        rib = GetComponent<Rigidbody2D>();

            Vidas.text = "Vidas:" + contvidas;
            Borrar.text = "Borrar:" + contador;
        
    }

    public void Update()
    {
       

        if (contador > 0)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                contador -= 1;
                Borrar.text = "Borrar:" + contador;
            }
        }
        if (contvidas == 0)
        {
            SceneManager.LoadScene("Menu");
            contador = 3;
            contvidas = 3;
        }
           
    }

}

