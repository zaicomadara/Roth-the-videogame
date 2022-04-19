using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBarco2 : MonoBehaviour
{
    public Transform Destino1;
    public Transform Destino2;
    public Transform Destino3;
    public Transform Destino4;
    public Transform Destino5;
    public float speed;
    public static int movbarco2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movbarco2 == 1)
        {
            float step1 = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Destino1.position, step1);
        }
        if (movbarco2 == 2)
        {
            float step2 = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Destino2.position, step2);
        }
        if (movbarco2 == 3)
        {
            float step3 = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Destino3.position, step3);
        }
        if (movbarco2 == 4)
        {
            float step4 = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Destino4.position, step4);
        }
        if (movbarco2 == 5)
        {
            float step5 = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Destino5.position, step5);
        }

    }
}

