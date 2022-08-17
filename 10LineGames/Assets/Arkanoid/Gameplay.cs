using UnityEngine;
public class Gameplay : MonoBehaviour {
    [SerializeField] Rigidbody2D playerRb;
    float yMov;
    void Update() { yMov = Input.GetAxisRaw("Vertical"); }
    private void FixedUpdate() { playerRb.velocity = new Vector2(playerRb.velocity.x, yMov * 35f * Time.fixedDeltaTime * 10); }
    [SerializeField] Rigidbody2D ballRb;
    void Start() { ballRb.velocity = new Vector2(1, (Random.Range(0, 2) == 0 ? -1 : 1)) * 6f; }
    void OnCollisionEnter2D(Collision2D col) { if (col.gameObject.CompareTag("Paddle")) ballRb.velocity *= 1.1f; }
}