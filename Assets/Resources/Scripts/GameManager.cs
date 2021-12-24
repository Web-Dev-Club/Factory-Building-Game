using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> constructPrefabs = new List<GameObject>();

    public void Start()
    {
        foreach (PlayerBase player in FindObjectsOfType<PlayerBase>()) 
        {
            //Make change to player with unlockables and add images to them upon gamemanager start
        }
    }
}
