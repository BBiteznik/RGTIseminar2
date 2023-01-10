using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    public GameObject player = null;
    public Camera cam = null;
    public GameObject Nivo1 = null;
    public GameObject Nivo2 = null;
    public GameObject Nivo3 = null;
    // Start is called before the first frame update


    public void One() {

        player.transform.position = new Vector3(-6.99f, -0.84f, -3.88F);
        player.transform.rotation = Quaternion.Euler(0, -90, 0);

        Nivo1.SetActive(true);
        Nivo2.SetActive(false);
        Nivo3.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void Two() {
        player.transform.position = new Vector3(-6.74f, -0.798f, 18.18F);
        player.transform.rotation = Quaternion.Euler(0, -90, 0);
        Nivo1.SetActive(false);
        Nivo2.SetActive(true);
        Nivo3.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void Three() {
        player.transform.position = new Vector3(-7.17f, -0.93f, 51.29F);
        player.transform.rotation = Quaternion.Euler(0, -90, 0);
        Nivo1.SetActive(false);
        Nivo2.SetActive(false);
        Nivo3.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
