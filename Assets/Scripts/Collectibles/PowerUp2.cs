using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public GameObject player;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Animator anim;
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MakePlayerBig()
    {
        xAxis = 2;
        yAxis = 2;
        zAxis = 2;
        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
        yield return new WaitForSeconds(10);
        player.transform.localScale = new Vector3(1, 1, 1);
        Destroy(gameObject, 1.5f);
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
