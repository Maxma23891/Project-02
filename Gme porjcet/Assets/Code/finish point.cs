using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
