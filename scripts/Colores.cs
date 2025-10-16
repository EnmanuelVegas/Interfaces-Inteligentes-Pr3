using UnityEngine;

public class Colores : MonoBehaviour
{
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
      
  }

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
