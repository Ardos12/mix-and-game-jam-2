using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityEnnemiDeBase : MonoBehaviour
{

    string currentDirection;
    int x, z;
    PlayerController player;

    Map map;

    // Start is called before the first frame update
    void Start()
    {
        map = FindObjectOfType<Map>();

        x = (int)(transform.position.x / map.sizeTile);
        z = (int)(transform.position.z / map.sizeTile);

        player = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        currentDirection = GetComponent<BasicEnnemiMovement>().currentDirection;
        x = GetComponent<BasicEnnemiMovement>().getX();
        z = GetComponent<BasicEnnemiMovement>().getZ();
        
        
    }

    public bool isTileVisible(int x, int z)
    {
        bool toRet = false;


        if(x == this.x && z == this.z)
        {
            toRet = true;
        }

        else if(currentDirection == "u" && x == this.x && z == this.z + 1)
        {
            toRet = true;
        }

        else if (currentDirection == "d" && x == this.x && z == this.z - 1)
        {
            toRet = true;
        }

        else if (currentDirection == "r" && x == this.x + 1 && z == this.z)
        {
            toRet = true;
        }

        else if (currentDirection == "l" && x == this.x - 1 && z == this.z)
        {
            toRet = true;
        }

        return toRet;
    }

    public bool isPlayerVisible()
    {
        int x = player.getX();
        int z = player.getZ();
        bool toRet = false;

        if (x == this.x && z == this.z && player.getHidden() == false)
        {
            toRet = true;
        }

        else if (currentDirection == "u" && x == this.x && z == this.z + 1 && player.getHidden() == false)
        {
            toRet = true;
        }

        else if (currentDirection == "d" && x == this.x && z == this.z - 1 && player.getHidden() == false)
        {
            toRet = true;
        }

        else if (currentDirection == "r" && x == this.x + 1 && z == this.z && player.getHidden() == false)
        {
            toRet = true;
        }

        else if (currentDirection == "l" && x == this.x - 1 && z == this.z && player.getHidden() == false)
        {
            toRet = true;
        }

        return toRet;
    }
}
