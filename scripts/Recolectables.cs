using UnityEngine;

public class Recolectables : MonoBehaviour
{
  public int itemsRecolectados = 0;
    
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.layer == LayerMask.NameToLayer("coleccionable"))
    {
      Debug.Log("¡Item recolectado!");
      itemsRecolectados++;
      Destroy(other.gameObject); // Destruimos objeto
    }
}
}