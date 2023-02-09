using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{
    protected override void Init()
    { 
        base.Init();

        SceneType = Define.Scene.TitleScene;

        //List<GameObject> list = new List<GameObject>();
        //for (int i = 0; i < 5; i++)
            //list.Add(Managers.Resource.Instantiate("UnityChan"));
        //foreach (GameObject obj in list)
            //Managers.Resource.Destroy(obj);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Managers.Scene.LoadScene(Define.Scene.LoadingScene);
        }
        //GameObject Start_Btn = null; 

        //GameObject End_Btn = null;
    }

    public void OnClickStart()
    {
        Managers.Scene.LoadScene(Define.Scene.LoadingScene);
    }

    public void OnClickEnd()
    {
        Util.QuitThisGame();
    }
    
    public override void Clear()
    {
        Debug.Log("TitleScene Clear!");
    }

}
