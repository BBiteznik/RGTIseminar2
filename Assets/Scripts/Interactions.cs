using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{

    public GameObject bomba = null;
    public Button btn = null;
    private float distance = 0;
    private bool enb = false;
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
            Color col = btn.GetComponent<Image>().color;
            col.a = 1;
            btn.GetComponent<Image>().color = col;
            enb = true;
        }
        else if (distance > 1.5f && enb)
        {
            Color col = btn.GetComponent<Image>().color;
            col.a = 0.35f;
            btn.GetComponent<Image>().color = col;
            enb = false;
        }
    }
}
