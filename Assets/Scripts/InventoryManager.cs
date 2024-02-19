using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status {  get; private set; }

    private Dictionary<string, int> items;

    public void Startup()
    {
        Debug.Log("Inventory manager starting...");

        items = new Dictionary<string, int>();

        status = ManagerStatus.Started;
    }

    private void DisplayItems()
    {
        string itemDisplay = "Items: ";
        foreach (KeyValuePair<string, int> item in items)
        {
            itemDisplay += item.Key + "(" + item.Value + ") ";
        }
        Debug.Log(itemDisplay);
    }

    public void AddItem(string name)
    {
        if (items.ContainsKey(name)) items[name] += 1;
        else items[name] = 1;

        DisplayItems();
    }

    public List<string> GetItemList()
    {
        return new List<string>(items.Keys);
    }

    public int GetItemCount(string name)
    {
        if (items.ContainsKey(name)) return items[name];
        return 0;
    }
}
