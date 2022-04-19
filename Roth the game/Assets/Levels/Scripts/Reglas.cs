using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reglas : MonoBehaviour
{
    public GameObject brujula1;
    public GameObject panelreglas1;
    public GameObject brujula2;
    public GameObject panelreglas2;
    public GameObject brujula3;
    public GameObject panelreglas3;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("M30"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            MovBarco.movbarco = 1;
            panelreglas1.SetActive(false);
            brujula1.SetActive(false);
            panelreglas2.SetActive(true);
            brujula2.SetActive(true);
            panelreglas3.SetActive(true);
            brujula3.SetActive(true);
        }
        if (col.CompareTag("M45"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            MovBarco.movbarco = 2;
            
            panelreglas2.SetActive(false);
            brujula2.SetActive(false);

        }
        if (col.CompareTag("M60"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            MovBarco.movbarco = 3;
            
            panelreglas3.SetActive(false);
            brujula3.SetActive(false);
        }
    

    }
    private void Update()
    {

    }
}
