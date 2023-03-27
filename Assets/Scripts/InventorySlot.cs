using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private bool filled;
    private int index;
    private int ID = -1;
    

    public void SetIndex(int i)
    {
        index = i;
    }
    
    public bool GetFilledValue()
    {
        return filled;
    }
    public void Fill(int _ID, Sprite sprite)
    {
        ID = _ID;
        filled = true;
        GetComponent<Image>().sprite = sprite;
    }
    public void OnClick()
    {
        if (filled)
        {
            //при нажатии обращается к общему списку всех айтемов, и их функций
            GameObject player = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().GetPlayerObject();
            GameObject.FindGameObjectWithTag("Total Items").GetComponent<TotalItems>().TryToDoAction(ID, player,this);
           
            
        }
    }
    public void DeleteItem()
    {
        ID = -1;
        filled = false;
        GetComponent<Image>().sprite = default;
    }
}
