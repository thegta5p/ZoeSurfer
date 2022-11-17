using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController playerController;
    private const float LANE_DISTANCE = 3.0f;
    public PlayerController swipeControls;
    public Transform player;
    private float jumpForce;
    private float gravity = 40.0f;
    private float yVel;
    public float xPosOffset = 1.15f;
    public float xPos = 0;
    public float originalSpeed = 5f;
    public float speed;
    private float speedTick;
    private float speedIncreaseTime = 2.5f;
    private float speedIncreaseRate = 0.1f;
    private int desiredLane = 1;
    private bool isAlive = true;
    private Vector3 newPosition;

    // Start is called before the first frame update
    public static MovePlayer Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        speed = originalSpeed;
        jumpForce = 20f;
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if(!isAlive)
        {
            return;
        }

        if(Time.time - speedTick > speedIncreaseTime)
        {
            speedTick = Time.time;
            speed += speedIncreaseRate;
            Debug.Log("test1");
            GameManager.Instance.UpdateModifier(speed - originalSpeed);

        }

        if (swipeControls.SwipeLeft)
        {
            
            MoveLane(false);
     
        }
        if (swipeControls.SwipeRight)
        {

            MoveLane(true);
        }

        if (isGrounded())
        {
            yVel = -0.1f;
            if (swipeControls.SwipeUp || Input.GetKeyDown(KeyCode.Space))
            {
                yVel = jumpForce;
                Debug.Log(yVel);
            }
        }
        else
        {
            yVel -= (gravity * Time.deltaTime);
        }


   //     player.transform.position = Vector3.MoveTowards(player.transform.position, newPosition, speed * Time.deltaTime);

        if (swipeControls.Tap)
        {
            Debug.Log("TAP!");
        }

        //calculate pos
        Vector3 newPosition = transform.position.z * Vector3.forward;

        if (desiredLane == 0)
        {
            newPosition += Vector3.left * LANE_DISTANCE;
        }
        else if (desiredLane == 2)
        {
            newPosition += Vector3.right * LANE_DISTANCE;
        }

        //calc move vector

        Vector3 moveVector = Vector3.zero;
        moveVector.x = (newPosition - transform.position).normalized.x * speed;
        moveVector.y = yVel;
        moveVector.z = speed;


        //moveplayer
        playerController.Move(moveVector * Time.deltaTime);
        

    }


    private void MoveLane(bool goingRight)
    {
        //determines lane
        desiredLane += (goingRight) ? 1 : -1;
        desiredLane = Mathf.Clamp(desiredLane, 0, 2);
    }

    private bool isGrounded()
    {
        Ray groundRay = new Ray( new Vector3(playerController.bounds.center.x, (playerController.bounds.center.y - playerController.bounds.extents.y) + 0.2f, playerController.bounds.center.z), Vector3.down);
        Debug.DrawRay(groundRay.origin, groundRay.direction, Color.cyan, 1.0f);
        return Physics.Raycast(groundRay, 0.2f + 0.1f);
      
    }

    public void SetJumpForce(float force)
    {
        jumpForce = force;
        Debug.Log(jumpForce);
    }

    public float GetJumpForce()
    {
        return jumpForce;
    }
}

