using UnityEngine;

public class AddForce : MonoBehaviour
{
  private Rigidbody rb;
  public float intensidad = 500f;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    if (Input.GetKeyDown(KeyCode.X)) {
      Vector3 randomForce = new Vector3(
        Random.Range(-intensidad, intensidad), 
        Random.Range(-intensidad, intensidad), 
        Random.Range(-intensidad, intensidad)
      );    
      rb.AddForce(randomForce);
    }
  }
}