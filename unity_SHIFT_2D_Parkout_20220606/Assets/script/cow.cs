using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow : MonoBehaviour
{
    public bool isGround = false;

    public float jumpheight = 10;
    public float speed = 700;
    public Rigidbody2D body;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        body = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

 

        Move(10);
   
            if (!isGround) anim.SetBool("jump", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }
    }

    void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpheight);

        anim.SetBool("jump", true);
        /// anim.SetTrigger("Jump");

    }
    private void Move(int i)
    {

        body.velocity = new Vector2(i * speed * Time.deltaTime, body.velocity.y);
 
    }

    private void OnCollisionStay2D(Collision2D collision)
    {


        isGround = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;

    }

}
