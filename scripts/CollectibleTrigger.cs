using UnityEngine;

public class CollectibleTrigger : MonoBehaviour {
  void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player")) {
      Debug.Log($"{other.name} recolectó {gameObject.name}");
      Destroy(gameObject);
    }
  }
}
