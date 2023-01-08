using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;

public class Game : MonoBehaviour
{

    public GameObject nal1 = null;
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

        if (nal1.GetComponent<FirstGame>().done) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (tr <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
