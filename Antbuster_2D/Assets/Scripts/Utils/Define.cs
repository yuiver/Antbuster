using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Scene
    { 
        Unknown,
        TitleScene,
        LoadingScene,
        GamePlayScene,
        GameOverScene,
    }

    public enum Sound
    { 
        Bgm,
        Effect,
        MaxCount,
    }
    public enum UIEvent
    {
        Click,
        Drag,
    }

    public enum MouseEvent
    { 
        Press,
        Click,
    } 
    public enum CameraMode
    { 
        QuaterView,
    }

    public const string OBJ_POOL_INST_NAME = "@Pool";
    public const string ROOT_INST_NAME = "{0}_Root";
    public const string ANT_PREFAB_PATH = "ant";
    public const string BULLET_PREFAB_PATH = "bullet";
}
