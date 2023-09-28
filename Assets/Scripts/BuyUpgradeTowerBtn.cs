using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUpgradeTowerBtn : MonoBehaviour
{
    public static string CurrentPlatformName;

    private GameObject CurrentPlatform;

    public void BuyUpgradeBtnOnClk()
    {
        var ButtonText = this.transform.GetChild(0).gameObject.GetComponent<TMPro.TextMeshProUGUI>();

        CurrentPlatform = GameObject.FindWithTag(CurrentPlatformName);
        GameObject ArcherTowerLvl1 = CurrentPlatform.transform.GetChild(0).gameObject;
        GameObject ArcherTowerLvl2 = CurrentPlatform.transform.GetChild(1).gameObject;

        if (ArcherTowerLvl1 != null && ArcherTowerLvl2 != null)
        {
            if (!ArcherTowerLvl1.activeSelf && !ArcherTowerLvl2.activeSelf)
            {
                ArcherTowerLvl1.SetActive(true);
                ButtonText.SetText("Upgrade Tower");
            }
            else if (ArcherTowerLvl1.activeSelf && !ArcherTowerLvl2.activeSelf)
            {
                ArcherTowerLvl1.SetActive(false);
                ArcherTowerLvl2.SetActive(true);
                ButtonText.SetText("Max Upgrades");
            }
            
        }
        Debug.Log(CurrentPlatform);
    }
}
