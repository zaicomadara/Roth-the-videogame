using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compas : MonoBehaviour
{
    public GameObject compas1;
    public GameObject compas2;
    public GameObject compas3;
    public GameObject compas4;
    public GameObject compas5;

    public GameObject compasescudo1;
    public GameObject compasescudo2;
    public GameObject compasescudo3;
    public GameObject compasescudo4;
    public GameObject compasescudo5;
    // Start is called before the first frame update
    void Start()
    {
        compasescudo1.SetActive(false);
        compasescudo2.SetActive(false);
        compasescudo3.SetActive(false);
        compasescudo4.SetActive(false);
        compasescudo5.SetActive(false);

        compas2.SetActive(false);
        compas3.SetActive(false);
        compas4.SetActive(false);
        compas5.SetActive(false);

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Compas"))
        {
            StartCoroutine(Esperar1());
        }
        if (other.CompareTag("Compas2"))
        {
            StartCoroutine(Esperar2());
        }
        if (other.CompareTag("Compas3"))
        {
            StartCoroutine(Esperar3());
        }
        if (other.CompareTag("Compas4"))
        {
            StartCoroutine(Esperar4());
        }
        if (other.CompareTag("Compas5"))
        {
            StartCoroutine(Esperar5());
        }
    }
    // Update is called once per frame

    IEnumerator Esperar1()
        {
            compas1.SetActive(false);
            compasescudo1.SetActive(true);
            yield return new WaitForSeconds(10f);
            compas2.SetActive(true);
            compasescudo1.SetActive(false);          
        }
    IEnumerator Esperar2()
    {
        compas2.SetActive(false);
        compasescudo2.SetActive(true);
        yield return new WaitForSeconds(10f);
        compas3.SetActive(true);
        compasescudo2.SetActive(false);
    }
    IEnumerator Esperar3()
    {
        compas3.SetActive(false);
        compasescudo3.SetActive(true);
        yield return new WaitForSeconds(10f);
        compas4.SetActive(true);
        compasescudo3.SetActive(false);
    }
    IEnumerator Esperar4()
    {
        compas4.SetActive(false);
        compasescudo4.SetActive(true);
        yield return new WaitForSeconds(10f);
        compas5.SetActive(true);
        compasescudo4.SetActive(false);
    }
    IEnumerator Esperar5()
    {
        compas5.SetActive(false);
        compasescudo5.SetActive(true);
        yield return new WaitForSeconds(10f);
        compas1.SetActive(true);
        compasescudo5.SetActive(false);
    }
    void Update()
    {
        
    }
}
