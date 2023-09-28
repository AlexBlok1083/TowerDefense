using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerMenu : MonoBehaviour
{
    [SerializeField] private GameObject TowerMenuUI;
    [SerializeField] private GameObject Button;
    [SerializeField] private int Xfix;
    [SerializeField] private int Yfix;

    public void OpenTowerMenuOnClk()
    {
        if (TowerMenuUI != null)
        {
            if (TowerMenuUI.activeSelf == true)
            {
                TowerMenuUI.SetActive(false);
            }
            else
            {
                //show the menu
                TowerMenuUI.SetActive(true);
                //move the menu next to the platform button
                Vector2 buttonPos = (Button.transform.position);
                TowerMenuUI.transform.position = new Vector2(buttonPos.x + Xfix, buttonPos.y + Yfix);

                //change a value to see which button is clicked so that on that button a tower can be set active.
                BuyUpgradeTowerBtn.CurrentPlatformName = EventSystem.current.currentSelectedGameObject.tag;
            }
        }
    }
}