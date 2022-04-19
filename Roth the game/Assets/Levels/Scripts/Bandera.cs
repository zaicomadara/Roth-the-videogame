using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bandera : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bandera1"))
        {
            SceneManager.LoadScene("Levels/Scenes/Level 1");
        }
        if (col.CompareTag("Bandera2"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 2");
        }
        if (col.CompareTag("Bandera3"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 3");
        }
        if (col.CompareTag("Bandera4"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 4");
        }
        if (col.CompareTag("Bandera5"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 5");
        }
        if (col.CompareTag("Bandera6"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 6");
        }
        if (col.CompareTag("Bandera7"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 7");
        }
        if (col.CompareTag("Bandera8"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 8");
        }
        if (col.CompareTag("Bandera9"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 9");
        }
        if (col.CompareTag("Bandera10"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 10");
        }
        if (col.CompareTag("Bandera11"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 11");
        }
        if (col.CompareTag("Bandera12"))
        {
            SceneManager.LoadScene("Levels/Scenes/level 12");
        }
    }
}
