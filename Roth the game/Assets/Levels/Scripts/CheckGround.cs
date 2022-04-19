using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{

    private PlayerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerControl>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            player.grounded = true;
        }
        if (col.gameObject.tag == "Line")
        {
            player.grounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            player.grounded = false;
        }
        if (col.gameObject.tag == "Line")
        {
            player.grounded = false;
        }
    }
}
