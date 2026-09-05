using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;
    private void StartFade()
    {

    }
    private async Task LoadScene()
    {
        await SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        camera.SetActive(false);
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
