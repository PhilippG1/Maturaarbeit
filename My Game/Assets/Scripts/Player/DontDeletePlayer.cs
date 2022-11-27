using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDeletePlayer : MonoBehaviour
{
    [SerializeField] GameObject playerObject;
    private void Awake()
    {
        DontDestroyOnLoad(playerObject);
    }
}
