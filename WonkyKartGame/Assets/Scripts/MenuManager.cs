using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void Clicked()
    {
        gameObject.SetActive(false);
    }
}
