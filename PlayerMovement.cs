using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float Speed;
    private Rigidbody2D body;
    public Animator animator;
    float movementX;
    bool Jump;
    bool Player_jump, Player_fall;
    public void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    public void OnMovement()
    {
        
    }

    public void Update()
    {
        animator.SetBool("Running", false);
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, body.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal") * Speed));

        movementX = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, Speed);
        }

        Debug.Log(movementX.ToString());
        if(body.velocity.x != 0)
        {
            body.AddForce(new Vector2(movementX * Speed, 0f));
            animator.SetBool("Running", true);
        }


        //body.transform.position = new Vector3(body.transform.position.x, body.transform.position.y, 0f);
        if (body.velocity.x > 0)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (body.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if (Input.GetButtonDown("Jump"))
    {
        Jump = true;
        animator.SetBool("Jump", Jump);
        animator.SetBool("Fall", false);
    }

    if (/*Input.GetButtonUp("Jump")*/ body.velocity.y < 0)
    {
        Jump = false;
        animator.SetBool("Jump", Jump);
        animator.SetBool("Fall", true);
    }
    else if (body.velocity.y == 0)
    {
        Jump = false;
        animator.SetBool("Jump", Jump);
        animator.SetBool("Fall", false);
    }

    if (Player_jump && !Player_fall)
    {
       
    }

    if (Player_fall)
    {
        
 
    }
    }
    private void UpdateAnimationUpdate()
    {

    }
}