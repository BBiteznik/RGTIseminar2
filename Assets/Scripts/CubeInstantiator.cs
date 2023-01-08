using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    public GameObject cube;
    public Vector3 position;
    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cube, position, Quaternion.identity);
        }
    }
}
