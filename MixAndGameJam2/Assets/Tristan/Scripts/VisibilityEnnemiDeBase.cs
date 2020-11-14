using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityEnnemiDeBase : MonoBehaviour
{

    string currentDirection;
    int x, z;

    Map map;

    // Start is called before the first frame update
    void Start()
    {
        map = FindObjectOfType<Map>();

        x = (int)(transform.position.x / map.sizeTile);
        z = (int)(transform.position.z / map.sizeTile);
    }

    // Update is called once per frame
    void Update()
    {
        currentDirection = GetComponent<BasicEnnemiMovement>().currentDirection;

        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    PlayerController player = FindObjectOfType<PlayerController>();

        //    Debug.Log("Direction ennemi : " + currentDirection);

        //    isTileVisible(player.x)
        //}
    }

    public bool isTileVisible(int x, int z)
    {
        bool toRet = false;

        if(currentDirection == "u" && x == this.x && z == this.z + 1)
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
}
