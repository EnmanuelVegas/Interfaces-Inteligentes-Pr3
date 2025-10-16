using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{

  private float velocidad;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    velocidad = 10;
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, Space.World);
    transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * velocidad * Time.deltaTime, Space.World);
  }
}