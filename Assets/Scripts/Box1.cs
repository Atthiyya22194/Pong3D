using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1 : MonoBehaviour
{
    private int score = 1;

    private void Update()
    {
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.instance.ChangeScore(score);
            Destroy(gameObject);
        }
        AudioManager.instance.audioPlay();
    }
}
