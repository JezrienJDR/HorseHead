using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Image bar;
    public float fillRate;
    public float ratio;

    public Image grenade;
    public Image shield;

    private float y;
    private float x;

    public void SetRatio(float r)
    {
        ratio = r;
    }

    public void SetFillRate(float r)
    {
        fillRate = r;
    }

    // Start is called before the first frame update
    void Start()
    {
        y = bar.rectTransform.localScale.y;
        x = bar.rectTransform.localScale.x;
        ratio = 0;
        fillRate = 1f;
        shield.enabled = false;
    }

    public void UsePower(float r)
    {
        fillRate = r;
        ratio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ratio < 1.0f)
        {
            ratio += fillRate * Time.deltaTime ;
        }

        //bar.fillAmount = ratio;
        bar.rectTransform.localScale = new Vector2(ratio * x, y);

    }

    public bool PowerCheck()
    {
        if (ratio >= 0.95f)
        {
            return true;
        }
        else return false;
    }

    public void SelectGrenade()
    {
        grenade.enabled = true;
        shield.enabled = false;
    }

    public void SelectShield()
    {
        grenade.enabled = false;
        shield.enabled = true;
    }
}
