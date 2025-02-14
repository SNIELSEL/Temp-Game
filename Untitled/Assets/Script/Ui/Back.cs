using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public PlayerControlls menuControlls;
    private InputAction back;

    public GameObject settingsMenu;
    public GameObject creditsMenu;
    public GameObject startMenu;
    public GameObject mapSelect;
    public Button selectButton;

    public PlayFabManager playFabManager;

    public void Awake()
    {
        menuControlls = new PlayerControlls();
    }
    public void Start()
    {
        back = menuControlls.MenuController.Back;
        back.Enable();
        back.performed += BackToMenu;

        void BackToMenu(InputAction.CallbackContext context)
        {
            if (!playFabManager.inNamingmenu)
            {
                settingsMenu.SetActive(false);
                creditsMenu.SetActive(false);
                startMenu.SetActive(true);
                mapSelect.SetActive(false);
                selectButton.Select();
            }
        }
    }
}
