using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Vector2 startpos;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        startpos = transform.position;
    }
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Obsticle"))
        {
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(Delaytime(1f));
    }

   IEnumerator Delaytime(float Duration)
    {
        rb.simulated = false;
        transform.localScale = new Vector3 (0f, 0f, 0f);
        transform.position = startpos;
        yield return new WaitForSeconds(Duration);
        transform.localScale = new Vector3(1f, 1f, 1f);
        rb.simulated = true;
    }


}
