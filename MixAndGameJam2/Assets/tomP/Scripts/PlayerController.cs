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

    [SerializeField]
    private float tileSize;

    void Start()
    {
        hidden = false;
        seen = false;
        hasMoved = false;
        hasActed = false;
        cosplay = 0;
    }

    
    void Update()
    {
        DebugControls();
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
        if(true) // Can move left
        {
            Debug.Log("Gauche");
            transform.position -= new Vector3(tileSize * tileNb, 0, 0);
            hasMoved = true;
        }
    }

    public void moveRight(int tileNb)
    {
        if (true) // Can move right
        {
            Debug.Log("Droite");
            transform.position += new Vector3(tileSize * tileNb, 0, 0);
            hasMoved = true;
        }
    }

    public void moveUp(int tileNb)
    {
        if (true) // Can move up
        {
            Debug.Log("Haut");
            transform.position += new Vector3(0, 0, tileSize * tileNb);
            hasMoved = true;
        }
    }

    public void moveDown(int tileNb)
    {
        if (true) // Can move down
        {
            Debug.Log("Bas");
            transform.position -= new Vector3(0, 0, tileSize * tileNb);
            hasMoved = true;
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
}
