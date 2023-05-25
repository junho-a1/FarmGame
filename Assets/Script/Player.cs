using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public inventory inventory;

    private void Awake()
    {
        inventory = new inventory(21);
    }
    private void Update()
    {
        Debug.Log(transform.position.x);
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector3Int position = new Vector3Int((int)transform.position.x, 
                (int)transform.position.y, 0);

            if(GameManager.Instance.tileManager.IsInteractable(position))
            {
                Debug.Log("good"); ;
                GameManager.Instance.tileManager.SetInteracted(position);
            }
        }
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
