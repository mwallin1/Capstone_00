using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDivGame : MonoBehaviour
{
    public void goDiv()
    {
        StateManager.instance.changeState(State.divGame);
    }
}
