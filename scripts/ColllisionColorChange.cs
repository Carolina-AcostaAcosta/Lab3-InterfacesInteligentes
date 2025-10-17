using UnityEngine;

public class CollisionColorChange : MonoBehaviour {
  private Renderer objRenderer;

  void Start() {
    objRenderer = GetComponent<Renderer>();
  }

  void OnCollisionEnter(Collision collision) {
    Debug.Log($"{gameObject.name} colisionó con {collision.gameObject.name}");

    objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
  }
}
