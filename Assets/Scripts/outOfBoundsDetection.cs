using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class outOfBoundsDetection : MonoBehaviour
{
    public float deathY = -2;

    [Tooltip("List of scripts to run on object death")]
    public teleportTo tp;
    public colorChangeToRGB colorChange;

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
                //Debug.Log("Item is at "+item.transform.position.y);
                if (item.transform.position.y < deathY)
                {
                    //Debug.Log("Item is BELOW WORLD LEVEL ");
                    runDeathScripts(item);
                }
            }

        }
    }

    void runDeathScripts(GameObject item)
    {
        //Debug.Log("Running death scripts");
        tp.teleport(item);
        colorChange.runColorChange(item, UnityEngine.Random.Range(0,256), UnityEngine.Random.Range(0, 256), UnityEngine.Random.Range(0, 256));
    }
}
