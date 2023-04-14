using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    private GameObject player;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Animator anim;
    private bool isActive = false;
    // Start is called before the first frame update

    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    private void OnEnable()
    {
        anim.SetTrigger("Spawn");
    }

    IEnumerator MakePlayerBig()
    {
        xAxis = 2;
        yAxis = 2;
        zAxis = 2;
        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
        yield return new WaitForSeconds(10);
        player.transform.localScale = new Vector3(1, 1, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        //makes player big : yellow skates
        if(other.tag == "Player")
        {
            anim.SetTrigger("Collected");
            StartCoroutine(MakePlayerBig());
        }
    }

}
