using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGui : MonoBehaviour
{
    public GameObject bbgui = null;
    public GameObject selgui = null;
    // Start is called before the first frame update
    public void BackButton() {
        selgui.SetActive(true);
        bbgui.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
