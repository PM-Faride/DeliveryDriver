using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed = 15;
    [SerializeField] private float slowSpeed = 12;
    [SerializeField] private float fastSpeed = 22;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float movementAmount = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(new Vector3(0, movementAmount, 0));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Booster")
        {
            moveSpeed = fastSpeed;
        }
    }
}
