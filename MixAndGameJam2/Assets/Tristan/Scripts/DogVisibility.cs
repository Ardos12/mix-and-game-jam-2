using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogVisibility : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log(isPlayerVisible());
        }
    }

    public bool isTileVisible(int x, int z)
    {
        if (x == this.x && z == this.z)
        {
            return true;
        }

        else return false;
    }

    public bool isPlayerVisible()
    {
        if (GetComponent<EnnemiScript>().knockOut > 0)
        {
            return false;
        }

        int x = player.getX();
        int z = player.getZ();

        if (x == this.x && z == this.z)
        {
            return true;
        }

        else return false;
    }
}
