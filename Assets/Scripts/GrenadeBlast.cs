using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBlast : MonoBehaviour
{
    private Vector3 ones = new Vector3(1, 1, 1);
    private Material mat;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero;

        mat = GetComponent<MeshRenderer>().material;

        StartCoroutine("Explode");

        
    }


    IEnumerator Explode()
    {
        yield return new WaitForSeconds(0.1f);

        for(int i = 0; i < 15; i++)
        {
            transform.localScale = ones * 20 * i;
            yield return new WaitForSeconds(0.01f);

        }

        for (int i = 0; i < 60; i++)
        {
            transform.localScale = ones * (300 + i);

            mat.SetFloat("_Alpha", 12.0f - 12.0f / 60.0f * i);
            mat.SetFloat("_Vivid", 2.77f - 2.77f / 60.0f * i);

            yield return new WaitForSeconds(0.01f);
        }

        Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().ApplyDamage(200);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
