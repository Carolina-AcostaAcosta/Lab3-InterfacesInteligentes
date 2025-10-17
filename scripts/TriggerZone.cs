using UnityEngine;

public class TriggerZone : MonoBehaviour {
  public enum TriggerType { ColorChange, Damage }
  public TriggerType triggerType;

  public Color enterColor = Color.orange;
  private Color originalColor;
  public float damageAmount = 10f;

  void OnTriggerEnter(Collider other) {
  	if (other.CompareTag("Player")){
      switch (triggerType) {
        case TriggerType.ColorChange:
          Renderer rend = other.GetComponent<Renderer>();
          if (rend != null) {
            originalColor = rend.material.color;
            rend.material.color = enterColor;
          }
          break;
        case TriggerType.Damage:
          PlayerStats stats = other.GetComponent<PlayerStats>();
          if (stats != null) {
            stats.damage += damageAmount;
            Debug.Log($"{other.name} recibió daño. Total: {stats.damage}");
          }
          break;
      }
    }
  }

  void OnTriggerExit(Collider other) {
    if (other.CompareTag("Player") && triggerType == TriggerType.ColorChange) {
      Renderer rend = other.GetComponent<Renderer>();
      if (rend != null) {
        rend.material.color = originalColor;
      }
    }
  }
}
