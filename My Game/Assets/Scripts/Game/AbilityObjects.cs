using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityObjects : MonoBehaviour
{
    private GameObject playerObject;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        playerObject = objs[0];
        playerObject.GetComponent<NewAbility>().DisableAbilityObjects();
    }
}
