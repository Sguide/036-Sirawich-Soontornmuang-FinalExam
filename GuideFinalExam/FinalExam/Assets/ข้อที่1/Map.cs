using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject[] BlockMap;

    private void Start()
    {
        for (int y = 0; y < 15; y++)
        {
            for (int z = 0; z < 15; z++)
            {
                for (int x = 0; x < 15; x++)
                {
                    transform.position = new Vector3(x, y, z);
                    Instantiate(BlockMap[Random.Range(0, BlockMap.Length)], transform.position, Quaternion.identity);         
                }
                transform.position += new Vector3(0f, 0f, z);
            }
            transform.position += new Vector3(0f, 0f, 0f); 
        }
    }
}

// Hint
// Random.Range