using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp3 : MonoBehaviour
{
    public GameObject player;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MakePlayerTiny()
    {
        xAxis = 0.5f;
        yAxis = 0.5f;
        zAxis = 0.5f;

        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
        yield return new WaitForSeconds(10);

        player.transform.localScale = new Vector3(1, 1, 1);
        Destroy(gameObject, 1.5f);
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
