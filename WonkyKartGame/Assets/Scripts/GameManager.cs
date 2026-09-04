using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;
    private void StartFade()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        camera.SetActive(false);
        Scene scene = SceneManager.GetSceneByBuildIndex(1);
        GameObject cameras = GameObject.Find("Camera");
        cameras.SetActive(true);
    }
}
