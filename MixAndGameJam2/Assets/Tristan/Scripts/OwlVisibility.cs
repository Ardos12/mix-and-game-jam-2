using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlVisibility : MonoBehaviour
{

    public int range = 3;
    string currentDirection;
    int x, z;

    Map map;
    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        map = FindObjectOfType<Map>();
        player = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        currentDirection = GetComponent<OwlBehavior>().currentDirection;

        x = GetComponent<OwlBehavior>().getX();
        z = GetComponent<OwlBehavior>().getZ();

    }

    public bool isTileVisible(int x, int z)
    {
        bool toRet = false;
        bool wall = false;


        if (x == this.x && z == this.z)
        {
            toRet = true;
        }

        else if (currentDirection == "u" && x == this.x)
        {
            for (int i = 1; i <= range; i++)
            {
                if(map.getTile(x, this.z + i) != null && map.getTile(x, this.z + i).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if(z == this.z + i && wall == false)
                {
                    toRet = true;
                }
            } 
        }

        else if (currentDirection == "d" && x == this.x)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(x, this.z - i) != null && map.getTile(x, this.z - i).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (z == this.z - i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        else if (currentDirection == "r" && z == this.z)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(this.x + i, z) != null && map.getTile(this.x + i, z).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (x == this.x + i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        else if (currentDirection == "l" && z == this.z)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(this.x - i, z) != null && map.getTile(this.x - i, z).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (x == this.x - i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        return toRet;
    }

    public bool isPlayerVisible()
    {
        bool toRet = false;
        bool wall = false;

        int x = player.getX();
        int z = player.getZ();


        if (x == this.x && z == this.z && player.getHidden() == false)
        {
            toRet = true;
        }

        else if (currentDirection == "u" && x == this.x && player.getHidden() == false)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(x, this.z + i) != null && map.getTile(x, this.z + i).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (z == this.z + i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        else if (currentDirection == "d" && x == this.x && player.getHidden() == false)
        {
            for (int i = 1; i <= range; i++)
            {

                if (map.getTile(x, this.z - i) != null && map.getTile(x, this.z - i).GetComponent<Wall>() != null)
                {       
                        wall = true;
                }


                if (z == this.z - i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        else if (currentDirection == "r" && z == this.z && player.getHidden() == false)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(this.x + i, z) != null && map.getTile(this.x + i, z).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (x == this.x + i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        else if (currentDirection == "l" && z == this.z && player.getHidden() == false)
        {
            for (int i = 1; i <= range; i++)
            {
                if (map.getTile(this.x - i, z) != null && map.getTile(this.x - i, z).GetComponent<Wall>() != null)
                {
                    wall = true;
                }

                if (x == this.x - i && wall == false)
                {
                    toRet = true;
                }
            }
        }

        return toRet;
    }
}
