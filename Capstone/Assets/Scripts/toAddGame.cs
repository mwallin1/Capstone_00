using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAddGame : MonoBehaviour
{
    public void goAdd()
    {
        StateManager.instance.changeState(State.addGame);
    }
}
