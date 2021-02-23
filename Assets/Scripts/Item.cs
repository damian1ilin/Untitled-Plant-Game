using UnityEngine;

[CreateAssetMenu(menuName = "Item/Itemholder")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        PLANT
    }

    public string m_Name;
    public ItemType m_ItemType;
    public Sprite m_Icon;
    public GameObject m_Prefab;
}
