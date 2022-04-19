using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBlueshot : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Line")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "LineEscudo")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("LineEscudo"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
