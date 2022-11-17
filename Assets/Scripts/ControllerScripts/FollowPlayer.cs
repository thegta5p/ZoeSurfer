using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 5.0f, -10.0f);

    private void Start()
    {
        transform.position = player.position + offset;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = player.position + offset;
        newPosition.x = 0;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
    }
}
