using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private bool dead;
    [Header("iFrames")]
    [SerializeField] private float iFrameDuration;
    private Animator anim;
    private InputManager inputManager;
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

    public IEnumerator Invounerability()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        yield return new WaitForSeconds(iFrameDuration);
        Physics2D.IgnoreLayerCollision(8, 9, false);

    }


}
