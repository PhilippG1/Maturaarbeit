using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFileMenu : MonoBehaviour
{
    [SerializeField]private GameObject confirmationPrompt;
    private Playermovement playermovement;
    private Health health;
    private GameObject playerObject;

    public void SavePlayer()
    {
        StartCoroutine(ConfirmationBox());
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        playerObject = objs[0];
        playermovement = playerObject.GetComponent<Playermovement>();
        health = playerObject.GetComponent<Health>();
        SaveSystem.SavePlayer(playermovement,health);
    }
    public void LoadPlayer()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        playerObject = objs[0];
        health = playerObject.GetComponent<Health>();
        playermovement = playerObject.GetComponent<Playermovement>();
        PlayerData data = SaveSystem.LoadPlayer();

        playermovement.extraJumps = data.jumpCount;
        playermovement.dashAbility = data.canDash;
        playermovement.wallInteractions = data.wallInteractions;

        health.currentCheckpoint = new Vector3 (data.currentCheckpoint[0], data.currentCheckpoint[1],0);
        playerObject.transform.position = health.currentCheckpoint;

    }
    public void LoadNewPlayer()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length != 0)
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
            playerObject = objs[0];
            health = playerObject.GetComponent<Health>();
            playermovement = playerObject.GetComponent<Playermovement>();


            playermovement.extraJumps = 0;
            playermovement.dashAbility = false;
            playermovement.wallInteractions = false;

            health.currentCheckpoint = new Vector3(-30,-5, 0);
            playerObject.transform.position = health.currentCheckpoint;
        }

    }
    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
