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
        HP = hp_Slider.value;
    }
    public void HP_Update(float difference)
    {
        
        HP += difference;
        if (HP < 0)
        {
            HP = 0;
        }
        if(HP> hp_Slider.maxValue)
        {
            HP = hp_Slider.maxValue;
        }
        hp_Slider.value = HP;
    }
    
}
