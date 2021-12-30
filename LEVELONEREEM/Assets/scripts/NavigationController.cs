using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{

    public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }
    public void GoTCharacterDescriptionScene()
    {
        Application.LoadLevel(1);
    }
    public void GoToHiddenObjectsScene()
    {
        Application.LoadLevel(2);
    }
    public void GoToEvilQueenScene()
    {
        Application.LoadLevel(3);
    }
    public void GoToScene4()
    {
        Application.LoadLevel(4);
    }
    public void GoToScene5()
    {
        Application.LoadLevel(5);
    }
    public void GoToCutScene()
    {
        Application.LoadLevel(6);

    }

    public void GoToLastScene()
    {
        Application.LoadLevel(7);

    }

    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
