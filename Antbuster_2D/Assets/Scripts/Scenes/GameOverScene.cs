using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : BaseScene
{
    protected override void Init()
    { 
        base.Init();

        SceneType = Define.Scene.GameOverScene;

        //List<GameObject> list = new List<GameObject>();
        //for (int i = 0; i < 5; i++)
            //list.Add(Managers.Resource.Instantiate("UnityChan"));
        //foreach (GameObject obj in list)
            //Managers.Resource.Destroy(obj);
    }

    private void Update()
    {

    }

    public override void Clear()
    {
        Debug.Log("TitleScene Clear!");
    }

}
