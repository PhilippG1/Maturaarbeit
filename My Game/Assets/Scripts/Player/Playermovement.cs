using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float Speed;
    [SerializeField] private float JumpPower;
    [SerializeField] public float Gravity;
    [Header("Coyote Time")]
    [SerializeField]private float coyoteTime;
    private float coyotecounter;
    [Header("Multiple Jumps")]
    [SerializeField] public int extraJumps = 1;
    private int jumpCounter;
    [Header("Walljump")]
    public bool canWalljump = false;
    [SerializeField] private float wallJumpX;
    [SerializeField] private float wallJumpY;
    [Header("Layers")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;

    [Header("Dash")]
    [SerializeField]private float dashingVelocity;
    [SerializeField]private float dashingTime;
    public bool dashAbility = false;
    private Vector2 dashingDirection;
    public bool isDashing;
    private bool canDash = true;
    private TrailRenderer dashTrail;
    
    private Rigidbody2D Body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private InputManager inputManager;
    private Vector3 playerSize;
    private float wallJumpCooldown;
    private float Horizontalinput;
    private void Awake()
    {   // Get references for rigidbody and animator
        Body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        inputManager = new InputManager();
        playerSize = transform.localScale;
        dashTrail = GetComponent<TrailRenderer>();
    }
    private void OnEnable()
    {
        inputManager.Enable();
    }
    private void OnDisable()
    {
        inputManager.Disable();
    }
    private void Update()
    {
        if (inputManager.Land.MoveHorizontal.ReadValue<float>() != 0)
        {
            Horizontalinput = Mathf.Sign(inputManager.Land.MoveHorizontal.ReadValue<float>());
        }
        else
        {
            Horizontalinput = 0;
        }
        
        //Dash
        if (inputManager.Land.Dashbutton.triggered == true && canDash)
        {
            
            isDashing = true;
            canDash = false;
            dashTrail.emitting = true;
            dashingDirection = new Vector2(inputManager.Land.MoveHorizontal.ReadValue<float>(), inputManager.Land.DashDirection.ReadValue<float>());
            
            if (dashingDirection == Vector2.zero)
            {
                dashingDirection = new Vector2(transform.localScale.x, 0);

            }
                        
            inputManager.Disable();
            Body.gravityScale = 0;
            Body.velocity = Vector2.zero;
            StartCoroutine(StopDashing());
        }
        if (isDashing)
        {
            
            Body.velocity = dashingDirection.normalized * dashingVelocity;
        }

        if (isGrounded() && !isDashing)
        {
            canDash = true;
        }

       


        if (Horizontalinput > 0.01f)
            transform.localScale = playerSize;
        else if (Horizontalinput < -0.01f)
            transform.localScale = new Vector3(-playerSize.x, playerSize.y, playerSize.z);

        //set animator parameters  
        anim.SetBool("Run", Horizontalinput != 0);
        anim.SetBool("Grounded", isGrounded());
       //Jump
        if (inputManager.Land.jump.triggered)
        {
            Jump();
        }
        //Jump height
        if (inputManager.Land.jump.ReadValue<float>() == 0 && Body.velocity.y > 0 && !isDashing)
        {
            Body.velocity = new Vector2(Body.velocity.x, Body.velocity.y / 2);
        }
        if (onWall() && inputManager.Land.RT.ReadValue<float>() != 0)
        {
            Body.gravityScale = Gravity / 10;
            Body.velocity = Vector2.zero;
        }
        if(!isDashing)
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

    private IEnumerator StopDashing()
    {
        yield return new WaitForSeconds(dashingTime);
        dashTrail.emitting = false;
        isDashing = false;
        inputManager.Enable();
        Body.gravityScale = Gravity;
        

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
