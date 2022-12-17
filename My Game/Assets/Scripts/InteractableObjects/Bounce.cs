using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    private bool bounce;
    private GameObject collided;
    [SerializeField] private AudioClip BounceSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            
            if ((collision.transform.position.y - transform.position.y )> 0)
            {
                collided = collision.gameObject;
                bounce = true;
                StartCoroutine(StopBounce());
                SoundManager.Instance.PlaySound(BounceSound);
                
                
                

            }
        }
        
    }
    private void Update()
    {
        if (bounce == true)
        {
            collided.GetComponent<Rigidbody2D>().velocity = new Vector2(collided.GetComponent<Rigidbody2D>().velocity.x, 25);
            
        }
    }
    private IEnumerator StopBounce()
    {
        yield return new WaitForSeconds(0.5f);
        bounce = false;
        collided.GetComponent<Rigidbody2D>().velocity = new Vector2(collided.GetComponent<Rigidbody2D>().velocity.x, 10);
    }
}
