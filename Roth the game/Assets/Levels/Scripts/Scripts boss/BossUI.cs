using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUI : MonoBehaviour
{
    public GameObject bossPanel;
    public GameObject muros;

    public static BossUI instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        bossPanel.SetActive(false);
        muros.SetActive(false);
    }

    public void BossActivator()
    {
        bossPanel.SetActive(true);
        muros.SetActive(true);
    }
    public void BossDeactivator()
    {
        bossPanel.SetActive(false);
        muros.SetActive(false);
    }
}
