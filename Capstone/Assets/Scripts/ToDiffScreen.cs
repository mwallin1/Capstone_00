using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDiffScreen : MonoBehaviour
{
    public void goDiff()
    {
        StateManager.instance.changeState(State.diffScreen);
    }
}
