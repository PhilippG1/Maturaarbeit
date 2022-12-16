using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour
{
    private Rigidbody2D body;
    void Update()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = body.velocity.normalized * 20;
    }
}
