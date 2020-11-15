using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove2Right : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/2RIGHT");

        GetComponent<CardManager>().setTitle("Move 2 down");
        GetComponent<CardManager>().setDescription("Move the character 2 tiles right.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
