using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject goal;

    public void Clicked()
    {
        gameObject.SetActive(false);
        goal.SetActive(true);
    }
}
