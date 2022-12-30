using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour
{
    private Rigidbody2D body;
    private GameObject PlayerObject;
    private Vector3 StartPosition;
    public bool Rolling;
    private void Awake()
    {
        Rolling = true;
        body = GetComponent<Rigidbody2D>();
        body.constraints = RigidbodyConstraints2D.FreezeAll;
        StartPosition = body.transform.position;
        PlayerObject = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    
    void Update()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = body.velocity.normalized * 5;
        
        if (PlayerObject.GetComponent<Health>().dead && Rolling)
        {
            body.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = StartPosition;
        }
    }
    
}
