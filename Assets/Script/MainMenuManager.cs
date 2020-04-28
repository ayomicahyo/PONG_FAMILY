using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Main;
    public GameObject StageSelect;
    public GameObject Guide;
    public GameObject DuelinOnePhone;
    public GameObject DuelinDualPhone;

    public void Ready()
    {
        if (Main.active == true)
        {
            StageSelect.SetActive(true);
            Main.SetActive(false);
        }
    }

    public void OnePhone()
    {
        if(DuelinOnePhone.active == false)
        {
            DuelinOnePhone.SetActive(true);
            StageSelect.SetActive(false);
            Main.SetActive(false);
        }
    }

    public void DualPhone()
    {
        if (DuelinDualPhone.active == false)
        {
            DuelinDualPhone.SetActive(true);
            StageSelect.SetActive(false);
            Main.SetActive(false);
        }
    }

    public void Exit()
    {
        if(DuelinOnePhone.active == true)
        {
            DuelinOnePhone.SetActive(false);
            Main.SetActive(true);
        }
        else if (DuelinDualPhone.active == true)
        {
            DuelinDualPhone.SetActive(false);
            Main.SetActive(true);
        }

        if(StageSelect.active == true)
        {
            StageSelect.SetActive(false);
            Main.SetActive(true);
        }

        if(Guide.active == true)
        {
            Guide.SetActive(false);
            Main.SetActive(true);
        }
    }

}
