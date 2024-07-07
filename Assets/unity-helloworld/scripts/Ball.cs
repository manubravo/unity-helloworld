using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float speed = 10.0f; // Velocidad de movimiento de la esfera

    void Update()
    {
        // Obtiene el input de los ejes horizontales y verticales
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crea un vector de movimiento basado en los inputs
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplica el movimiento a la posición de la esfera
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
