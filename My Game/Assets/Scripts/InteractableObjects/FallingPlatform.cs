using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D Body;
    [SerializeField] private Transform StartingLocation;
    [SerializeField] private GameObject PlayerObject;
    
    private void Start()
    {

        Body = GetComponent<Rigidbody2D>();
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;
        Body.constraints = RigidbodyConstraints2D.FreezeAll;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Player")
        {
            StartCoroutine(FallPlatform());

        }
    }
    

    private IEnumerator FallPlatform()
    {
        yield return new WaitForSeconds(1);
        Body.constraints = RigidbodyConstraints2D.None;
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;
        

        yield return new WaitForSeconds(10);
        Body.gravityScale = 0;

        transform.position = StartingLocation.position;
        transform.rotation = StartingLocation.rotation;
        Body.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}    
