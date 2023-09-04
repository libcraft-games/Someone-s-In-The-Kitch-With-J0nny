using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text potsOfSlopText;

    private SlopKitchenService _slopKitchenService;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    public void Start()
    {
        _slopKitchenService = new();
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
        _slopKitchenService.SlopButtonClick();
        UpdateScore();
    }

    private void UpdateScore()
    {
        potsOfSlopText.text = $"Pots of Slop: {_slopKitchenService.potsOfSlop}";
    }
}
