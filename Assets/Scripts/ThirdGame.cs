using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;




public class ThirdGame : MonoBehaviour
{
    public bool done = false;
    private bool correct = false;
    private string answer = "4218";
    private string input = null;
    public GameObject bb = null;
    public GameObject sel = null;
    public Button selectionbtn = null;
    // Start is called before the first frame update

    public void updateInput(string s) {
        input = s;
    }

    public void check() {
        Debug.Log("xd");
        if (input == answer) {
            correct = true;
        }
        else {
            correct = false;
        }
    }

    void OnEnable() { 
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        done = correct;
        if (done)
        {
            Cursor.lockState = CursorLockMode.Locked;
            sel.SetActive(true);
            selectionbtn.gameObject.SetActive(false);
            bb.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
