using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStoneEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("Rock"))
        {
            Collision.GetComponent<RollingStone>().Rolling = false;
        }
    }
}
