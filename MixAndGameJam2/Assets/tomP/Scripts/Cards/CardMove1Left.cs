using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove1Left : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/1LEFT");

        GetComponent<CardManager>().setTitle("Move 1 left");
        GetComponent<CardManager>().setDescription("Move the character 1 tile left.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
