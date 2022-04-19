using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivator : MonoBehaviour
{
    public GameObject bossGO;

    private void Start()
    {
        bossGO.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BossUI.instance.BossActivator();
            StartCoroutine(WaitForBoss());
            
        }
    }
    
     IEnumerator WaitForBoss()
    {
        var currentSpeed = PlayerControl.mover;
        PlayerControl.mover = 0;
        bossGO.SetActive(true);
        yield return new WaitForSeconds(3f);
        PlayerControl.mover = currentSpeed;
        Destroy(gameObject);
    }


    
}
