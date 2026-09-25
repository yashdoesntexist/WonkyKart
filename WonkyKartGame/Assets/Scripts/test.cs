using System;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "test", menuName = "Scriptable Objects/test")]
public class test : ScriptableObject
{
    [SerializeField]
    private GameObject player;
    private async Task LoadScene(GameObject Camera)
    {
        await SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        player.SetActive(true);
        Camera.SetActive(false);
        Scene scene = SceneManager.GetSceneByBuildIndex(1);
        GameObject PlayerCamera = GameObject.Find("Main Camera");
        PlayerCamera.SetActive(true);
    }
    public void StartGame(GameObject mainMenu, GameObject Camera)
    {
        #pragma warning disable
        LoadScene(Camera);
        mainMenu.SetActive(false);
    }
}
