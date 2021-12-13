using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToAboutScreen : MonoBehaviour
{
    public void goToAbout()
    {
        StateManager.instance.changeState(State.aboutScreen);
    }
}
