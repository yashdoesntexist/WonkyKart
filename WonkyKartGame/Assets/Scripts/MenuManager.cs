using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private GameObject mainMenu;

    public void Clicked()
    {
        mainMenu.SetActive(false);
        Camera.SetActive(false);
        GameManager.Instance.StartGame();
    }

//    private async Task LoadScene()
//    {
//        await SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
//        GameObject player = GameManager.GetPlayer();
//        player.SetActive(true);
//        Camera.SetActive(false);
//        Scene scene = SceneManager.GetSceneByBuildIndex(1);
//        GameObject PlayerCamera = GameObject.Find("Main Camera");
//        PlayerCamera.SetActive(true);
//    }
//    public void StartGame()
//    {
//#pragma warning disable
//        LoadScene();
//        mainMenu.SetActive(false);
//    }
}
