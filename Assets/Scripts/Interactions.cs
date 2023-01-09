using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{

    public GameObject bomba = null;
    public GameObject bbgui = null;
    public Button btn = null;
    private float distance = 0;
    public bool enb = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(bomba.transform.position, this.transform.position);
        if (distance <= 1.5f && !enb)
        {
            enb = true;
        }
        else if (distance > 1.5f && enb)
        {
            enb = false;
        }

        if (enb && Input.GetKeyDown(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            bbgui.SetActive(true);
        }
    }
}
