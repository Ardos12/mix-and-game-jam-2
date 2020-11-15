using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public struct Deck
{
    public string name;
    public int number;
}

public class DeckManager : MonoBehaviour
{
    public Deck[] deck;
    /*
     * CARD NAMES FOR THE INITIALISATION
     * m1u : move 1 U
     * m1d : move 1 D
     * m1l : move 1 L
     * m1r : move 1 R
     * m2u : move 2 U
     * m2d : move 2 D
     * m2l : move 2 L
     * m2r : move 2 R 
     * m1 : move 1 in any direction
     * rock : throw a rock
     * hide : hide if can hide
     * hideSpecial : hide at any time
     * KO : knockout an ennemy for 3 turns
     * cosplay : player become "hidden" but can still move
     * owl : alert guards and make them check the owl
     */

    [SerializeField]
    private GameObject card;

    private List<CardManager> cardsInHand;
    private List<CardManager> cardsInDeck;
    private List<CardManager> cardsInTrash;
    private GameController gameController;
    private PlayerController playerController;
    private SoundManager sound;

    private int actionsLeft = 2;

    public bool choosingDir;
    public TMP_Text chooseDir;

    public bool choosingAim;

    void Start()
    {
        cardsInHand = new List<CardManager>();
        cardsInTrash = new List<CardManager>();
        Debug.Log(deck.Length);
        GameObject temp = null;

        for (int i = 0; i < deck.Length; i++)
        {
            temp = null;
            if (deck[i].name == "m1u")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove1Up>(); //AJOUT DU PREFAB 1
                }
            }
            else if (deck[i].name == "m1d")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove1Down>(); //AJOUT DU PREFAB 2
                }
            }
            else if (deck[i].name == "m1l")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove1Left>(); //AJOUT DU PREFAB 3
                }
            }
            else if (deck[i].name == "m1r")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove1Right>(); //AJOUT DU PREFAB 4
                }
            }
            else if (deck[i].name == "m2u")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove2Up>(); //AJOUT DU PREFAB 5
                }
            }
            else if (deck[i].name == "m2d")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove2Down>(); //AJOUT DU PREFAB 6
                }
            }
            else if (deck[i].name == "m2l")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove2Left>(); //AJOUT DU PREFAB 7
                }
            }
            else if (deck[i].name == "m2r")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove2Right>(); //AJOUT DU PREFAB 8
                }
            }
            else if (deck[i].name == "m1")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardMove1Any>(); //AJOUT DU PREFAB 9
                }
            }
            else if (deck[i].name == "rock")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardRock>(); //AJOUT DU PREFAB 10
                }
            }
            else if (deck[i].name == "hide")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardHide>(); //AJOUT DU PREFAB 11
                }
            }
            else if (deck[i].name == "hideSpecial")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardHideSpecial>(); //AJOUT DU PREFAB 12
                }
            }
            else if (deck[i].name == "KO")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardKO>(); //AJOUT DU PREFAB 13
                }
            }
            else if (deck[i].name == "cosplay")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardCosplay>(); //AJOUT DU PREFAB 14
                }
            }
            else if (deck[i].name == "owl")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity, transform);
                    temp.AddComponent<CardOwl>(); //AJOUT DU PREFAB 15
                }
            }
        }
        CardManager[] cards = FindObjectsOfType<CardManager>();
        cardsInDeck = new List<CardManager>(cards);

        cardsInDeck = shuffleList(cardsInDeck);
        gameController = FindObjectOfType<GameController>();
        playerController = FindObjectOfType<PlayerController>();
        sound = FindObjectOfType<SoundManager>();

        chooseDir.enabled = false;
    }

    public List<CardManager> shuffleList(List<CardManager> list)
    {
        int count = list.Count;
        int last = count - 1;
        int r = 0;
        CardManager temp = null;
        for (int i = 0; i < last; i++)
        {
            r = Random.Range(i, count);
            temp = list[i];
            list[i] = list[r];
            list[r] = temp;
        }
        return list;
    }

    public void drawACard()
    {
        cardsInHand.Add(cardsInDeck[0]);
        cardsInDeck.RemoveAt(0);
        if (cardsInDeck.Count == 0)
        {
            resetDeck();
        }
        sound.playDrawCard();
    }

    public void resetDeck()
    {
        cardsInDeck = new List<CardManager>(cardsInTrash);
        cardsInDeck = shuffleList(cardsInDeck);
        cardsInTrash.Clear();

        sound.playCardMelange();
    }

    public void useCard(int index)
    {
        cardsInTrash.Insert(cardsInTrash.Count, cardsInHand[index]);
        cardsInHand.RemoveAt(index);
        actionsLeft--;

        sound.playUseCard();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //for (int i = 0; i < cardsInDeck.Count; i++)
            //{
            //    Debug.Log("Carte " + i + " : " + cardsInDeck[i].getTitle());
                
            //}
            Debug.Log("Pioche : " + cardsInDeck.Count);
            Debug.Log("Defausse : " + cardsInTrash.Count);
            Debug.Log("Main : " + cardsInHand.Count);
        }

        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    if (cardsInHand.Count == 0)
        //    {
        //        Debug.Log("Main vide !");
        //    }
        //    else
        //    {
        //        Debug.Log("Used card !");
        //        useCard(0);
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.Backspace))
        //{
        //    if(cardsInDeck.Count != 0) Debug.Log("Drew card " + cardsInDeck[0].getTitle());
        //    drawACard();
        //}

        if(choosingDir)
        {
            chooseDir.enabled = true;
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                playerController.moveLeft(1);
                choosingDir = false;
            }
            else if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerController.moveUp(1);
                choosingDir = false;
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerController.moveRight(1);
                choosingDir = false;
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                playerController.moveDown(1);
                choosingDir = false;
            }
        }
        else if(choosingAim)
        {
            chooseDir.enabled = true;
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                playerController.koEnemy(0);
                choosingAim = false;
                FindObjectOfType<SoundManager>().playRockThrow();
            }
            else if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerController.koEnemy(1);
                choosingAim = false;
                FindObjectOfType<SoundManager>().playRockThrow();
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerController.koEnemy(2);
                choosingAim = false;
                FindObjectOfType<SoundManager>().playRockThrow();
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                playerController.koEnemy(3);
                choosingAim = false;
                FindObjectOfType<SoundManager>().playRockThrow();
            }
        }
        else if(gameController.getPlayerTurn())
        {
            chooseDir.enabled = false;
            if (actionsLeft == 2) //Begin turn
            {
                if (playerController.getCosplay() > 0) playerController.setCosplay(playerController.getCosplay() - 1);
                else playerController.setHidden(false);
                while (cardsInHand.Count < 5) drawACard();
            }
            else if (actionsLeft <= 0)
            {
                gameController.endPlayerTurn();
                actionsLeft = 2;
            }
        }


        PositionCardsOnScreen();

    }

    public int getCardIndex(CardManager card)
    {
        return cardsInHand.IndexOf(card);
    }

    public void PositionCardsOnScreen()
    {
        PositionHand();
        PositionDeck();
        PositionTrash();
    }

    public void PositionHand()
    {
        foreach(CardManager card in cardsInHand)
        {
            card.transform.rotation = transform.rotation;
            card.isInHand = true;
        }

        switch(cardsInHand.Count)
        {
            case 1:
                cardsInHand[0].position = transform.position + new Vector3(0, -.4f, -2.1f);
                break;
            case 2:
                cardsInHand[0].position = transform.position + new Vector3(-0.62f, -.4f, -2.1f);
                cardsInHand[1].position = transform.position + new Vector3(0.62f, -.4f, -2.1f);
                break;
            case 3:
                cardsInHand[0].position = transform.position + new Vector3(-1.24f, -.4f, -2.1f);
                cardsInHand[1].position = transform.position + new Vector3(0f, -.4f, -2.1f);
                cardsInHand[2].position = transform.position + new Vector3(1.24f, -.4f, -2.1f);
                break;
            case 4:
                cardsInHand[0].position = transform.position + new Vector3(-1.85f, -.4f, -2.1f);
                cardsInHand[1].position = transform.position + new Vector3(-0.62f, -.4f, -2.1f);
                cardsInHand[2].position = transform.position + new Vector3(0.62f, -.4f, -2.1f);
                cardsInHand[3].position = transform.position + new Vector3(1.85f, -.4f, -2.1f);
                break;
            case 5:
                cardsInHand[0].position = transform.position + new Vector3(-2.5f, -.4f, -2.1f);
                cardsInHand[1].position = transform.position + new Vector3(-1.24f, -.4f, -2.1f);
                cardsInHand[2].position = transform.position + new Vector3(0, -.4f, -2.1f);
                cardsInHand[3].position = transform.position + new Vector3(1.24f, -.4f, -2.1f);
                cardsInHand[4].position = transform.position + new Vector3(2.5f, -.4f, -2.1f);
                break;
            case 6:
                cardsInHand[0].position = transform.position + new Vector3(-3.1f, -.4f, -2.1f);
                cardsInHand[1].position = transform.position + new Vector3(-1.85f, -.4f, -2.1f);
                cardsInHand[2].position = transform.position + new Vector3(-0.62f, -.4f, -2.1f);
                cardsInHand[3].position = transform.position + new Vector3(0.62f, -.4f, -2.1f);
                cardsInHand[4].position = transform.position + new Vector3(1.85f, -.4f, -2.1f);
                cardsInHand[5].position = transform.position + new Vector3(3.1f, -.4f, -2.1f);
                break;
            default:
                break;
        }
    }
    public void PositionDeck()
    {
        for(int i = 0; i < cardsInDeck.Count; i++)
        {
            cardsInDeck[i].position = transform.position + new Vector3(-4f, -1.36f + i * 0.05f, -1f);
            cardsInDeck[i].transform.rotation = transform.rotation;
            cardsInDeck[i].transform.Rotate(new Vector3(0, 180, 0));
            cardsInDeck[i].isInHand = false;
        }
    }
    public void PositionTrash()
    {
        for (int i = 0; i < cardsInTrash.Count; i++)
        {
            cardsInTrash[i].position = transform.position + new Vector3(4f, -1.36f + i * 0.05f, -1f);
            cardsInTrash[i].transform.rotation = transform.rotation;
            cardsInTrash[i].isInHand = false;
        }
    }
}
