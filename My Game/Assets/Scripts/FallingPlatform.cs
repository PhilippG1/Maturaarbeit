using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D Body;
    private Transform StartingLocation;
    [SerializeField] private GameObject PlayerObject;
    
    private void Awake()
    {
        StartingLocation = Body.transform;
        Body = GetComponent<Rigidbody2D>();
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;
        StartingLocation = Body.transform;
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

        Body.constraints = RigidbodyConstraints2D.None;
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;
        Debug.Log("lul");

        yield return new WaitForSeconds(10);
        Debug.Log(StartingLocation.position);
        Body.gravityScale = 0;

        transform.position = StartingLocation.position;
        Body.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}    
