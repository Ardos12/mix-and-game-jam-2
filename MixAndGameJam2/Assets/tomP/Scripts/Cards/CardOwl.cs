using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOwl : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/CARDS__0010_OWL");

        GetComponent<CardManager>().setTitle("Scare the owl");
        GetComponent<CardManager>().setDescription("The owl is scared by some noise and alert the enemies near it's position.");
        GetComponent<CardManager>().setImage(sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
