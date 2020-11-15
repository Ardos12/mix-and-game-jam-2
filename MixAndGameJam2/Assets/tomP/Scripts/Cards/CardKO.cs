using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardKO : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/KNOCKOUT");

        GetComponent<CardManager>().setTitle("Knockout");
        GetComponent<CardManager>().setDescription("You put an enemy to sleep for 4 turns.");
        GetComponent<CardManager>().setImage(sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
