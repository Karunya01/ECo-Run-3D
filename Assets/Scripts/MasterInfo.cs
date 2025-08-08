using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    public static int solarPanelCount = 0;
    [SerializeField] GameObject coinDisplay;

    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "Water: " + coinCount + " | Solar Panels: " + solarPanelCount;;
    }
}
