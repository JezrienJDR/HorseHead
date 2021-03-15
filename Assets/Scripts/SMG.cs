using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG : MonoBehaviour
{
    public Transform muzzle;
    public ParticleSystem flash;
    public GameObject bulletImpact;

    public float flashOn;
    public float flashOff;

    public Camera cam;

    private LineRenderer beam;
    
    
    // Start is called before the first frame update
    void Start()
    {
        beam = GetComponent<LineRenderer>();
        beam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        beam.SetPosition(0, muzzle.position);

        Ray ray = cam.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        Physics.Raycast(ray, out RaycastHit hit);
        if (hit.point != Vector3.zero)
        {
            beam.SetPosition(1, hit.point);
        }
        else
        {
            beam.SetPosition(1, muzzle.position + transform.up * 50);
        }
        
    }

    public void StartFiring()
    {
        StartCoroutine("BeamFlash");
        flash.Play();
    }

    public void StopFiring()
    {
        StopCoroutine("BeamFlash");
        beam.enabled = false;
        flash.Stop();
    }
    IEnumerator BeamFlash()
    {
        while (true)
        {
            beam.enabled = true;
            Instantiate(bulletImpact, beam.GetPosition(1), Quaternion.identity);
            yield return new WaitForSeconds(flashOn);
            beam.enabled = false;
            yield return new WaitForSeconds(flashOff);
        }
    }
}
