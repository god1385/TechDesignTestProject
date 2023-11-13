using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
