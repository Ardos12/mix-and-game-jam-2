using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMusicTuto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SoundManager>().playMusicTuto();
        FindObjectOfType<SoundManager>().playAmbianceNature();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
