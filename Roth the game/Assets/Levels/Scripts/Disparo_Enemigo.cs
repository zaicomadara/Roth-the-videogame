using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Enemigo : MonoBehaviour
{
    public float bulletSpeed;
    public float spawnTime;
    public GameObject spawner;
    public GameObject bulletPrefab;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > spawnTime)
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, spawner.transform, true);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bullet.GetComponent<Rigidbody2D>().velocity.x,bulletSpeed);
            counter = 0;
        }

    }

}
