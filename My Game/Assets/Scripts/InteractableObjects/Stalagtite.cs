using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagtite : MonoBehaviour
{
    private Rigidbody2D Body;
    [SerializeField] private Transform StartingLocation;
    [SerializeField] private GameObject PlayerObject;
    [SerializeField] private GameObject StalagtiteObject;

    private void Start()
    {

        Body = StalagtiteObject.GetComponent<Rigidbody2D>();
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;
        Body.constraints = RigidbodyConstraints2D.FreezeAll;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            StartCoroutine(StalagtiteFall());
        }
        
    }
    private IEnumerator StalagtiteFall()
    {
        Body.constraints = RigidbodyConstraints2D.None;
        Body.gravityScale = PlayerObject.GetComponent<Playermovement>().Gravity;


        yield return new WaitForSeconds(10);
        Body.gravityScale = 0;

        StalagtiteObject.transform.position = StartingLocation.position;
        StalagtiteObject.transform.rotation = StartingLocation.rotation;
        Body.constraints = RigidbodyConstraints2D.FreezeAll;
    }


}
