using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    [SerializeField] string iName = default;
    [SerializeField] string description = default;
    [SerializeField] float weight = default;
    [SerializeField] float price = default;

    public string Name => iName;
    public string Description => description;
    public float Weight => weight;
    public float Price => price;
}