using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;

public class Game : MonoBehaviour
{

    public GameObject nal3 = null;
    public GameObject nal1 = null;
    public GameObject nal2 = null;
    public float tr = 5;
    public TextMeshProUGUI textdisp = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tr -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(tr / 60);
        float seconds = Mathf.FloorToInt(tr % 60);

        string text = "00" + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        textdisp.text = text;
        //Debug.Log(text);

        bool d1 = nal1.GetComponent<FirstGame>().done;
        bool d3 = nal3.GetComponent<ThirdGame>().done;
        bool d2 = nal2.GetComponent<SecondGame>().done;

        if (d1 && d2 && d3) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (tr <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
