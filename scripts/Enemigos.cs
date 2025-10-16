using UnityEngine;

public class Enemigos : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
    {
      Debug.Log("¡Enemigo ha tocado al jugador!");
    }
  }
}