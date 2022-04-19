using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    void Update()
    {
        
    } 
    public void Introgame()
    {
        SceneManager.LoadScene("Levels/Scenes/Tutorial");
    }
}
