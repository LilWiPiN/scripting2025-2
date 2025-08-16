using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Scenes : MonoBehaviour
{
    public void Play()
    {
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    public void Instructions()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void Credits()
    {
        MMSceneLoadingManager.LoadScene("Creditos");
    }

    public void MainMenu()
    {
        MMSceneLoadingManager.LoadScene("MenuPrincipal");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
