using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicInMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SoundManager>().playMusicMenu();
        FindObjectOfType<SoundManager>().playAmbianceCampfire();
    }
}
