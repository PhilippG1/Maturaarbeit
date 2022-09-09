using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Script: MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D Collision)
    {
       if (Collision.CompareTag("Player"))
        {
            Collision.GetComponent<Health>().TakeDamage(damage);
            Collision.GetComponent<Playermovement>().isDashing = false;
        }
    }
}
