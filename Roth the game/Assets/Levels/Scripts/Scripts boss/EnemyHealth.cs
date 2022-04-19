using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    public bool isDamaged;
    public GameObject deathEffect;
    SpriteRenderer sprite;
    Blink material;
    Rigidbody2D rb;


    // Start is called before the first frame update
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        material = GetComponent<Blink>();
        enemy = GetComponent<Enemy>();

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Flameblue" )
        {
            enemy.healthPoints -= 4f;
            if (collision.transform.position.x < transform.position.x)
            {
                rb.AddForce(new Vector2(enemy.KnockbackForceX, enemy.KnockbackForceY), ForceMode2D.Force);
            }
            else
            {
                rb.AddForce(new Vector2(-enemy.KnockbackForceX, enemy.KnockbackForceY), ForceMode2D.Force);
            }
            
            StartCoroutine(Damager());
            if(enemy.healthPoints <=0)
            {
                Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
    IEnumerator Damager()
    {
        isDamaged = true;
        sprite.material = material.blink;
        yield return new WaitForSeconds(0.5f);
        isDamaged = false;
        sprite.material = material.original;
    }
}
