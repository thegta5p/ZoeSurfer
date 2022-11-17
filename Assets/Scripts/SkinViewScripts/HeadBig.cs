using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBig : MonoBehaviour
{
    private float xAxis;
    private float yAxis;
    private float zAxis;
    public GameObject player;
  
    public void MakeHeadBig()
    {
        Debug.Log("Start");
        xAxis += 1;
        yAxis += 1;
        zAxis += 1;
        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
        Debug.Log(player.transform.localScale.x);
        //InvokeRepeating("EnlargeHead", 2f, 3f);
    }

    private void EnlargeHead()
    {
        xAxis += 100;
        yAxis += 100;
        zAxis += 100;
        Debug.Log("zoe");
        player.transform.localScale = new Vector3(xAxis, yAxis, zAxis);
    }
}
