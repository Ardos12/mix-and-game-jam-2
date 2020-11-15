using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ambiance;
    public AudioClip campfire;
    public AudioClip credits;
    public AudioClip dash1;
    public AudioClip dash2;
    public AudioClip loose;
    public AudioClip win;
    public AudioClip rockThrow;
    public AudioClip rockHit;
    public AudioClip musicLvl1;
    public AudioClip cardMelange1;
    public AudioClip cardMelange2;
    public AudioClip musicMenu;
    public AudioClip owlTurn;
    public AudioClip owlAlert;
    public AudioClip drawCard;
    public AudioClip useCard;
    public AudioClip UI1;
    public AudioClip UI2;
    public AudioClip musicTuto;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioEnemy;
    public AudioSource audioEnemy2;
    public AudioSource musicSource;
    public AudioSource ambiantSource;

    public void playMusicLvl()
    {
        musicSource.Stop();
        musicSource.clip = musicLvl1;
        musicSource.Play();
    }
    public void playMusicMenu()
    {
        musicSource.Stop();
        musicSource.clip = musicMenu;
        musicSource.Play();
    }
    public void playMusicWin()
    {
        musicSource.Stop();
        musicSource.clip = win;
        musicSource.Play();
    }
    public void playMusicLoose()
    {
        musicSource.Stop();
        musicSource.clip = loose;
        musicSource.Play();
    }
    public void playMusicCredits()
    {
        musicSource.Stop();
        musicSource.clip = credits;
        musicSource.Play();
    }
    public void playMusicTuto()
    {
        musicSource.Stop();
        musicSource.clip = musicTuto;
        musicSource.Play();
    }

    public void playAmbianceNature()
    {
        ambiantSource.Stop();
        ambiantSource.clip = ambiance;
        ambiantSource.Play();
    }

    public void playAmbianceCampfire()
    {
        ambiantSource.Stop();
        ambiantSource.clip = campfire;
        ambiantSource.Play();
    }

    public void playDashEnemy()
    {
        audioEnemy.Stop();
        audioEnemy.clip = dash1;
        audioEnemy.Play();
    }
    public void playRockHit()
    {
        audioEnemy.Stop();
        audioEnemy.clip = rockHit;
        audioEnemy.Play();
    }
    public void playRockThrow()
    {
        audioSource2.Stop();
        audioSource2.clip = rockThrow;
        audioSource2.Play();
    }
    public void playDashPlayer()
    {
        audioSource2.Stop();
        audioSource2.clip = dash2;
        audioSource2.Play();
    }
    public void playCardMelange()
    {
        audioSource3.Stop();
        audioSource3.clip = cardMelange1;
        audioSource3.Play();
    }
    public void playOwl()
    {
        audioSource3.Stop();
        audioSource3.clip = owlTurn;
        audioSource3.Play();
    }
    public void playOwlAlert()
    {
        audioEnemy2.Stop();
        audioEnemy2.clip = owlAlert;
        audioEnemy2.Play();
    }

    public void playDrawCard()
    {
        audioSource.Stop();
        audioSource.clip = drawCard;
        audioSource.Play();
    }

    public void playUseCard()
    {
        audioSource.Stop();
        audioSource.clip = useCard;
        audioSource.Play();
    }

    public void playUI1()
    {
        audioSource.Stop();
        audioSource.clip = UI1;
        audioSource.Play();
    }
    public void playUI2()
    {
        audioSource.Stop();
        audioSource.clip = UI2;
        audioSource.Play();
    }

    private void Start()
    {
        musicSource.loop = true;
        ambiantSource.loop = true;
    }
}
