using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventaryManager : MonoBehaviour
{
    [SerializeField] private ScriptableObj[] items;
    [SerializeField] private List<GameObject> icons = new List<GameObject>();
    [SerializeField] private Transform gridLayout;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemClassText;
    [SerializeField] private TextMeshProUGUI itemStateText;
    [SerializeField] private TextMeshProUGUI itemCostText;
    [SerializeField] private Image itemImage;
    [SerializeField] private Image nullImage;
    [SerializeField] private int maxItem = 15;

    private void Start()
    {
        button.onClick.AddListener(AddItem);
    }

    private void AddItem()
    {
        if (icons.Count >= maxItem) return;
        
        ScriptableObj newItem = items[Random.Range(0, items.Length)];
        GameObject itemPrefab = Instantiate(newItem.Prefab, gridLayout);
        icons.Add(itemPrefab);
        ShowInfo(newItem);
        OnPointer onPointer = itemPrefab.AddComponent<OnPointer>();

        if (onPointer != null)
        {
            onPointer.SetManager(this);
            onPointer.SetItem(newItem);
        }
    }
    public void ShowInfo(ScriptableObj newItem)
    {
        itemNameText.text = $"Name: {newItem.Name}";
        itemClassText.text = $"Class: {newItem.Class.ToString()}";
        itemStateText.text = $"State: +{newItem.States}";
        itemCostText.text = $"Cost: {newItem.Cost.ToString()}$";
        itemImage.sprite = newItem.Icon;
    }

    public void ClearInfo()
    {
        itemNameText.text = $"Name:";
        itemClassText.text = $"Class:";
        itemStateText.text = $"State:";
        itemCostText.text = $"Cost: 0$";
        itemImage.sprite = nullImage.sprite;
    }

    
}
