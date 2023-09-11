using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text PotsOfSlopText;
    public Text TurkeyFrierCountText;

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
        _slopKitchenService.CalculateAutoClicks();
    }

    public void Click()
    {
        _audioSource.Play();
        _slopKitchenService.SlopButtonClick();
        UpdateScore();
    }

    private void UpdateScore()
    {
        PotsOfSlopText.text = $"Pots of Slop: {_slopKitchenService.PotsOfSlop}";
    }

    private void PurchaseTurkeyFryer()
    {
        _slopKitchenService.PurchaseTurkeyFrier();
        TurkeyFrierCountText.text = $"Turkey Friers - x{_slopKitchenService.TurkeyFriers} (cost {_slopKitchenService.TurkeyFryerSlopCost})";
    }
}
