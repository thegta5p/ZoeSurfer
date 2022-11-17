using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private const int COIN_VAL = 5;
    public Text scoreText;
    public Text coinScore;
    public Text speedModifier;
    private float modifiedScore;
    private float score;
    private int lastScore;
    private float coinCnt;
    private MovePlayer movePlayer;

    public static GameManager Instance { set; get; }

    private void Awake()
    {
        Instance = this;
        modifiedScore = 1;
        movePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer>();
        speedModifier.text = modifiedScore.ToString("0.0");
        coinScore.text = coinCnt.ToString("0");
        scoreText.text = scoreText.text = score.ToString("0");

    }


    // Update is called once per frame
    void Update()
    {
        score += (Time.deltaTime * modifiedScore);
        if(lastScore != (int)score)
        {
            lastScore = (int)score;
            scoreText.text = score.ToString("0");
        }
    }

    public void GetCoin()
    {
        coinCnt++;
        coinScore.text = coinCnt.ToString("0");
        score += COIN_VAL;
        scoreText.text = scoreText.text = score.ToString("0");

    }


    public void UpdateModifier(float modifierAmount)
    {
        Debug.Log(modifiedScore);
        modifiedScore = 1.0f + modifierAmount;
        speedModifier.text = modifiedScore.ToString("0.0");
    }

}
