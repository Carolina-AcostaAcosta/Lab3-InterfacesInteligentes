using UnityEngine;

public class ForceLauncher : MonoBehaviour {
  public float launchForce = 500f;
  private Rigidbody rb;
	
	void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.X)) {
	  	rb.AddForce(transform.forward * launchForce);
    }
  }
}
