using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> collectedItems;
    public bool isMovementDebugging;
    [SerializeField]
    private GameManager manager;

    public void CollectItem(GameObject Item)
    {
        collectedItems.Add(Item);
        manager.UpdateScore(collectedItems.Count);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject collided = other.gameObject;
        if (collided.CompareTag("Food"))
        {
            collided.SetActive(false);
            CollectItem(collided);
        }
    }
}
