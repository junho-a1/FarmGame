using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public itemManager itemManager;
    public TileManager tileManager;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

        itemManager = GetComponent<itemManager>();
        tileManager = GetComponent<TileManager>();
    }

}
