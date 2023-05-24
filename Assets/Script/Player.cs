using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public inventory inventory;

    private void Awake()
    {
        inventory = new inventory(21);
    }
}
