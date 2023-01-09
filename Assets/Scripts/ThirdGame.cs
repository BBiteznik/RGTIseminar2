using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;



public class ThirdGame : MonoBehaviour
{
    public TextMeshProUGUI num1 = null;
    public TextMeshProUGUI num2 = null;
    public bool done = false;
    private bool correct = false;
    private string answer = "";
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
        int r1 = Random.Range(1, 10);
        int r2 = Random.Range(1, 10);

        num1.text = r1.ToString(); //h
        num2.text = r2.ToString(); //r

        float res = 1 / 3.0f * (r2 * r2 * r1) * Mathf.PI;

        int r = (int)Mathf.Round(res);

        answer = r.ToString();

        Debug.Log(answer);


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
