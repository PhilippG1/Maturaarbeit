using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAbility : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("WallAbilities"))
        {
            transform.GetComponent<Playermovement>().wallInteractions = true;
            collision.gameObject.SetActive(false);
        }
        if (collision.transform.CompareTag("DoubleJump"))
        {
            transform.GetComponent<Playermovement>().extraJumps = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.transform.CompareTag("DashAbility"))
        {
            transform.GetComponent<Playermovement>().dashAbility = true;
            collision.gameObject.SetActive(false);
        }
    }
    public void DisableAbilityObjects()
    {
        if (transform.GetComponent<Playermovement>().wallInteractions)
        {
            GameObject.FindGameObjectsWithTag("WallAbilities")[0].gameObject.SetActive(false);
        }
        if (transform.GetComponent<Playermovement>().wallInteractions)
        {
            GameObject.FindGameObjectsWithTag("DashAbility")[0].gameObject.SetActive(false);
        }
        if (!(transform.GetComponent<Playermovement>().extraJumps==0))
        {
            GameObject.FindGameObjectsWithTag("DoubleJump")[0].gameObject.SetActive(false);
        }
    }
}

