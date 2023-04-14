using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private const float COIN_VAL = 5;
    public Text scoreText;
    public Text coinScore;
    public Text speedModifier;
    private float modifiedScore;
    private float score;
    private int lastScore;
    private int coinCnt;
    private MovePlayer movePlayer;


    public static GameManager Instance { set; get; }
    public bool IsDead = false;

    private void Awake()
    {
        Instance = this;
        modifiedScore = 1;
        movePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer>();
        speedModifier.text = modifiedScore.ToString("0.0");
        coinScore.text = coinCnt.ToString("0");
        scoreText.text = scoreText.text = score.ToString("0");

    }
    
    public void SetIsDead()
    {
        IsDead = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (!IsDead)
        {
            score += (Time.deltaTime * modifiedScore);
            Debug.Log(lastScore);
            if (lastScore != (int)score)
            {
                lastScore = (int)score;
                scoreText.text = score.ToString("0");
                PlayerPrefs.SetInt("Score", lastScore);
            }
           // Debug.Log("ALIVE");
        }
       
       
    }

    public void GetCoin()
    {
        coinCnt++;
        coinScore.text = coinCnt.ToString("0");
        PlayerPrefs.SetInt("Coins", coinCnt);

    }


    public void UpdateModifier(float modifierAmount)
    {
        Debug.Log(modifiedScore);
        modifiedScore = 1.0f + modifierAmount;
        speedModifier.text = modifiedScore.ToString("0.0");
    }

    public int GetCoinCount() 
    {
        return coinCnt;
    }

    public int GetScore()
    {
        Debug.Log(score);
        return lastScore;
    }


}
