using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int sizeTile = 5;
    GameObject[] tiles;


    // Start is called before the first frame update
    void Start()
    {
        tiles = GameObject.FindGameObjectsWithTag("Tile");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getTile(int x, int z)
    {
        GameObject toRet = null;

        for(int i = 0; i < tiles.Length; i++)
        {
            if(tiles[i].transform.position.x / sizeTile == x && tiles[i].transform.position.z / sizeTile == z)
            {
                toRet = tiles[i];
            }
        }

        return toRet;
    }
}
