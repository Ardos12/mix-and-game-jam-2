using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove1Up>(); //AJOUT DU PREFAB 1
                }
            }
            else if (deck[i].name == "m1d")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove1Down>(); //AJOUT DU PREFAB 2
                }
            }
            else if (deck[i].name == "m1l")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove1Left>(); //AJOUT DU PREFAB 3
                }
            }
            else if (deck[i].name == "m1r")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove1Right>(); //AJOUT DU PREFAB 4
                }
            }
            else if (deck[i].name == "m2u")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove2Up>(); //AJOUT DU PREFAB 5
                }
            }
            else if (deck[i].name == "m2d")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove2Down>(); //AJOUT DU PREFAB 6
                }
            }
            else if (deck[i].name == "m2l")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove2Left>(); //AJOUT DU PREFAB 7
                }
            }
            else if (deck[i].name == "m2r")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove2Right>(); //AJOUT DU PREFAB 8
                }
            }
            else if (deck[i].name == "m1")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardMove1Any>(); //AJOUT DU PREFAB 9
                }
            }
            else if (deck[i].name == "rock")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardRock>(); //AJOUT DU PREFAB 10
                }
            }
            else if (deck[i].name == "hide")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardHide>(); //AJOUT DU PREFAB 11
                }
            }
            else if (deck[i].name == "hideSpecial")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardHideSpecial>(); //AJOUT DU PREFAB 12
                }
            }
            else if (deck[i].name == "KO")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardKO>(); //AJOUT DU PREFAB 13
                }
            }
            else if (deck[i].name == "cosplay")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardCosplay>(); //AJOUT DU PREFAB 14
                }
            }
            else if (deck[i].name == "owl")
            {
                for (int j = 0; j < deck[i].number; j++)
                {
                    temp = Instantiate(card, Vector3.zero, Quaternion.identity);
                    temp.AddComponent<CardOwl>(); //AJOUT DU PREFAB 15
                }
            }
        }
        CardManager[] cards = FindObjectsOfType<CardManager>();
        cardsInDeck = new List<CardManager>(cards);

        cardsInDeck = shuffleList(cardsInDeck);
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
        if (cardsInDeck.Count == 0) resetDeck();
    }

    public void resetDeck()
    {
        cardsInDeck = new List<CardManager>(cardsInTrash);
        cardsInDeck = shuffleList(cardsInDeck);
        cardsInTrash.Clear();
    }

    public void useCard(int index)
    {
        cardsInTrash.Add(cardsInHand[index]);
        cardsInHand.RemoveAt(index);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for (int i = 0; i < cardsInDeck.Count; i++)
            {
                Debug.Log("Carte " + i + " : " + cardsInDeck[i].getTitle());
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (cardsInHand.Count == 0)
            {
                Debug.Log("Main vide !");
            }
            else
            {
                Debug.Log("Used card !");
                useCard(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("Drew card " + cardsInDeck[0].getTitle());
            drawACard();
        }
    }
}
