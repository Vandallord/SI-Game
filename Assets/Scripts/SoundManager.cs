using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioClip _laserSound, _explosionSound;
    [SerializeField] private AudioSource _audioSource;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _laserSound = Resources.Load<AudioClip>("laser");
        _explosionSound = Resources.Load<AudioClip>("explosion");

        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "laser":
                _audioSource.PlayOneShot(_laserSound);
                break;
            case "explosion":
                _audioSource.PlayOneShot(_explosionSound);
                break;
        }
    }
}