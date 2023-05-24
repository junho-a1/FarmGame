using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{
    public collectable[] collectabIetems;

    private Dictionary<collectableType, collectable> collectableItemsDict = 
        new Dictionary<collectableType, collectable>();

    private void Awake()
    {
        foreach(collectable item in collectabIetems)
        {
            AddItem(item);
        }
    }

    private void AddItem(collectable item)
    {
        if(!collectableItemsDict.ContainsKey(item.type)) 
        {
            collectableItemsDict.Add(item.type, item); 
        }
    }

    public collectable GetItemByType(collectableType type)
    {
        if(collectableItemsDict.ContainsKey(type))
        {
            return collectableItemsDict[type];
        }
        return null;
    }

}
