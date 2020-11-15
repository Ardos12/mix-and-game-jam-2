using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCosplay : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/HIDE_SPECIAL");

        GetComponent<CardManager>().setTitle("Bush cosplay");
        GetComponent<CardManager>().setDescription("The character can't be seen for 3 turns.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
