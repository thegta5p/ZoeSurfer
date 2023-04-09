using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform playerTransform;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.forward * playerTransform.position.z;   
    }
}
