using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneState_Battle : SceneState
{
    public SceneState_Battle(SceneManager _sceneManager) : base(_sceneManager, eSCENE_STATE.BATTLE)
    {

    }

    public override void Enter(FsmMsg _msg)
    {
        base.Enter(_msg);

        Debug.Log("enter battle scene");
    }
}