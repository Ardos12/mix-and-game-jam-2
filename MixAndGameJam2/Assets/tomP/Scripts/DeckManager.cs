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

    private List<CardManager> cardsInHand;
    private List<CardManager> cardsInDeck;
    private List<CardManager> cardsInTrash;

    void Start()
    {
        for(int i = 0; i < deck.Length; i++)
        {
            if (deck[i].name == "m1u") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 1
            else if (deck[i].name == "m1d") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 2
            else if (deck[i].name == "m1l") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 3
            else if (deck[i].name == "m1r") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 4
            else if (deck[i].name == "m2u") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 5
            else if (deck[i].name == "m2d") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 6
            else if (deck[i].name == "m2l") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 7
            else if (deck[i].name == "m2r") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 8
            else if (deck[i].name == "m1") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 9
            else if (deck[i].name == "rock") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 10
            else if (deck[i].name == "hide") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 11
            else if (deck[i].name == "hideSpecial") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 12
            else if (deck[i].name == "KO") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 13
            else if (deck[i].name == "cosplay") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 14
            else if (deck[i].name == "owl") for (int j = 0; j < deck[i].number; j++) ; //cardsInDeck.Add() AJOUT DU PREFAB 15
        }

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

    void Update()
    {
        
    }

    public void drawCard()
    {

    }
}
