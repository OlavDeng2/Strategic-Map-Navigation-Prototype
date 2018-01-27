using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

[RequireComponent(typeof(Canvas))]
public class MenuControl : MonoBehaviour
{
    private MenuPanel[] menuPanels;

    void Awake()
    {
        // Find all menu panels (including disabled ones)
        menuPanels = GetComponentsInChildren<MenuPanel>(true);

        ShowFirstPanel();
    }

    public void ShowFirstPanel()
    {
        // Disable all panels
        foreach (MenuPanel menuPanel in menuPanels)
        {
            menuPanel.gameObject.SetActive(false);
        }

        // Activate the first one
        menuPanels[0].gameObject.SetActive(true);
    }

    public void ShowPanel(MenuPanel menuPanel)
    {
        // Loop trough all panels
        foreach (MenuPanel _menuPanel in menuPanels)
        {
            // Set it active it equals the given panel
            _menuPanel.gameObject.SetActive(menuPanel.Equals(_menuPanel));
        }
    }

    public void ShowPopupPanel(MenuPanel menuPanel)
    {
        menuPanel.gameObject.SetActive(true);
    }

    public void HidePanel(MenuPanel menuPanel)
    {
        menuPanel.gameObject.SetActive(false);
    }
}