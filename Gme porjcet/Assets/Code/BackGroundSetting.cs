using UnityEngine;

public class BackGroundSetting : MonoBehaviour
{
    private float startPos, length;
    public GameObject Cam;
    public float paralaxEffect;
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }


    void FixedUpdate()
    {
        float Distance = Cam.transform.position.x * paralaxEffect; // 0 = cam move || 1 = won't move || 0.5 = half
        float Movement = Cam.transform.position.x * (1 - paralaxEffect);

        transform.position = new Vector3(startPos + Distance, transform.position.y, transform.position.z);

        if (Movement > startPos + length)
        {
            startPos += length;
        }
        else if (Movement < startPos - length)
        {
            startPos -= length;
        }

    }
}
