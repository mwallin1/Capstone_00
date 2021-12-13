using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toMultGame : MonoBehaviour
{
    public void goMult()
    {
        StateManager.instance.changeState(State.multGame);
    }
}
