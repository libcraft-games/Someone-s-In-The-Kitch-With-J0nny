using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text potsOfSlopText;

    public float potsOfSlop;
    public float slopPerClick;

    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        potsOfSlop = 0;
        slopPerClick = 1;
        _audioSource = GetComponent<AudioSource>();

        if( _audioSource != null)
        {
            Debug.LogError("Failed to find AudioSource.");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Click()
    {
        _audioSource.Play();
        potsOfSlop += slopPerClick;
        UpdateScore();
    }

    private void UpdateScore()
    {
        potsOfSlopText.text = $"Pots of Slop: {potsOfSlop}";
    }
}
