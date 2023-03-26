using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    private float HP;
    private Slider hp_Slider;

    private void Start()
    {
        hp_Slider = GameObject.FindGameObjectWithTag("HP Slider").GetComponent<Slider>();
        hp_Slider.value = hp_Slider.maxValue;
    }
    public void HP_Update(float difference)
    {
        HP += difference;
        hp_Slider.value = HP;
    }
}
