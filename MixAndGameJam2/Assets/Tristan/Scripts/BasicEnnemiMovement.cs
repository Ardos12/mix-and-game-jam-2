using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            move();
        }
    }

    public void move()
    {
        int[] tabDirection = { 0, 0, 0, 0 }; // 0 : up, 1 : right, 2 : down, 3 : left
        int nbrDirectionPossibility = 0;
        int nextMove = -1;


        if(currentDirection == "u")
        {
            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null) // LEFT
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
                nextMove = 2;
            }
        }


        //--------------------------------------------------------------------------------------------

        if (currentDirection == "d")
        {
            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null) //DOWN
            {
                tabDirection[2] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null) // LEFT
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
                nextMove = 0;
            }
        }

        //--------------------------------------------------------------------------------------------


        if (currentDirection == "l")
        {
            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null) // LEFT
            {
                tabDirection[3] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null) //DOWN
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
                nextMove = 1;
            }
        }

        //--------------------------------------------------------------------------------------------

        if (currentDirection == "r")
        {

            if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null) // RIGHT
            {
                tabDirection[1] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null) // UP
            {
                tabDirection[0] = 1;
                nbrDirectionPossibility++;
            }

            if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null) //DOWN
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
                nextMove = 3;
            }

        }


        //=======================================================================
        // APPLY MOVE

        if(nextMove == 0) // UP
        {
            transform.position += new Vector3(0, 0, map.sizeTile);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            currentDirection = "u";
        }

        else if(nextMove == 1) // RIGHT
        {
            transform.position += new Vector3(map.sizeTile, 0, 0);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            currentDirection = "r";
        }

        else if (nextMove == 2) // DOWN
        {
            transform.position -= new Vector3(0, 0, map.sizeTile);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            currentDirection = "d";
        }

        else if (nextMove == 3) // LEFT
        {
            transform.position -= new Vector3(map.sizeTile, 0, 0);
            x = (int)(transform.position.x / map.sizeTile);
            z = (int)(transform.position.z / map.sizeTile);

            currentDirection = "l";
        }
    }
}
