using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> collectedItems;

    public void CollectItem(GameObject Item)
    {
        collectedItems.Add(Item);
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
