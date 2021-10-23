using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class VehicleMovement : MonoBehaviour
{
    //public List<AxleInfo> axleInfos;
    //public float maxMotorTorque;
    //public float maxSteeringAngle;

    //public void ApplyLocalPositionToVisuals(WheelCollider collider)
    //{
    //    if (collider.transform.childCount == 0)
    //    {
    //        return;
    //    }

    //    Transform visualWheel = collider.transform.GetChild(0);

    //    Vector3 position;
    //    Quaternion rotation;
    //    collider.GetWorldPose(out position, out rotation);

    //    visualWheel.transform.position = position;
    //    visualWheel.transform.rotation = rotation;
    //}

    //public void FixedUpdate()
    //{
    //    float motor = maxMotorTorque * Input.GetAxisRaw("Vertical");
    //    float steering = maxSteeringAngle * Input.GetAxisRaw("Horizontal");

    //    foreach (AxleInfo axleInfo in axleInfos)
    //    {
    //        if (axleInfo.steering)
    //        {
    //            axleInfo.leftWheel.steerAngle = steering;
    //            axleInfo.rightWheel.steerAngle = steering;
    //        }
    //        if (axleInfo.motor)
    //        {
    //            axleInfo.leftWheel.motorTorque = motor;
    //            axleInfo.rightWheel.motorTorque = motor;
    //        }
    //        //ApplyLocalPositionToVisuals(axleInfo.leftWheel);
    //        //ApplyLocalPositionToVisuals(axleInfo.rightWheel);
    //    }
    //}

    public float forwardSpeed = 5f;
    public float turnSpeed = 5f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * Input.GetAxis("Vertical") * forwardSpeed;
        rb.AddRelativeTorque(transform.up * Input.GetAxis("Horizontal") * turnSpeed);
    }
}


[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}