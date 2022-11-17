using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChanger : MonoBehaviour
{
    public Animator anim;
    
    public void Animation1()
    {
        anim.SetTrigger("Anim1");
    }

    public void Animation2()
    {
        anim.SetTrigger("Anim2");
    }

    public void Animation3()
    {
        anim.SetTrigger("Anim3");
    }

    
}
