using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField, Header("�t��"), Range(1, 500)]
    public float speed = 1;
    [SerializeField, Header("���D����"), Range(0, 5000)]
    public float jumpheight = 1000;
    [SerializeField, Header("���鱱��")]
    public Rigidbody2D body;
 
    [SerializeField, Header("�O�_�b�a�O�W")]
    public bool isGround = false;
    public AnimatorStateInfo state;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(1 * speed * Time.deltaTime, body.velocity.y);

        // PlayerCtl();
    }



    public virtual void PlayerCtl()
    {

        bool upkey = Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow);


        if (Input.GetKey(KeyCode.RightArrow))
        {

            Move(1);
            durction(1);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Move(-1);
            durction(0);
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();

        }

        if (upkey)
        {

            Move(0);

        }
 
 

    }

    void Jump()
    {
        if (!isGround) { return; }
        body.velocity = new Vector2(body.velocity.x, jumpheight);// �ª���/20220620

    
    }



    public virtual void Move(int i)
    {

        body.velocity = new Vector2(i * speed *Time.deltaTime, body.velocity.y);

 

    }


    void durction(int i)
    {
        transform.eulerAngles = new Vector3(0, 180 * i, 0);


    }
 
    /// <summary>
    /// ����I��
    /// </summary>

    private void OnCollisionStay2D(Collision2D collision)
    {


        isGround = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;

    }
 

}
