using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            
            if ((collision.transform.position.y - transform.position.y )> 0)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
                Debug.Log("asfasdfasdf");
            }
        }
    }

}
