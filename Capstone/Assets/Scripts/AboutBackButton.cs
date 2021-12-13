using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutBackButton : MonoBehaviour
{
    public void backToMenu()
    {
        StateManager.instance.changeState(State.titleScreen);
    }
}
