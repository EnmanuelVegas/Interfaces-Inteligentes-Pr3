using UnityEngine;

public class Colores : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
  {
    string nombre = collision.gameObject.name;
    Debug.Log(nombre);
    Material material = Resources.Load<Material>("materials/" + nombre);
    if (material != null)
    {
      Renderer renderer = collision.gameObject.GetComponent<Renderer>();
      renderer.material = material;
    }
    else
    {
      Debug.LogWarning("No se encontró el material: materials/" + nombre);
    }
  }
}
