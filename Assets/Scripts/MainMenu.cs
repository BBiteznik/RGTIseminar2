using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject navodila = null;

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DisplayNavodila() {
        Debug.Log("haha0");
        navodila.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
