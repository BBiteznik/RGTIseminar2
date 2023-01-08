using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rigidbody = null;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
  
        rigidbody.AddForce(Vector3.forward * dy * this.speed);
        rigidbody.AddTorque(-Vector3.forward * dx * this.speed);
    }
}
