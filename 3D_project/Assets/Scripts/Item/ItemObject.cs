using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}
public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemDate date;

    public string GetInteractPrompt()
    {
        string str = $"{date.disPlayName}\n{date.description}";
        return str;
    }
    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemDate = date;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject);
    }
}
