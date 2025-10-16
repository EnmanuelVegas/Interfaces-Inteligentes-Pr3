using UnityEngine;

public class Dano : MonoBehaviour
{
  public int dano;
  public Light luzEscena; // Arrastrar desde el editor
  private float temperaturaOriginal;
  public float temperaturaCaliente = 2000f;
  private Color colorOriginal;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    dano = 0;
    // Si no se asigna la luz manualmente, busca la primera luz en la escena
    if (luzEscena == null)
    {
      luzEscena = FindFirstObjectByType<Light>();
    }
    // Guardar la temperatura original
    if (luzEscena != null)
    {
      temperaturaOriginal = luzEscena.colorTemperature;
    }
    Renderer renderer = GetComponent<Renderer>();
    if (renderer != null && renderer.material != null)
    {
      colorOriginal = renderer.material.color;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider collision)
  {
    switch (collision.gameObject.name)
    {
      case "Luz":
        if (luzEscena != null)
        {
          luzEscena.colorTemperature = temperaturaCaliente;
        }
        Debug.Log("hoña");
        GetComponent<Renderer>().material.color = Color.green;
        break;
      case "Dano":
        dano++;
        // Debug.Log("Daño incrementado a: " + dano);        
        break;
      default:
        break;
    }
  }

  void OnTriggerExit(Collider collision)
  {
    switch (collision.gameObject.name)
    {
      case "Luz":
        if (luzEscena != null)
        {
          luzEscena.colorTemperature = temperaturaOriginal;
        }
        GetComponent<Renderer>().material.color = colorOriginal;
        break;
      case "Dano":
        Debug.Log("Daño recibido: " + dano);
        break;
      default:
        break;
    }
  }

}
