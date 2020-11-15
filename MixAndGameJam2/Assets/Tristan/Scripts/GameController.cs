using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{

    bool playerturn;
    GameObject[] ennemies;
    PlayerController player;
    bool win;
    bool loose;
    Map map;

    // Start is called before the first frame update
    void Start()
    {
        playerturn = true;
        ennemies = GameObject.FindGameObjectsWithTag("Ennemi");
        player = GameObject.FindObjectOfType<PlayerController>();
        map = FindObjectOfType<Map>();
        win = false;
        loose = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            endPlayerTurn();
        }
        
        // TEST LA WIN
        if(map.getTile(player.getX(), player.getZ()).GetComponent<EndTile>() != null && win == false && loose == false)
        {
            win = true;
            Debug.Log("C'EST GAGNE !!!!!");
        }


        // TEST LA LOOSE
        if (playerSeen() && win == false && loose == false)
        {
            loose = true;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("T'as perdu t'es une merde !!");
        }
        
    }

    public void endPlayerTurn()
    {
        playerturn = false;


        foreach(GameObject ennemi in ennemies)
        {
            if(ennemi.GetComponent<BasicEnnemiMovement>() != null)
            {
                ennemi.GetComponent<BasicEnnemiMovement>().move();
            }

            else if (ennemi.GetComponent<OwlBehavior>() != null)
            {
                ennemi.GetComponent<OwlBehavior>().move();
            }
        }


        playerturn = true;
    }

    bool playerSeen()
    {
        bool toRet = false;
        
        foreach (GameObject ennemi in ennemies)
        {
            if(ennemi.GetComponent<VisibilityEnnemiDeBase>() != null)
            {
                if (ennemi.GetComponent<VisibilityEnnemiDeBase>().isPlayerVisible())
                {
                    toRet = true;
                }
            }

            if (ennemi.GetComponent<OwlVisibility>() != null)
            {
                if (ennemi.GetComponent<OwlVisibility>().isPlayerVisible())
                {
                    toRet = true;
                }
            }

            if (ennemi.GetComponent<DogVisibility>() != null)
            {
                if (ennemi.GetComponent<DogVisibility>().isPlayerVisible())
                {
                    toRet = true;
                }
            }
        }

        return toRet;
    }

    public bool getPlayerTurn()
    {
        return playerturn;
    }
}
