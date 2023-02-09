using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : BaseScene
{
    private float parameter = 0f;



    IEnumerator updateTimer()
    {
        GameObject guage_Bar = Util.FindChild(GameObject.Find("Game_Objs"), "Loading_Guage_Bar", true);
        Image guage_Bar_img = guage_Bar.GetComponentMust<Image>();
        while (parameter<1)
        {
            guage_Bar_img.fillAmount = parameter;
            // { 시간이 1초씩 흘러가는 로직
            yield return new WaitForSeconds(1.0f);
            // } 시간이 1초씩 흘러가는 로직
            if (parameter < 1.0f)
            {
                parameter += 0.0001f;
            }
            else
            {
                Managers.Scene.LoadScene(Define.Scene.GamePlayScene);
            }
        }
    }

    protected override void Init()
    { 
        base.Init();

        SceneType = Define.Scene.LoadingScene;



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
            Managers.Scene.LoadScene(Define.Scene.GamePlayScene);
        }
        StartCoroutine("updateTimer");
    }

    public override void Clear()
    {
        Debug.Log("LoadingScene Clear!");
    }

}
