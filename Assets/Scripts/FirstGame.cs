using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // The namespace for the UI stuff.
using TMPro;

public class Naloga1
{


    private string[] vprasanja = {"Enacbe oznaci z zeleno, neenacbe pa z rdeco barvo.",
                    "Kateri vlomki so enaki vrednosti 3?",
                    "Oznaci veckratnike stevila 7."};

    private static string[] odg1 = { "2/x>1", "2/x=1", "a/3>=8", "3/5xs=-0,8", "x/2<3", "3x=8", "r/3=5", "8-y<=3,9" };
    private static bool[] prav1 = { false, true, false, true, false, true, true, false };
    private static string[] odg2 = { "9/3", "3/1", "16/3", "27/8", "27/9", "12/5", "12/4", "99/33" };
    private static bool[] prav2 = { true, true, false, false, true, false, true, true };
    private static string[] odg3 = { "7", "22", "35", "17", "21", "25", "27", "14" };
    private static bool[] prav3 = { true, false, true, false, true, false, false, true };

    private string[][] odg = { odg1, odg2, odg3 };
    private bool[][] prav = { prav1, prav1, prav3 };

    public string vprasanje;
    public string[] odgovori;

    public bool[] pravilnost;

    public Naloga1()
    {
        int i = Random.Range(0, 3);

        this.vprasanje = vprasanja[i];

        this.odgovori = odg[i];

        this.pravilnost = prav[i];
    }
}


public class FirstGame : MonoBehaviour
{

    public bool done = false;
    public Sprite red = null;
    public Sprite green = null;
    public TextMeshProUGUI main = null;
    public TextMeshProUGUI[] textBoxArray = null;
    public Button[] btnArray = null;
    public Button selectionbtn = null;
    public GameObject bb = null;
    public GameObject sel = null;
    public bool[] given = null;
    public Camera cam = null;
    public GameObject player = null;
    Naloga1 n1 = null;

    public void ButtonSet(int odgovor) {
        given[odgovor] = !given[odgovor];
        if (given[odgovor] == true)
        {
            btnArray[odgovor].image.sprite = green;
        }
        else {
            btnArray[odgovor].image.sprite = red;
        }
        Debug.Log("set");
    }

    void OnEnable()
    {
        given = new bool[8];
        n1 = new Naloga1();
        main.text = n1.vprasanje;
        for (int i = 0; i < n1.odgovori.Length; i++)
        {
            textBoxArray[i].text = n1.odgovori[i];
        }

        for (int i = 0; i < n1.odgovori.Length; i++)
        {
            btnArray[i].image.sprite = red;
        }
    }
    bool check() {
        for (int i = 0; i < n1.odgovori.Length; i++)
        {
            if (given[i] != n1.pravilnost[i]) {
                return false;
            }
        }
        Debug.Log("true");
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        done = check();
        if (done) {
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
