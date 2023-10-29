using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCanvasScript : MonoBehaviour
{
    public GameObject[] items;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CreateItem(int number)
    {
        Instantiate(items[number], spawnPoint.transform.position, items[number].transform.rotation);
    }
}
