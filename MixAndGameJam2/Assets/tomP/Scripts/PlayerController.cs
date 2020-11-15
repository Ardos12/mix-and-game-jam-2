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
        cosplay = 0;
        map = FindObjectOfType<Map>();

        x = (int) (transform.position.x / tileSize);
        z = (int) (transform.position.z / tileSize);
    }

    
    void Update()
    {
        //DebugControls();
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
        if (map.getTile(x - 1, z) != null && map.getTile(x - 1, z).GetComponent<Wall>() == null) // Can move left
        {
            Debug.Log("Gauche");
            transform.position -= new Vector3(tileSize, 0, 0);
            x = (int)(transform.position.x / tileSize);
            z = (int)(transform.position.z / tileSize);
            transform.LookAt(new Vector3(-99999, 0, 0), Vector3.up);
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
            transform.LookAt(new Vector3(99999, 0, 0), Vector3.up);
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
            transform.LookAt(new Vector3(0, 0, 99999), Vector3.up);
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
            transform.LookAt(new Vector3(0, 0, -99999), Vector3.up);
        }
    }

    public void hideInTheTile()
    {
        //if(map.getTile(x, z).GetComponent<CanHide>() != null) // Can hide in tile
        //{
        //    hidden = true;
        //}
    }

    public void hide()
    {
        hidden = true;
    }

    public void koEnemy()
    {
        /*WIP*/
    }

    public void useCosplay()
    {
        hidden = true;
        cosplay = 2;
    }

    public void imitateOwl()
    {
        /* 
         * For every guard in the 3 tiles range 
         * guard.alert = true;
         * guard.alertPosition = guard.getOwlPosition()
         */
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

    public void setHidden(bool value)
    {
        hidden = value;
    }

    public int getCosplay()
    {
        return cosplay;
    }

    public void setCosplay(int newValue)
    {
        cosplay = newValue;
    }
}
