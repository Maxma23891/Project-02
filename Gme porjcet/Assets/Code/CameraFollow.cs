using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float CameraSpeed;
    public float YOffset;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + YOffset, -10f);  //YOffset is set the Y
        transform.position = Vector3.Slerp(transform.position, newPos, CameraSpeed * Time.deltaTime); // Slerp Make it look smoo
    }
}
