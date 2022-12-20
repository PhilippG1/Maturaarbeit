using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    public bool dead;
    [Header("iFrames")]
    [SerializeField] private float iFrameDuration;
    private Animator anim;
    private InputManager inputManager;
    public Vector3 currentCheckpoint;

    private void Awake()
    {
        currentHealth = startingHealth;
        GetComponent<Playermovement>().enabled = true;
        anim = GetComponent<Animator>();
        inputManager = new InputManager();
        
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            StartCoroutine(Invounerability());
            //animator
        }
        else if (currentHealth == 0)
        {
            if (!dead)
            {
                inputManager.Disable();
                anim.SetTrigger("Death");
                dead = true;
                


                StartCoroutine(Respawn());


            }


        }
    }

    public void addHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    public void RespawnHealth()
    {
        addHealth(startingHealth);
        inputManager.Enable();
        dead = false;
        anim.ResetTrigger("Death");
        anim.Play("idle");
       
    }
    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponentInChildren<ParticleSystem>().Stop();
        transform.position = currentCheckpoint;
        RespawnHealth();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform.position;

        }
    }

    public IEnumerator Invounerability()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        yield return new WaitForSeconds(iFrameDuration);
        Physics2D.IgnoreLayerCollision(8, 9, false);

    }


}
