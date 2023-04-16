using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainGame : MonoBehaviour
{
   
    public void NextScene()
    {
        SceneManager.LoadScene("MainGame");
    }


    public void SkinViewerScene()
    {
        SceneManager.LoadScene("SkinViewer");
    }
}
