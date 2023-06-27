using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType
    {
        Exp,
        Level,
        Kill,
        Time,
        hp
    }

    public InfoType type;

    Text myText;
    Slider mySlider;

    private void Awake()
    {
        myText = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
    }

    private void LateUpdate()
    {
        switch (type)
        {
            case InfoType.Exp:
                float curExp = GameManager.instance.exp;
                float maxExp = GameManager.instance.nextExp[GameManager.instance.level];
                mySlider.value = curExp / maxExp;
                break;
            case InfoType.Level:
                //myText.text = "Level : " + GameManager.instance.player.level;
                break;
            case InfoType.Kill:
                //myText.text = "Kill : " + GameManager.instance.killCount;
                break;
            case InfoType.Time:
                //yText.text = "Time : " + GameManager.instance.playTime.ToString("N2");
                break;
            case InfoType.hp:
                //mySlider.value = GameManager.instance.player.hp / GameManager.instance.player.maxHp;
                break;
        }   
    }
}
