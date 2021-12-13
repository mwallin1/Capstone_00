using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSubGame : MonoBehaviour
{
    public void goSub()
    {
        StateManager.instance.changeState(State.subGame);
    }
}
