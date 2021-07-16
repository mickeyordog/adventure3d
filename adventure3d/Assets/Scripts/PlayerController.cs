using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float forewardSpeed = 5f;
    public float sidewaysSpeed = 5f;

    private void Awake()
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
        float sidewaysVelocity = Input.GetAxis("Horizontal") * sidewaysSpeed;
        float forewardsVelocity = Input.GetAxis("Vertical") * forewardSpeed;
        rb.velocity = new Vector3(sidewaysVelocity, 0f, forewardsVelocity);
    }
}
