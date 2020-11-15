using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove2Left : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/2LEFT");

        GetComponent<CardManager>().setTitle("Move 2 left");
        GetComponent<CardManager>().setDescription("Move the character 2 tiles left.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
