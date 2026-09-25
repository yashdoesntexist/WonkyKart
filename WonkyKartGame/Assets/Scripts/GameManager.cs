using System;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject collectedItems;
    [SerializeField]
    private GameObject PlayerCamera;
    private int ItemsInLevel;
    [SerializeField]
    private GameObject player;
    private void OnEnable()
    {
    }
    private void StartFade()
    {
        
    }
    public GameObject GetPlayer()
    {
        return player;
    }
    public void UpdateScore(int ItemsCollected)
    {
        TextMeshProUGUI wsg = collectedItems.GetComponent<TextMeshProUGUI>();
        wsg.text = ItemsCollected + "/" + ItemsInLevel + " items left";
    }
    private async Task LoadScene()
    {
        await SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        print(player);
        player.SetActive(true);
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
