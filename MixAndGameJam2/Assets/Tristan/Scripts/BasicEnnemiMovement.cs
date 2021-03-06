﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnnemiMovement : MonoBehaviour
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
        int[] tabDirection = { 0, 0, 0, 0 }; // 0 : up, 1 : right, 2 : down, 3 : left
        int nbrDirectionPossibility = 0;
        int nextMove = -1;


        if(currentDirection == "u")
        {
            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null && map.getTile(x, z + 1).GetComponent<EndTile>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null && map.getTile(x + 1, z).GetComponent<EndTile>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null && map.getTile(x - 1, z).GetComponent<EndTile>() == null) // LEFT
            {
                tabDirection[3] = 1;
                nbrDirectionPossibility++;
            }
            


            // Can Move Somewhere
            if(nbrDirectionPossibility > 0)
            {
                int min = 1;
                int max = nbrDirectionPossibility + 1;
                int choice = Random.Range(min, max);


                if(tabDirection[0] == 1) // UP
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 0;
                    }
                }

                if (tabDirection[1] == 1) // RIGHT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 1;
                    }
                }

                if (tabDirection[3] == 1) // LEFT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 3;
                    }
                }


            }

            //Have to go back
            else
            {
                transform.LookAt(new Vector3(0, 0, -99999), Vector3.up); 
                currentDirection = "d";
            }
        }


        //--------------------------------------------------------------------------------------------

        else if (currentDirection == "d")
        {
            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null && map.getTile(x, z - 1).GetComponent<EndTile>() == null) //DOWN
            {
                tabDirection[2] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null && map.getTile(x + 1, z).GetComponent<EndTile>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null && map.getTile(x - 1, z).GetComponent<EndTile>() == null) // LEFT
            {
                tabDirection[3] = 1;
                nbrDirectionPossibility++;
            }


            // Can Move Somewhere
            if (nbrDirectionPossibility > 0)
            {
                int min = 1;
                int max = nbrDirectionPossibility + 1;
                int choice = Random.Range(min, max);


                if (tabDirection[2] == 1) // DOWN
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 2;
                    }
                }

                if (tabDirection[1] == 1) // RIGHT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 1;
                    }
                }

                if (tabDirection[3] == 1) // LEFT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 3;
                    }
                }


            }

            //Have to go back
            else
            {
                transform.LookAt(new Vector3(0, 0, 99999), Vector3.up);
                currentDirection = "u";
            }
        }

        //--------------------------------------------------------------------------------------------


        else if (currentDirection == "l")
        {
            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null && map.getTile(x - 1, z).GetComponent<EndTile>() == null) // LEFT
            {
                tabDirection[3] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null && map.getTile(x, z + 1).GetComponent<EndTile>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null && map.getTile(x, z - 1).GetComponent<EndTile>() == null) //DOWN
            {
                tabDirection[2] = 1;
                nbrDirectionPossibility++;
            }


            // Can Move Somewhere
            if (nbrDirectionPossibility > 0)
            {
                int min = 1;
                int max = nbrDirectionPossibility + 1;
                int choice = Random.Range(min, max);


                if (tabDirection[2] == 1) // DOWN
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 2;
                    }
                }

                if (tabDirection[0] == 1) // UP
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 0;
                    }
                }

                if (tabDirection[3] == 1) // LEFT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 3;
                    }
                }


            }

            //Have to go back
            else
            {
                transform.LookAt(new Vector3(99999, 0, 0), Vector3.up);
                currentDirection = "r";
            }
        }

        //--------------------------------------------------------------------------------------------

        else if (currentDirection == "r")
        {

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null && map.getTile(x + 1, z).GetComponent<EndTile>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null && map.getTile(x, z + 1).GetComponent<EndTile>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null && map.getTile(x, z - 1).GetComponent<EndTile>() == null) //DOWN
            {
                tabDirection[2] = 1;
                nbrDirectionPossibility++;
            }

            // Can Move Somewhere
            if (nbrDirectionPossibility > 0)
            {
                int min = 1;
                int max = nbrDirectionPossibility + 1;
                int choice = Random.Range(min, max);


                if (tabDirection[2] == 1) // DOWN
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 2;
                    }
                }

                if (tabDirection[0] == 1) // UP
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 0;
                    }
                }

                if (tabDirection[1] == 1) // RIGHT
                {
                    choice--;
                    if (choice == 0)
                    {
                        nextMove = 1;
                    }
                }


            }

            //Have to go back
            else
            {
                transform.LookAt(new Vector3(-99999, 0, 0), Vector3.up);
                currentDirection = "l";
            }

        }


        //=======================================================================
        // APPLY MOVE

        if(nextMove == 0) // UP
        {
            transform.position += new Vector3(0, 0, map.sizeTile);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            transform.LookAt(new Vector3(0, 0, 99999), Vector3.up);
            currentDirection = "u";
        }

        else if(nextMove == 1) // RIGHT
        {
            transform.position += new Vector3(map.sizeTile, 0, 0);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            transform.LookAt(new Vector3(99999, 0, 0), Vector3.up);
            currentDirection = "r";
        }

        else if (nextMove == 2) // DOWN
        {
            transform.position -= new Vector3(0, 0, map.sizeTile);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            transform.LookAt(new Vector3(0, 0, -99999), Vector3.up);
            currentDirection = "d";
        }

        else if (nextMove == 3) // LEFT
        {
            transform.position -= new Vector3(map.sizeTile, 0, 0);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            transform.LookAt(new Vector3(-99999, 0, 0), Vector3.up);
            currentDirection = "l";
        }
    }
}
