using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] musicSounds, sfxSound;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "scene_one")
        {
            PlayMusic(musicSounds[0].name);
        }
        else
        {
            PlayMusic(musicSounds[1].name);
        }
    }
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null )
        {
            Debug.Log("could not find this sound");
        }
        else
        {
            musicSource.clip = s.sound;
            musicSource.Play();
        }
    }
    public void PlaySfx(string name)
    {
        Sound s = Array.Find(sfxSound, x => x.name == name);

        if (s == null)
        {
            Debug.Log("could not find this sound");
        }
        else
        {
            sfxSource.PlayOneShot(s.sound);
        }
    }
}
