using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
