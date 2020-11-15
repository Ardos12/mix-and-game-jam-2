using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRock : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/THROW");

        GetComponent<CardManager>().setTitle("Throw a rock");
        GetComponent<CardManager>().setDescription("Throw a rock that alert the enemies near it's hit position.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
