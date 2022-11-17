using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float tempForce;
    private float newForce;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    IEnumerator Effect()
    {
        tempForce = MovePlayer.Instance.GetJumpForce();
        newForce = MovePlayer.Instance.GetJumpForce() + 10f;
        MovePlayer.Instance.SetJumpForce(newForce);
        yield return new WaitForSeconds(5f);
        MovePlayer.Instance.SetJumpForce(newForce - 10f);
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //makes player jump higher : blue skates
        if (other.tag == "Player")
        {
            anim.SetTrigger("Collected");
            StartCoroutine(Effect());
        }
    }
    
}
