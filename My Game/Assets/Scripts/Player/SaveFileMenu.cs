using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFileMenu : MonoBehaviour
{
    private Playermovement playermovement;
    private Health health;
    [SerializeField]private GameObject playerObject;

    public void SavePlayer()
    {
        playermovement = playerObject.GetComponent<Playermovement>();
        health = playerObject.GetComponent<Health>();
        SaveSystem.SavePlayer(playermovement,health);
    }
    public void LoadPlayer()
    {
        health = playerObject.GetComponent<Health>();
        playermovement = playerObject.GetComponent<Playermovement>();
        PlayerData data = SaveSystem.LoadPlayer();

        playermovement.extraJumps = data.jumpCount;
        playermovement.dashAbility = data.canDash;
        playermovement.canWalljump = data.canWalljump;

        health.currentCheckpoint.position = new Vector3 (data.currentCheckpoint[0], data.currentCheckpoint[1], data.currentCheckpoint[2]);
    }

}
