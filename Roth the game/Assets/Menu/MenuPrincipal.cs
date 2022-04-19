﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void EmpezarJuego()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    public void CerrarJuego() 
    {
        Application.Quit();
        Debug.Log("Salir");
    }
    public void Saltarescena()
    { SceneManager.LoadScene("Levels/Scenes/Tutorial"); }
}

