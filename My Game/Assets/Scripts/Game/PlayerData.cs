using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int jumpCount;
    public bool wallInteractions;
    public bool canDash;
    public float[] currentCheckpoint;

    public PlayerData(Playermovement playermovement, Health health)
    {
        jumpCount = playermovement.extraJumps;
        canDash = playermovement.dashAbility;
        wallInteractions = playermovement.wallInteractions;
        currentCheckpoint = new float[3];
        currentCheckpoint[0] = health.currentCheckpoint.x;
        currentCheckpoint[1] = health.currentCheckpoint.y;
        currentCheckpoint[2] = health.currentCheckpoint.z;
    }






}
