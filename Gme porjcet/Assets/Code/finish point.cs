using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishpoint : MonoBehaviour
{
    [SerializeField]bool goNextLevel;
    [SerializeField] string LevelName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                SceneSetting.instance.NextLevel();
            }
            else
            {
                SceneSetting.instance.SceneLoad(LevelName);
            }
        }
    }
}
