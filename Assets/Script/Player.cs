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

    public void DropItem(collectable item)
    {
        Vector2 spawnLocation = transform.position;
        
        Vector2 spawnOffset = Random.insideUnitCircle * 1.25f;

        collectable droppedItem =  Instantiate(item, spawnLocation + spawnOffset,
            Quaternion.identity);

        droppedItem.rb2d.AddForce(spawnOffset * 2f, ForceMode2D.Impulse);

    }
}
