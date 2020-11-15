using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHide : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/HIDE");

        GetComponent<CardManager>().setTitle("Hide");
        GetComponent<CardManager>().setDescription("You hide in a tree for 1 turn.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
