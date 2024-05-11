using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject Tab;
    public GameObject CatalagueTab;
    public GameObject InfoTab;


    public void CloseTab()
    {
        Tab.SetActive(false);
    }
    public void OpenTab()
    {
        Tab.SetActive(true);
        InfoTab.SetActive(false);
        CatalagueTab.SetActive(false);
    }
    public void CloseCatalagueTab()
    {
        CatalagueTab.SetActive(false);
    }
    public void OpenCatalagueTab()
    {
        CatalagueTab.SetActive(true);
        Tab.SetActive(false);
        InfoTab.SetActive(false);

    }
    public void CloseInfoTab()
    {
        InfoTab.SetActive(false);
    }
    public void OpenInfoTab()
    {
        InfoTab.SetActive(true);
        CatalagueTab.SetActive(false);
        Tab.SetActive(false);

    }
}
