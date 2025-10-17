using UnityEngine;

public class PlayerMovement : MonoBehaviour {
  public float speed = 5f;
  private Rigidbody rb;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    float moveX = Input.GetAxis("Horizontal");
    float moveZ = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(moveX, 0f, moveZ) * speed;
    rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
  }
}
