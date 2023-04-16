using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    private const int NUM_OF_SKINS = 2;
    private GameObject[] skins;

    private void Awake()
    {
        skins = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            skins[i] = transform.GetChild(i).gameObject;
        }
    }

    private void Start()
    {
        PlayerPrefs.SetInt("SkinNumber", 0);
    
    }

   

    public void CyberZoeSkin()
    {
        PlayerPrefs.SetInt("SkinNumber", 0);
        for (int i = 0; i <= NUM_OF_SKINS -1; i++)
        {
            skins[i].SetActive(false);
        }
        skins[0].SetActive(true);
        Debug.Log("CYBERZOE");
    }

    public void ArcanistZoeSkin()
    {
        PlayerPrefs.SetInt("SkinNumber", 1);
        for (int i = 0; i < NUM_OF_SKINS - 1; i++)
        {
            skins[i].SetActive(false);
        }
        skins[1].SetActive(true);
        Debug.Log("ARCANISTZOE");
    }

    public void HandleInputData(int SkinNum)
    {
        switch (SkinNum)
        {
            case 0:
                CyberZoeSkin();
                break;
            case 1:
                ArcanistZoeSkin();
                break;
            default:
                Debug.Log("NOT A VALID INPUT");
                break;
        }
    }

}
