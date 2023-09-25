using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTowerMenu : MonoBehaviour
{
    [SerializeField] private GameObject TowerMenu;

    public void OpenTowerMenuOnClk()
    {
        if (TowerMenu != null)
        {
            if (TowerMenu.activeSelf == true)
            {
                TowerMenu.SetActive(false);
            }
            else
            {
                TowerMenu.SetActive(true);
            }
        }
    }
}