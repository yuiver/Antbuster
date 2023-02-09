using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpGuage : MonoBehaviour
{
    private Image guageFront = default;

    public int maxHp = default;
    public int currentHp = default;
    public float guageAmount = default;

    // Start is called before the first frame update
    void Start()
    {
        guageFront = gameObject.GetComponentMust<Image>("GuageFront");
    }

    // Update is called once per frame
    void Update()
    {
        guageAmount = currentHp / (float)maxHp;
        guageFront.fillAmount = guageAmount; //생략가능 그냥 Amount로 안나누고 구현가능

    }
}
