using UnityEngine;

public class TotalItems : MonoBehaviour
{
    [SerializeField] private GameObject[] itemsOBJ;
    [SerializeField] private Sprite[] itemsICO;
    public GameObject GetObject(int ID)
    {
        if(ID>=0 && ID < itemsOBJ.Length)
        {
            return itemsOBJ[ID];
        }
        return null;
    }
    public Sprite GetSprite(int ID)
    {
        if (ID >= 0 && ID < itemsICO.Length)
        {
            return itemsICO[ID];
        }
        return null;
    }
}
