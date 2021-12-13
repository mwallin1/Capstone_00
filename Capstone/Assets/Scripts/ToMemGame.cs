using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMemGame : MonoBehaviour
{
    public void goToMemGame()
    {
        StateManager.instance.changeState(State.memGame);
    }
}
