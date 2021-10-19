using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip sfx;
    private AudioSource ball;
    public static AudioManager music;

    // Start is called before the first frame update
    private void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        music = this;
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        ball = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void audioPlay()
    {
        ball.PlayOneShot(sfx);
    }
}
