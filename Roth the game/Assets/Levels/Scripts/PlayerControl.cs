using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float maxSpeed = 6f;
    public float Speed = 10f;
    public bool grounded;
    public float jumpPower = 9f;
    public  static int mover = 0;
    public static PlayerControl instance;


    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        mover = 1;
   
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);
        if (mover == 1)
        {
            
            if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            {
                jump = true;
            }
            if (Input.GetKeyDown(KeyCode.W) && grounded)
            {
                jump = true;
            }
           
        // ----------------------------------------------------------   
          
        }

       


    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void FixedUpdate()
    {
       
        
            float h = Input.GetAxis("Horizontal");
            rb2d.AddForce(Vector2.right * Speed * h*mover);



            float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
            rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
            if (h > 0.1f)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            if (h < -0.1f)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            if (jump)
            {
                rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                jump = false;

            }
        
            

    }
}