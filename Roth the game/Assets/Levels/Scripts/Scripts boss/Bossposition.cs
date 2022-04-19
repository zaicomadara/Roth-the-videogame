using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bossposition : MonoBehaviour
{
    public Transform[] transforms;
    public GameObject flameblue;
    public GameObject Posflameblue;


    public float timeToShoot, countown;
    public float timeToTP, countownToTP;

    public float bossHealth, currentHealth;
    public Image Barrasalud;
    private void Start()
    {
        var initialPosition = Random.Range(0, transforms.Length);
        transform.position = transforms[initialPosition].position;

        countown = timeToShoot;
        countownToTP = timeToTP;
    }
    public void Update()
    {
        Countowns();
        DamageBoss();
        //BossScale();
    }
    public void Countowns()
    {
        countown -= Time.deltaTime;
        countownToTP -= Time.deltaTime;

        if (countown <= 0f)
        {
            ShootPlayer();
            countown = timeToShoot;
        }
        if (countownToTP <= 0f)
        {
            countownToTP = timeToTP;
            Teleport();
        }
    }
    public void Teleport()
    {
        var initialPosition = Random.Range(0, transforms.Length);
        transform.position = transforms[initialPosition].position;
    }
    private void ShootPlayer()
    {
        GameObject spell = Instantiate(flameblue, Posflameblue.transform.position, Quaternion.identity);
    }
    public void DamageBoss()
    {
        currentHealth = GetComponent<Enemy>().healthPoints;
        Barrasalud.fillAmount = currentHealth / bossHealth;
    }

    private void OnDestroy()
    {
        BossUI.instance.BossDeactivator();
    }
    public void BossScale()
    {
        if (transform.position.x > PlayerControl.instance.transform.position.x)
        {
            transform.localScale = new Vector3(-3, 3, 3);
        }
        else 
        {
            transform.localScale = new Vector3(3, 3, 3);
        }
    }
}
