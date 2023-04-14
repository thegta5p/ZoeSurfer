using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp3 : MonoBehaviour
{
    private GameObject player;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Animator anim;
    // Start is called before the first frame update


    private void Awake()
    {
        anim= GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    private void OnEnable()
    {
        anim.SetTrigger("Spawn");
    }

    IEnumerator MakePlayerTiny()
    {
        xAxis = 0.25f;
        yAxis = 0.25f;
        zAxis = 0.25f;

        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
        yield return new WaitForSeconds(10);

        player.transform.localScale = new Vector3(1, 1, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        //make player small : pink skates
        if (other.tag == "Player")
        {
            anim.SetTrigger("Collected");
            StartCoroutine(MakePlayerTiny());
        }
    }
}
