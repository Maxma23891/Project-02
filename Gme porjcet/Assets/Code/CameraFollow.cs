using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float CameraSpeed;
    public float YoffSet;

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x, target.position.y + YoffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, CameraSpeed * Time.deltaTime);
    }
}
