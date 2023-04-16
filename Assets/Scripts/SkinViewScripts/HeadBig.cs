using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class HeadBig : MonoBehaviour
{
    private Animator anim;

    public int numOfAnimations = 2;
    private int currAnimations = 0;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        if(PlayerPrefs.GetInt("BigHead") == 1)
        {
            anim.SetBool("IsBigHead", true);
        }
        else
        {
            anim.SetBool("IsBigHead", false);
        }
    }

    public void ShrinkHead()
    {
        anim.SetTrigger("ShrinkHead");
        anim.SetBool("IsBigHead", false);
        PlayerPrefs.SetInt("BigHead", 0);
    }


    public void EnlargeHead()
    {
        anim.SetTrigger("MakeHeadBig");
        PlayerPrefs.SetInt("BigHead", 1);
    }

    public void NextSkin()
    {
        currAnimations++;
        if (currAnimations > numOfAnimations-1) {
            currAnimations = 0;
        }

        switch (currAnimations)
        {
            case 0: 
                if(PlayerPrefs.GetInt("BigHead") == 0)
                {
                    anim.SetInteger("AnimationNumber", 0);
                }
                else
                {
                    anim.SetInteger("AnimationNumber", 0);
                }
                break;
            case 1: 
                if(PlayerPrefs.GetInt("BigHead") == 0)
                {
                    anim.SetInteger("AnimationNumber", 1);
                }
                else
                {
                    anim.SetInteger("AnimationNumber", 1);
                }
                break;
        }
    }
}
