using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class outOfBoundsDetection : MonoBehaviour
{
    public float deathY = -2;

    [Tooltip("List of scripts to run on object death")]
    public teleportTo tp;

    [Header("Item List")]
    [Tooltip("List of items to detect if they fall out of bounds")]
    public List<GameObject> itemsList = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //if  fell out of bounds
        //run scripts in list
            //can include: tp to spawn, spawn new object, delete this object, etc. 

        foreach(GameObject item in itemsList)
        {
            if (item != null)
            {
                if (transform.position.y < deathY)
                {
                    runDeathScripts(item);
                }
            }

        }
        
        
    }

    void runDeathScripts(GameObject item)
    {
        tp.teleport(item);
    }
}
