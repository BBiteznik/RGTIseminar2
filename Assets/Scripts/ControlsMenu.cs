using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public GameObject main = null;

    public void BackMain() {
        main.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
