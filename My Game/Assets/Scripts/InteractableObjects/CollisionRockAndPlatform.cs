using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionRockAndPlatform : MonoBehaviour
{
    private GameObject PlayerObject;
    private void Awake()
    {
        PlayerObject = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    private void Update()
    {
        if (PlayerObject.GetComponent<Health>().dead)
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }

}
