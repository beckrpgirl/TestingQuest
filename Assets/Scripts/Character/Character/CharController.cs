using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public string moveStatus = "idle";
    public bool walkByDefault = true;
    public float gravity = 20.0f;

    public float jumpSpeed = 8.0f;
    public float runSpeed = 10.0f;
    public float walkSpeed = 4.0f;
    public float turnSpeed = 250.0f;
    public float moveBackwardsMultiplyer = 0.75f;

    float speedMultiplyer = 0.0f;
    bool grounded = false;
    Vector3 moveDirection = Vector3.zero;
    bool isWalking = false;
    bool jumping = false;
    bool mouseSlideButton = false;
    CharacterController controller;
    Animator animController;
    GameManager gm;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animController = GetComponent<Animator>();
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gm.isPaused)
        {
            moveStatus = "idle";
            isWalking = walkByDefault;

            if (Input.GetAxis("Run") != 0)
                isWalking = !walkByDefault;

            if (grounded)
            {
                if (Input.GetMouseButton(1))
                {
                    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                }
                else
                {
                    moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
                }

                if (Input.GetButtonDown("Toggle Move"))
                {
                    mouseSlideButton = !mouseSlideButton;
                }

                if (mouseSlideButton && (Input.GetAxis("Vertical") != 0 || Input.GetButton("Jump")) || (Input.GetMouseButton(0) && Input.GetMouseButton(1)))
                {
                    mouseSlideButton = false;
                }
                if ((Input.GetMouseButton(0) && Input.GetMouseButton(1)) || mouseSlideButton)
                {
                    moveDirection.z = 1;
                }
                if (!(Input.GetMouseButton(1) && Input.GetAxis("Horizontal") != 0))
                {
                    moveDirection.x -= Input.GetAxis("Strafing");
                }
                if (((Input.GetMouseButton(1) && Input.GetAxis("Horizontal") != 0) || Input.GetAxis("Strafing") != 0) && Input.GetAxis("Vertical") != 0)
                {
                    moveDirection *= 0.707f;
                }

                if ((Input.GetMouseButton(1) && Input.GetAxis("Horizontal") != 0) || Input.GetAxis("Strafing") != 0 || Input.GetAxis("Vertical") < 0)
                {
                    speedMultiplyer = moveBackwardsMultiplyer;
                }
                else
                {
                    speedMultiplyer = 1;
                }

                moveDirection *= isWalking ? walkSpeed * speedMultiplyer : runSpeed * speedMultiplyer;

                if (Input.GetButton("Jump"))
                {
                    jumping = true;
                    moveDirection.y = jumpSpeed;
                }

                if (moveDirection.z > 0)
                {
                    moveStatus = isWalking ? "walking" : "running";
                    animController.SetFloat("Speed", moveDirection.z);
                }

                if (moveDirection.x < 0)
                {
                    moveStatus = isWalking ? "walkingRight" : "runningRight";
                    animController.SetFloat("Speed", -moveDirection.x);
                }
                if (moveDirection.x > 0)
                {
                    moveStatus = isWalking ? "walkingLeft" : "runningLeft";
                    animController.SetFloat("Speed", moveDirection.x);
                }

                animController.SetFloat("Direction", moveDirection.x);

                moveDirection = transform.TransformDirection(moveDirection);
            }

            if (Input.GetButton("Attack"))
            {
                animController.SetBool("Attack", true);
            } else
            {
                animController.SetBool("Attack", false);
            }

            if (Input.GetMouseButton(1))
            {
                transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
            }
            else
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            }

            moveDirection.y -= gravity * Time.deltaTime;

            grounded = ((controller.Move(moveDirection * Time.deltaTime)) & CollisionFlags.Below) != 0;

            jumping = grounded ? false : jumping;

            if (jumping)
                moveStatus = "jump";
        }

    }
}
