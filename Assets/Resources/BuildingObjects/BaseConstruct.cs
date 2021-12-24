using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseConstruct : MonoBehaviour
{
    public string construct_name;
    public GameObject image;
    public GameObject prefab;
    public List<string> costItemNames = new List<string>();
    public List<int> costItemAmounts = new List<int>();

    public bool unlocked;
    //Cost Item Images?
}
