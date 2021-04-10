using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    private Rigidbody rb;
    private bool available;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Reload();
    }


    private void Reload()
    {
        transform.position = new Vector3(0, -200, 0);
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        available = true;
    }

    private void Explode()
    {
        Instantiate(Resources.Load("Prefabs/GrenadeSparks"), transform.position, Quaternion.Euler(-90, 0, 0));
        Instantiate(Resources.Load("Prefabs/Explosion"), transform.position, Quaternion.Euler(-90,0,0));

        Debug.Log("BOOOOM");
        Reload();
    }

    public void Launch(Vector3 pos, Vector3 trajectory)
    {
        if(!available)
        {
            return;
        }

        available = false;

        rb.useGravity = true;

        transform.position = pos;
        rb.velocity = trajectory * 20;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Explode();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
