using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkim : MonoBehaviour
{
    public float moveForce = 10.0f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -40)
        {
            Time.timeScale = 0;
        }
    }

    void FixedUpdate()
    {
        MovePumpkim();
    }

    void MovePumpkim()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(h * moveForce,0f,v * moveForce));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Golem" || other.tag == "Gate")
        {
            Time.timeScale = 0;
        }
    }
}
