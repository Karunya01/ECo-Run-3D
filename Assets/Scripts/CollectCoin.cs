using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CollectCoin : MonoBehaviour
{
    //[SerializeField] AudioSource coinFX;
    [SerializeField] AudioSource collectFX;
    [SerializeField] private bool isSolarPanel;
    void OnTriggerEnter(Collider other)
    {
        /*coinFX.Play();
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(false);*/
        if (collectFX != null)
            collectFX.Play();

        if (isSolarPanel)
        {
            MasterInfo.solarPanelCount += 1;
        }
        else
        {
            MasterInfo.coinCount += 1;
        }

        gameObject.SetActive(false);
    }
}
