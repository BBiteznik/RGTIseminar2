using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGui : MonoBehaviour
{
    public Camera cam = null;
    public GameObject player = null;
    public GameObject bbgui = null;
    public GameObject selgui = null;
    // Start is called before the first frame update
    public void BackButton() {
        player.transform.position = new Vector3(-1.92f, 1.25f, -0.22f);
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        cam.transform.rotation = Quaternion.Euler(0, 90, 0);
        player.GetComponent<Rigidbody>().useGravity = true;
        cam.GetComponent<PogledMiska>().enabled = true;
        player.GetComponent<PogledMiska>().enabled = true;
        player.GetComponent<PlayerControler>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        selgui.SetActive(true);
        bbgui.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
