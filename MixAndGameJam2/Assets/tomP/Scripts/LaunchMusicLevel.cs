using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMusicLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SoundManager>().playMusicLvl();
        FindObjectOfType<SoundManager>().playAmbianceNature();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
