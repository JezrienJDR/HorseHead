using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 movementInput;
    private Vector2 rotationInput; // x is yaw, y is pitch;

    public float walkSpeed;
    public float pitchSpeed;

    private Animator animr;

    public float vectorMultiplier;

    public Transform CamHolder;

    private SMG smg;

    private float camPitch;

    // Start is called before the first frame update
    void Start()
    {
        animr = GetComponent<Animator>();
        smg = FindObjectOfType<SMG>();

        smg.cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.forward * movementInput.y + transform.right * movementInput.x) * Time.deltaTime * walkSpeed;

        animr.SetFloat("xVel", movementInput.x);
        animr.SetFloat("zVel", movementInput.y);

        transform.Rotate(0, rotationInput.x * pitchSpeed * Time.deltaTime, 0);

        animr.SetFloat("AimAngle", rotationInput.y * 30.0f);

        if(rotationInput.y > 0)
        {
            camPitch = rotationInput.y * -25.0f;
        }
        else if(rotationInput.y < 0)
        {
            camPitch = rotationInput.y * -35.0f;
        }
        else
        {
            camPitch = 0.0f;
        }

        CamHolder.localRotation = Quaternion.Euler(camPitch, 0.0f, 0.0f);
        //Debug.Log(movementInput.y);
    }


    public void OnMove(InputValue val)
    {
        movementInput = val.Get<Vector2>() * vectorMultiplier;
    }
    public void OnLook(InputValue val)
    {
        rotationInput = val.Get<Vector2>();
    }

    public void OnFire(InputValue val)
    {
        if (val.isPressed) smg.StartFiring();
        else smg.StopFiring();
    }

}
