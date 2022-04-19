using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Morir : MonoBehaviour
{
    public string escena;
    private Animator anim;

    public UnityEngine.UI.Image telaNegra;
    float valorAlfaDeseadoTelaNegra;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //iniciar fade in
        telaNegra.color = new Color(0, 0, 0, 1); //negro
        valorAlfaDeseadoTelaNegra = 0; // transparente

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pinchos") 
        { 
            anim.SetTrigger("Muere");
        }
        if (collision.gameObject.tag == "Grafito")
        {
            anim.SetTrigger("Muere");
        }
        if (collision.gameObject.tag == "Flameblue")
        {
            anim.SetTrigger("Muere");
        }
        if (collision.gameObject.tag == "Cocodrilo")
        {
            anim.SetTrigger("Muere");
            MovBarco.movbarco = 4;
            MovBarco2.movbarco2 = 5;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Fuego"))
        {
            anim.SetTrigger("Muere");
        }
        if (col.CompareTag("Flamita"))
        {
            anim.SetTrigger("Muere");
        }
        if (col.CompareTag("Grafito"))
        {
            anim.SetTrigger("Muere");
        }
        if (col.CompareTag("Flameblue"))
        {
            anim.SetTrigger("Muere");
        }
    }
    void FixedUpdate()
    {
    //manejar tela negra
        float valorAlfa = Mathf.Lerp(telaNegra.color.a, valorAlfaDeseadoTelaNegra, .05f);
        telaNegra.color = new Color(0, 0, 0, valorAlfa);

        //reiniciar escena al oscurecer
        if (valorAlfa > 0.9f && valorAlfaDeseadoTelaNegra== 1) SceneManager.LoadScene("Levels/Scenes/"+ escena);
            
        
    }
    public void iniciarFadeOut() 
    {
        valorAlfaDeseadoTelaNegra = 1; //oscurecer al morir
    }
}
