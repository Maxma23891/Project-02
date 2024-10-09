using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public string Scene;

    void Update()
    {
        
    }

    public void StartOn()
    {
        SceneManager.LoadScene(Scene);
    }

    public void ExitOn()
    {
        Application.Quit();
    }
}
