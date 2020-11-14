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

    public void setTitle(string newTitle)
    {
        title.text = newTitle;
    }

    public void setDescription(string newDescription)
    {
        description.text = newDescription;
    }
}
