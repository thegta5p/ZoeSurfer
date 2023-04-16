using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScripts : MonoBehaviour
{

    Animator anim;

    private void Awake()
    {
        anim= GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("BigHead") == 1)
        {
            anim.SetBool("IsBigHead", true);
        }
        else
        {
            anim.SetBool("IsBigHead", false);
        }
    }

  
}
