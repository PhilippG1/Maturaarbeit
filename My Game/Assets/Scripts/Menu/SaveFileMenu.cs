using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFile : MonoBehaviour
{
    private Playermovement playermovement;
    private Health health;


    public void SavePlayer()
    {
        playermovement = GetComponent<Playermovement>();
        health = GetComponent<Health>();
        SaveSystem.SavePlayer(playermovement,health);
    }
    public void LoadPlayer()
    {
        health = GetComponent<Health>();
        playermovement = GetComponent<Playermovement>();
        PlayerData data = SaveSystem.LoadPlayer();

        playermovement.extraJumps = data.jumpCount;
        playermovement.dashAbility = data.canDash;
        playermovement.canWalljump = data.canWalljump;

        health.currentCheckpoint.position = new Vector3 (data.currentCheckpoint[0], data.currentCheckpoint[1], data.currentCheckpoint[2]);
    }

}
