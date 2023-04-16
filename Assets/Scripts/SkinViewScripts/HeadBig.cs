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
        anim.SetInteger("AnimationNumber", 0);
        currAnimations = 0;
        anim.SetTrigger("ShrinkHead");
        anim.SetBool("IsBigHead", false);
        PlayerPrefs.SetInt("BigHead", 0);
    }


    public void EnlargeHead()
    {
        currAnimations = 0;
        anim.SetInteger("AnimationNumber", 0);
        anim.SetTrigger("MakeHeadBig");
        PlayerPrefs.SetInt("BigHead", 1);
    }

    public void NextAnimation()
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
            case 2:
                if(PlayerPrefs.GetInt("BigHead") == 0)
                {
                    anim.SetInteger("AnimationNumber", 2);
                }
                else
                {
                    anim.SetInteger("AnimationNumber", 2);
                }
                break;
            case 3:
                if(PlayerPrefs.GetInt("BigHead") == 0)
                {
                    anim.SetInteger("AnimationNumber", 3);
                }
                else
                {
                    anim.SetInteger("AnimationNumber", 3);
                }
                break;
        }
    }
}
