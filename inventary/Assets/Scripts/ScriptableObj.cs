using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "NewItem")]
public class ScriptableObj : ScriptableObject
{
    [field: SerializeField] public Sprite Icon { get; private set; }
    [field: SerializeField] public GameObject Prefab { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Type Class { get; private set; }
    [field: SerializeField] public int States { get; private set; }
    [field: SerializeField] public int Cost { get; private set; }

    public enum Type
    {
        Armor,
        Weapon,
        Food,
        Materials
    }
}
