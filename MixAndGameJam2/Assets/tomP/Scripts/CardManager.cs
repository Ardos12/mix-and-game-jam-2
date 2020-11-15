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
    
    [SerializeField]
    private SpriteRenderer sprite;

    public Vector3 position;
    private Vector3 notSelectedOffset;
    bool isMouseOver;
    public bool isInHand;
    public bool choosingDir;

    private DeckManager deck;
    private GameController gameController;
    private PlayerController playerController;

    private void Start()
    {
        position = transform.position;
        isMouseOver = false;
        isInHand = false;
        notSelectedOffset = new Vector3(0, -0.4f, -.6f);
        deck = FindObjectOfType<DeckManager>();
        gameController = FindObjectOfType<GameController>();
        playerController = FindObjectOfType<PlayerController>();
        choosingDir = false;
    }

    public void Update()
    {
        if (isMouseOver || !isInHand || !gameController.getPlayerTurn()) transform.position = position;
        else transform.position = position + notSelectedOffset;
    }

    private void OnMouseOver()
    {
        if(gameController.getPlayerTurn() && !deck.choosingDir) isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void OnMouseDown()
    {
        if(isInHand && gameController.getPlayerTurn() && !deck.choosingDir)
        {
            useCard();
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

    public void setImage(Sprite sprt)
    {
        sprite.sprite = sprt;
    }

    public void useCard()
    {
        if (GetComponent<CardMove1Up>() != null) playerController.moveUp(1);
        else if (GetComponent<CardMove1Down>() != null) playerController.moveDown(1);
        else if (GetComponent<CardMove1Left>() != null) playerController.moveLeft(1);
        else if (GetComponent<CardMove1Right>() != null) playerController.moveRight(1);
        else if (GetComponent<CardMove2Up>() != null) for (int i = 0; i < 2; i++) playerController.moveUp(1);
        else if (GetComponent<CardMove2Down>() != null) for (int i = 0; i < 2; i++) playerController.moveDown(1);
        else if (GetComponent<CardMove2Left>() != null) for (int i = 0; i < 2; i++) playerController.moveLeft(1);
        else if (GetComponent<CardMove2Right>() != null) for (int i = 0; i < 2; i++) playerController.moveRight(1);
        else if (GetComponent<CardMove1Any>() != null)
        {
            deck.choosingDir = true;
        }
        else if (GetComponent<CardHide>() != null) playerController.hideInTheTile();
        else if (GetComponent<CardHideSpecial>() != null) playerController.hide();
        else if (GetComponent<CardRock>() != null) playerController.koEnemy();
        else if (GetComponent<CardCosplay>() != null) playerController.useCosplay();
        else if (GetComponent<CardOwl>() != null) playerController.imitateOwl();
    }
}
