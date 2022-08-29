using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float Speed;
    [SerializeField] private float JumpPower;
    [SerializeField] private float Gravity;
    [Header("Coyote Time")]
    [SerializeField]private float coyoteTime;
    private float coyotecounter;
    [Header("Multiple Jumps")]
    [SerializeField] private int extraJumps;
    private int jumpCounter;
    [Header("Walljump")]
    [SerializeField] private float wallJumpX;
    [SerializeField] private float wallJumpY;
    [Header("Layers")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    
    private Rigidbody2D Body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    //private float wallJumpCooldown;
    private float Horizontalinput;
    private void Awake()
    {   // Get references for rigidbody and animator
        Body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
       
        
        Horizontalinput = InputManager.Land.MoveHorizontal.ReadValue<Vector2>;
      

        

        if (Horizontalinput > 0.01f)
            transform.localScale = new Vector3(9, 9, 1);
        else if (Horizontalinput < -0.01f)
            transform.localScale = new Vector3(-9, 9, 1);

        //set animator parameters  
        anim.SetBool("Run", Horizontalinput != 0);
        anim.SetBool("Grounded", isGrounded());
       //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        //Jump height
        if (Input.GetKeyUp(KeyCode.Space)&& Body.velocity.y > 0)
        {
            Body.velocity = new Vector2(Body.velocity.x, Body.velocity.y / 2);
        }
        if (onWall() && Input.GetKey(KeyCode.LeftControl))
        {
            Body.gravityScale = Gravity / 10;
            Body.velocity = Vector2.zero;
        }
        else
        {
            Body.gravityScale = Gravity;
            Body.velocity = new Vector2(Horizontalinput * Speed, Body.velocity.y);

            if (isGrounded())
            {
                coyotecounter = coyoteTime; //reset time
                jumpCounter = extraJumps; //reset Jumps
            }
            else
            {
                coyotecounter -= Time.deltaTime;
            }
        }
    }


    private void Jump()
    {
        if (coyotecounter < 0 && !onWall() && jumpCounter <= 0) return;
        //sound
        if (onWall())
            WallJump();
        else
        {
            if (isGrounded())
            {
                Body.velocity = new Vector2(Body.velocity.x, JumpPower);
            }
            else
            {
                if(coyotecounter > 0)
                    Body.velocity = new Vector2(Body.velocity.x, JumpPower);
                else
                {
                    if (jumpCounter > 0)
                    {
                        Body.velocity = new Vector2(Body.velocity.x, JumpPower);
                        jumpCounter --;
                    }
                }
            }
            coyotecounter = 0;
        }

    }
    private void WallJump()
    {
        Body.AddForce(new Vector2(-Mathf.Sign(transform.localScale.x) * wallJumpX, wallJumpY));
        //wallJumpCooldown = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 

    }
        
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
    private bool onWall()
    {//wallLayer durch groundlayer ersetzt !!!!!!! bei bugs kontrollieren
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x,0), 0.1f, /*groundLayer*/wallLayer);
        return raycastHit.collider != null;
    }
}
