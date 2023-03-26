using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private bool filled;
    private int index;
    private int ID;
    private Image itemImage;

    public void SetIndex(int i)
    {
        index = i;
    }
    private void Start()
    {
        filled = false;
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
}
