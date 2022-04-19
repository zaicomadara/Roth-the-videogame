using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIpause : MonoBehaviour
{
    public GameObject optionsPanel;
    // Start is called before the first frame update
    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }
   
    public void Salirdeljuego()
    {
        //SceneManager.LoadScene("Menu/Menu");
        Application.Quit();
    }
    
}
