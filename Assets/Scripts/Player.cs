using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


enum Ability
{
    GRENADE,
    SHIELD,
    COUNT
}

public class Player : MonoBehaviour
{
    private Vector2 movementInput;
    private Vector2 rotationInput; // x is yaw, y is pitch;

    public float walkSpeed;
    public float pitchSpeed;

    public GameObject shield;
    private Material shieldMat;
    private bool shieldsUp;

    private Animator animr;

    public float vectorMultiplier;

    public Transform CamHolder;

    private SMG smg;

    private float camPitch;

    private Vector2 lastMousePosition;
    private Vector2 currentMousePosition;
    private Vector2 deltaMousePosition;

    Ability currentAbility;

    bool controllerMode;

    private PowerBar powerBar;


    // Start is called before the first frame update
    void Start()
    {
        animr = GetComponent<Animator>();
        smg = FindObjectOfType<SMG>();

        smg.cam = GetComponentInChildren<Camera>();

        controllerMode = true;

        shieldMat = shield.GetComponent<MeshRenderer>().material;

        shieldMat.SetFloat("_Alpha", 0);
        shield.SetActive(false);


        powerBar = FindObjectOfType<PowerBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!controllerMode)
            MouseInput();
        
        transform.position += (transform.forward * movementInput.y + transform.right * movementInput.x) * Time.deltaTime * walkSpeed;

        animr.SetFloat("xVel", movementInput.x);
        animr.SetFloat("zVel", movementInput.y);

        transform.Rotate(0, rotationInput.x * pitchSpeed * Time.deltaTime, 0);

        animr.SetFloat("AimAngle", camPitch * -1.0f);

        //if(rotationInput.y > 0)
        //{
        //    camPitch = rotationInput.y * -25.0f;
        //}
        //else if(rotationInput.y < 0)
        //{
        //    camPitch = rotationInput.y * -35.0f;
        //}
        //else
        //{
        //    camPitch = 0.0f;
        //}

        camPitch -= rotationInput.y;
        camPitch = Mathf.Clamp(camPitch, -30, 25);
      
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

    private void MouseInput()
    {
        lastMousePosition = currentMousePosition;
        currentMousePosition = Mouse.current.position.ReadValue();
        deltaMousePosition = currentMousePosition - lastMousePosition;
        rotationInput = deltaMousePosition;
    }

    public void OnNextAbility(InputValue val)
    {
        
        if(currentAbility == Ability.COUNT - 1)
        {
            currentAbility = (Ability)0;
        }
        else
        {
            currentAbility += 1;
        }

        Debug.Log(currentAbility);

        UpdateAbilityUI();
    }
    public void OnPrevAbility(InputValue val)
    {
        if(currentAbility == (Ability)0)
        {
            currentAbility = Ability.COUNT - 1;
        }
        else
        {
            currentAbility -= 1;
        }
        Debug.Log(currentAbility);

        UpdateAbilityUI();
    }

    public void OnModeToggle(InputValue val)
    {
        if(controllerMode)
        {
            controllerMode = false;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            controllerMode = true;
        }
    }

    private void UpdateAbilityUI()
    {
        switch (currentAbility)
        {
            case Ability.SHIELD:
                powerBar.SelectShield();
                break;
            case Ability.GRENADE:             
                powerBar.SelectGrenade();
                break;
            default:
                break;
        }
    }

    public void OnUseAbility(InputValue val)
    {
        if (powerBar.PowerCheck())
        {
            switch (currentAbility)
            {
                case Ability.SHIELD:
                    Shield();
                    
                    break;
                case Ability.GRENADE:
                    Grenade();
                    
                    break;
                default:
                    break;
            }
        }
    }

    public void Shield()
    {
        Debug.Log("Shields up!");
        powerBar.UsePower(0.05f);
        StartCoroutine("shieldSequence");
    }

    IEnumerator shieldSequence()
    {
        animr.SetBool("Shield", true);
        shield.SetActive(true);
        shieldsUp = true;
        yield return new WaitForSeconds(0.5f);
        for(int i = 0; i < 21; i++)
        {
            shieldMat.SetFloat("_Alpha", i * 0.05f);
            yield return new WaitForSeconds(0.05f);
        }
        shieldMat.SetFloat("_Alpha", 1.0f);
        
        yield return new WaitForSeconds(5);
        
        for (int i = 20; i > -1; i--)
        {
            shieldMat.SetFloat("_Alpha", i * 0.05f);
            yield return new WaitForSeconds(0.05f);
        }

        shieldMat.SetFloat("_Alpha", 0.0f);
        shieldsUp = false;
    }

    public void Grenade()
    {
        Debug.Log("Throw Grenade");
        smg.LaunchGrenade();

        powerBar.UsePower(0.2f);
    }

    public void ShieldsDone()
    {
        animr.SetBool("Shield", false);
    }
}
