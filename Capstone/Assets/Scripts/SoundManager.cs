using UnityEngine;
using UnityEngine.Audio;
using System;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;

    public static SoundManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        /*
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        */

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Update is called once per frame
    void Start()
    {
        Play("TitleSong");

    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }

        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.Stop();
    }
    public void Mute(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = 0;
    }

    public void UnMute(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.volume = 0.25f;
    }

}