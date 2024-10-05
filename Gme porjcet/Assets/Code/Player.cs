using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [Header("MovementSetting")]
    [Range(0f, 10)]
    public float Movespeed;
    [Range(0f, 10)]
    public float JumpForce;
    private float InputHorizontal;
    public bool FacingRight;
    [Header("GroundCheck Setting")]
    public Transform GroundCheck;
    public LayerMask GroundMask;
    public float GroundRadius = 0.2f;
    private bool IsGround;


    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        rb.GetComponent<Rigidbody2D>();
        InputHorizontal = Input.GetAxisRaw("Horizontal");
        IsGround = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, GroundMask);
        if (Input.GetButtonDown("Jump") && IsGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, JumpForce);
        }
        Filp();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(InputHorizontal * Movespeed, rb.linearVelocity.y);
    }

    void Filp()
    {
        if (FacingRight && InputHorizontal < 0f || !FacingRight && InputHorizontal > 0f)
        {
            FacingRight = !FacingRight;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(GroundCheck.position, new Vector3(GroundRadius * 7.5f, GroundRadius * 1f));

    }
}