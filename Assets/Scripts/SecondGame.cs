using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;

public class SecondGame : MonoBehaviour
{

    public bool done = false;
    private bool correct = false;
    private string input = null;
    public GameObject[] greens = null;
    public GameObject bb = null;
    public GameObject sel = null;
    public Button selectionbtn = null;
    private int prec = 0;
    public Camera cam = null;
    public GameObject player = null;

    public void updateInput(string s)
    {
        input = s;
    }

    public void OnEnable() {

        for (int i = 0; i < greens.Length; i++) {
            
            int num = Random.Range(1,3);
            if (num == 1)
            {
                prec += 10;
                greens[i].SetActive(true);
            }
            else {
                greens[i].SetActive(false);
            }
        }
    }

    public void check()
    {
        if (input == prec.ToString())
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        done = correct;
        if (done)
        {
            player.transform.position = new Vector3(-1.92f, 1.25f, -0.22f);
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
            cam.transform.rotation = Quaternion.Euler(0, 90, 0);
            player.GetComponent<Rigidbody>().useGravity = true;
            cam.GetComponent<PogledMiska>().enabled = true;
            player.GetComponent<PogledMiska>().enabled = true;
            player.GetComponent<PlayerControler>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            sel.SetActive(true);
            selectionbtn.gameObject.SetActive(false);
            bb.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
