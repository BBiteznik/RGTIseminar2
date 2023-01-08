using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rgbody = null;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
  
        transform.Translate(-Vector3.forward * dx * this.speed * Time.deltaTime);
        transform.Translate(Vector3.right * dy * this.speed * Time.deltaTime);
    }
}
