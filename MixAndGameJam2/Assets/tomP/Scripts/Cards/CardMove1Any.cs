using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove1Any : MonoBehaviour
{
    Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>("CardsSprites/CARDS__0008_1X_TOUTSENS");

        GetComponent<CardManager>().setTitle("Move 1 any");
        GetComponent<CardManager>().setDescription("Move the character 1 tile in any direction.");
        GetComponent<CardManager>().setImage(sprite);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
