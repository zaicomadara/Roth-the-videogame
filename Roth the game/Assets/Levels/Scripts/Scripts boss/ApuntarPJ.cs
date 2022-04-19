using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarPJ : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
       
    }

    void Update()
    {
        transform.right = player.transform.position - transform.position;
    }

}
