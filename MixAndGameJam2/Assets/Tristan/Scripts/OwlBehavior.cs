using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBehavior : MonoBehaviour
{

    public string currentDirection = "d"; // u, d, r, l = up, down, right, left

    Map map;
    int x, z;

    // Start is called before the first frame update
    void Start()
    {
        map = FindObjectOfType<Map>();

        x = (int)(transform.position.x / map.sizeTile);
        z = (int)(transform.position.z / map.sizeTile);

        if (currentDirection == "u") // UP
        {
            transform.LookAt(new Vector3(0, 0, 99999), Vector3.up);
        }

        else if (currentDirection == "d") // DOWN
        {
            transform.LookAt(new Vector3(0, 0, -99999), Vector3.up);
        }

        else if (currentDirection == "r") // RIGHT
        {
            transform.LookAt(new Vector3(99999, 0, 0), Vector3.up);
        }

        else if (currentDirection == "l") // LEFT
        {
            transform.LookAt(new Vector3(-99999, 0, 0), Vector3.up);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            move();
        }
    }

    public int getX()
    {
        return x;
    }

    public int getZ()
    {
        return z;
    }

    public void move()
    {
        if(currentDirection == "u")
        {
            transform.LookAt(new Vector3(99999, 0, 0), Vector3.up);
            currentDirection = "r";
        }

        else if (currentDirection == "r")
        {
            transform.LookAt(new Vector3(0, 0, -99999), Vector3.up);
            currentDirection = "d";
        }

        else if (currentDirection == "d")
        {
            transform.LookAt(new Vector3(-99999, 0, 0), Vector3.up);
            currentDirection = "l";
        }

        else if (currentDirection == "l")
        {
            transform.LookAt(new Vector3(0, 0, 99999), Vector3.up);
            currentDirection = "u";
        }
    }
}
