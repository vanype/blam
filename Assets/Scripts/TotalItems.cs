using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalItems : MonoBehaviour
{
    [SerializeField]private GameObject[] itemsOBJ;
    [SerializeField]private Sprite[] itemsICO;
    
    public GameObject GetObject(int ID)
    {
        if(ID>=0 && ID < itemsOBJ.Length)
        {
            return itemsOBJ[ID];
        }
        return null;
    }
    /*
    Все айтемы(предметы), их иконки хранятся в массивах, скрипт висит на пустом объекте на сцене
     */
    public Sprite GetSprite(int ID)
    {
        if (ID >= 0 && ID < itemsICO.Length)
        {
            return itemsICO[ID];
        }
        return null;
    }
}
