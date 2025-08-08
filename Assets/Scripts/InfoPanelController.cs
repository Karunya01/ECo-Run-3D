using UnityEngine;
using System.Collections;
public class InfoPanelController : MonoBehaviour
{
    public GameObject instructionPanel;
    public float delayBeforeShow = 4f;  // Wait before showing
    public float displayTime = 3f;      // How long to keep panel visible

    void Start()
    {
        instructionPanel.SetActive(false);
        StartCoroutine(ShowThenHide());
    }

    IEnumerator ShowThenHide()
    {
        yield return new WaitForSeconds(delayBeforeShow); // Wait first
        instructionPanel.SetActive(true);
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(displayTime); // Wait while paused
        instructionPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
