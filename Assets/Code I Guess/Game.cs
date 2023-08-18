using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text potsOfSlopText;
    public float potsOfSlop;
    public float slopPerClick;

    // Start is called before the first frame update
    void Start()
    {
        potsOfSlop = 0;
        slopPerClick = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        potsOfSlop += slopPerClick;
        UpdateScore();
    }

    private void UpdateScore()
    {
        potsOfSlopText.text = $"Pots of Slop: {potsOfSlop}";
    }
}
