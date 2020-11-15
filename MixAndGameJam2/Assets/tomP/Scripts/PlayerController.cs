using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hidden;
    private bool seen;
    private bool hasMoved;
    private bool hasActed;
    private int cosplay;
    private Map map;

    private int x, z;

    [SerializeField]
    private float tileSize;

    void Start()
    {
        hidden = false;
        seen = false;
        hasMoved = false;
        hasActed = false;
        cosplay = 0;
        map = FindObjectOfType<Map>();

        x = (int) (transform.position.x / tileSize);
        z = (int) (transform.position.z / tileSize);
    }

    
    void Update()
    {
        DebugControls();
        //Debug.Log("X : " + x + "\nZ : " + z);
    }

    private void DebugControls()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) moveLeft(1);
        if (Input.GetKeyDown(KeyCode.RightArrow)) moveRight(1);
        if (Input.GetKeyDown(KeyCode.UpArrow)) moveUp(1);
        if (Input.GetKeyDown(KeyCode.DownArrow)) moveDown(1);
    }

    public void moveLeft(int tileNb)
    {
        for (int i = 0; i < tileNb; i++)
        {
            if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null) // Can move left
            {
                Debug.Log("Gauche");
                transform.position -= new Vector3(tileSize, 0, 0);
                x = (int)(transform.position.x / tileSize);
                z = (int)(transform.position.z / tileSize);
            }
        }
    }

    public void moveRight(int tileNb)
    {
        if (map.getTile(x + 1, z) != null && map.getTile(x + 1, z).GetComponent<Wall>() == null) // Can move right
        {
            Debug.Log("Droite");
            transform.position += new Vector3(tileSize, 0, 0);
            x = (int)(transform.position.x / tileSize);
            z = (int)(transform.position.z / tileSize);
        }
    }

    public void moveUp(int tileNb)
    {
        if (map.getTile(x, z + 1) != null && map.getTile(x, z + 1).GetComponent<Wall>() == null) // Can move up
        {
            Debug.Log("Haut");
            transform.position += new Vector3(0, 0, tileSize);
            x = (int)(transform.position.x / tileSize);
            z = (int)(transform.position.z / tileSize);
        }
    }

    public void moveDown(int tileNb)
    {
        if (map.getTile(x, z - 1) != null && map.getTile(x, z - 1).GetComponent<Wall>() == null) // Can move down
        {
            Debug.Log("Bas");
            transform.position -= new Vector3(0, 0, tileSize);
            x = (int)(transform.position.x / tileSize);
            z = (int)(transform.position.z / tileSize);
        }
    }

    public void hideInTheTile()
    {
        if(true) // Can hide in tile
        {
            hidden = true;
            hasActed = true;
        }
    }

    public void hide()
    {
        hidden = true;
        hasActed = true;
    }

    public void useCosplay()
    {
        cosplay = 3;
        hasActed = true;
    }

    public void imitateOwl()
    {
        /* 
         * For every guard in the 3 tiles range 
         * guard.alert = true;
         * guard.alertPosition = guard.getOwlPosition()
         */
        hasActed = true;
    }

    public int getX()
    {
        return x;
    }
    public int getZ()
    {
        return z;
    }

    public void setX(int newX)
    {
        x = newX;
    }
    public void setZ(int newZ)
    {
        z = newZ;
    }

    public bool getHidden()
    {
        return hidden;
    }
}
