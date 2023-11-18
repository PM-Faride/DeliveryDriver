using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay;
    [SerializeField] Color32 hasPackageColor = new Color32(36, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!!!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Delivery" && ! hasPackage)
        {
            Debug.Log("Delivery package was picked up!");
            //collision.gameObject.SetActive(false);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }
        else if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package was delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
