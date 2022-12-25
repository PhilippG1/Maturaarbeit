using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyToPlayer : MonoBehaviour
{
    private GameObject PlayerObject;
    private Vector2 direction;
    [SerializeField]private float speed = 2;

    void Start()
    {
        PlayerObject = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        direction = (PlayerObject.transform.position - transform.position).normalized;
        this.gameObject.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
