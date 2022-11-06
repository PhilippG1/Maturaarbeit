using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;


[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int jumpCount;
    public bool canWalljump;
    public bool canDash;
    public float[] currentCheckpoint;

    public PlayerData(Playermovement playermovement, Health health)
    {
        jumpCount = playermovement.extraJumps;
        canDash = playermovement.dashAbility;
        canWalljump = playermovement.canWalljump;
        currentCheckpoint = new float[3];
        currentCheckpoint[0] = health.currentCheckpoint.position.x;
        currentCheckpoint[1] = health.currentCheckpoint.position.y;
        currentCheckpoint[2] = health.currentCheckpoint.position.z;
    }






}
