using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;

    public void StartGame()
    {
        StartCoroutine(StartButton());
    }

    IEnumerator StartButton()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
