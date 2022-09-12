using System.Collections;
using UnityEngine;
public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D Body;
    private Transform StartingLocation;
    private void Awake()
    {
        Rigidbody2D Body = GetComponent<Rigidbody2D>();
        Body.gravityScale = 0;
        StartingLocation = Body.transform;
    }

    private void ontriggerenter2d(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            FallPlatform();

        }
    }


    private void FallPlatform()
    {
        Body.gravityScale = GetComponent<Playermovement>().Gravity;

        new WaitForSeconds(10);
        Body.gravityScale = 0;
        Body.transform.position = StartingLocation.position;
    }
}
