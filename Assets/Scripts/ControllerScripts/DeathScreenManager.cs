using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathScreenManager : MonoBehaviour
{
    int fScore;
    int fCoins;
    public TMP_Text finalScore;
    public TMP_Text finalCoinScore;
    // Start is called before the first frame update
    void Start()
    {
        fScore = PlayerPrefs.GetInt("Score");
        fCoins = PlayerPrefs.GetInt("Coins");


        finalScore.text = "Score: " + fScore.ToString("0");
        finalCoinScore.text = "Coins: " + fCoins.ToString("0");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }

    public void OnMainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu2");
    }
}
