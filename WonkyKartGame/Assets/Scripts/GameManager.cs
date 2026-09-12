using System;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Camera;
    public GameObject collectedItems;
    private int ItemsInLevel;
    [SerializeField]
    private GameObject player;
    private void StartFade()
    {
        
    }
    public void UpdateScore(int ItemsCollected)
    {
        TextMeshProUGUI wsg = collectedItems.GetComponent<TextMeshProUGUI>();
        wsg.text = ItemsCollected + "/" + ItemsInLevel + " items left";
    }
    private async Task LoadScene()
    {
        
        await SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        player.SetActive(true);
        Camera.SetActive(false);
        Scene scene = SceneManager.GetSceneByBuildIndex(1);
        GameObject PlayerCamera = GameObject.Find("Main Camera");
        PlayerCamera.SetActive(true);
    }
    public void StartGame()
    {
        #pragma warning disable
        LoadScene();
    }
}
