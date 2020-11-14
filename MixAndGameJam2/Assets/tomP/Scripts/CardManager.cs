using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text title;

    [SerializeField]
    private TMP_Text description;

    public Vector3 position;
    private Vector3 notSelectedOffset;
    bool isMouseOver;
    public bool isInHand;

    private DeckManager deck;

    private void Start()
    {
        position = transform.position;
        isMouseOver = false;
        isInHand = false;
        notSelectedOffset = new Vector3(0, -0.8f, -1.2f);
        deck = FindObjectOfType<DeckManager>();
    }

    public void Update()
    {
        if (isMouseOver || !isInHand) transform.position = position;
        else transform.position = position + notSelectedOffset;
    }

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void OnMouseDown()
    {
        if(isInHand)
        {
            deck.useCard(deck.getCardIndex(this));
        }
    }

    public void setTitle(string newTitle)
    {
        title.text = newTitle;
    }

    public string getTitle()
    {
        return title.text;
    }

    public void setDescription(string newDescription)
    {
        description.text = newDescription;
    }

    public string getDescription()
    {
        return description.text;
    }
}
