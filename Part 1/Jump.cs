using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private Rigidbody rb;
    // Use this for initialization
    void start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void update () {
        Vector3 vel = rb.velocity;
        vel.x = 5;
        rb.velocity = vel;
        if (Physics.Raycast(transform.position, Vector3.down, GetComponent<BoxCollider>().size.y / 2 + 0.4f))
        {
            Quaternion rot = transform.rotation;
            rot.z = Mathf.Round(rot.z / 90) * 90;
            transform.rotation = rot;
            if (input.GetMouseButtonDown(0)) {
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector2.up * 55000);
            }
        }
        else {
            transform.Rotate(Vector3.back * 5f);
        }
    }
}