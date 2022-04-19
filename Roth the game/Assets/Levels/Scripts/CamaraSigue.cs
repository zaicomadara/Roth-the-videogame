using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    public Transform Objetivo;
    public float suavisado = 5f;

    Vector3 desface;
  
    void Start() 
    {
        desface = transform.position - Objetivo.position;

    }

    void FixedUpdate() 
    {
        Vector3 posicionObjetivo = Objetivo.position + desface;
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavisado * Time.deltaTime);

    }
}