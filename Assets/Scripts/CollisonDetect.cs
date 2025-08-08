using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CollisonDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisonFX;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());

    }
    IEnumerator CollisionEnd()
    {
        collisonFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
