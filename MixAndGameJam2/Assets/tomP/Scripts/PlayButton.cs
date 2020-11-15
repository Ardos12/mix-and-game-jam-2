using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Sprite play;
    public Sprite playSelected;

    public Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        FindObjectOfType<SoundManager>().playUI1();
        SceneManager.LoadScene(1);
    }

    private void OnMouseOver()
    {
        GetComponent<Button>().image.sprite = playSelected;
    }

    private void OnMouseExit()
    {
        GetComponent<Button>().image.sprite = play;
    }
}
