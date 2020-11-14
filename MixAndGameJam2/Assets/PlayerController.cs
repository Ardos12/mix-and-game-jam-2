using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hidden;
    private bool seen;
    private bool hasMoved;
    private bool hasActed;

    [SerializeField]
    private float tileSize;

    void Start()
    {
        hidden = false;
        seen = false;
        hasMoved = false;
        hasActed = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) moveLeft(1);
        if (Input.GetKeyDown(KeyCode.RightArrow)) moveRight(1);
        if (Input.GetKeyDown(KeyCode.UpArrow)) moveUp(1);
        if (Input.GetKeyDown(KeyCode.DownArrow)) moveDown(1);
    }

    public void moveLeft(int tileNb)
    {
        if(true)
        {
            Debug.Log("Gauche");
            transform.position += new Vector3(tileSize * tileNb, 0, 0);
        }
    }

    public void moveRight(int tileNb)
    {
        if (true)
        {
            Debug.Log("Droite");
            transform.position -= new Vector3(tileSize * tileNb, 0, 0);
        }
    }

    public void moveUp(int tileNb)
    {
        if (true)
        {
            Debug.Log("Haut");
            transform.position -= new Vector3(0, 0, tileSize * tileNb);
        }
    }

    public void moveDown(int tileNb)
    {
        if (true)
        {
            Debug.Log("Bas");
            transform.position += new Vector3(0, 0, tileSize * tileNb);
        }
    }
}
