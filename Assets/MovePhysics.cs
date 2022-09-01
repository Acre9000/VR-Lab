using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePhysics : MonoBehaviour
{

    public Transform target;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = (target.position - transform.position) / Time.fixedDeltaTime;

        Quaternion rotDiff = target.rotation * Quaternion.Inverse(transform.rotation);
        rotDiff.ToAngleAxis(out float angleDegree, out Vector3 rotAxis);

        Vector3 rotDiffDegree = angleDegree * rotAxis;

        rb.angularVelocity = (rotDiffDegree * Mathf.Deg2Rad / Time.fixedDeltaTime);
    }


}
