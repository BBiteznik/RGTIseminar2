using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{

    public GameObject bomba = null;
    public GameObject bbgui = null;
    public Camera camera = null;
    public GameObject selectionView = null;
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

        if (Input.GetKeyDown(KeyCode.F))
        {
            
            Cursor.lockState = CursorLockMode.None;
            bbgui.SetActive(true);
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            camera.GetComponent<PogledMiska>().enabled = false;
            this.gameObject.GetComponent<PogledMiska>().enabled = false;
            this.gameObject.GetComponent<PlayerControler>().enabled = false;
            this.gameObject.transform.position = selectionView.transform.position - new Vector3(0, 0.33f,0);
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            this.gameObject.transform.rotation = Quaternion.Euler(0,0,0);
            camera.transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
