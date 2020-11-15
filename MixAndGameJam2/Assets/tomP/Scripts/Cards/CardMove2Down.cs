using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove2Down : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/CARDS__0004_2X_DOWN");

        GetComponent<CardManager>().setTitle("Move 2 down");
        GetComponent<CardManager>().setDescription("Move the character 2 tiles down.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
