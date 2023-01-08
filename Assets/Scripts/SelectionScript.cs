using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    public GameObject Nivo1 = null;
    public GameObject Nivo2 = null;
    public GameObject Nivo3 = null;
    // Start is called before the first frame update


    public void One() {
        Nivo1.SetActive(true);
        Nivo2.SetActive(false);
        Nivo3.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void Two() {
        Nivo1.SetActive(false);
        Nivo2.SetActive(true);
        Nivo3.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void Three() {
        Nivo1.SetActive(false);
        Nivo2.SetActive(false);
        Nivo3.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
