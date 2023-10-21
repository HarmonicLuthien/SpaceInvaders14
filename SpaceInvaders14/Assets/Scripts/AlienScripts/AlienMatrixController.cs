using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMatrixController : MonoBehaviour
{
    public float moveSpeed = 1.0f;       // Rapidez de movimiento
    public float dropDistance = 1.0f;    // Distancia de descenso al tocar un borde

    private bool movingRight = true;     // Verdadero si se mueven a la derecha

    void Update()
    {
        MoveAliensHorizontally();
    }

    void MoveAliensHorizontally()
    {
        Vector3 direction = movingRight ? Vector3.right : Vector3.left;

        // Mueve la matriz en su totalidad
        transform.Translate(moveSpeed * Time.deltaTime * direction);

        // Revisa si ha llegado al borde
        if (AliensReachedEdge())
        {
            // Baja la matriz en una distancia especifica
            transform.Translate(Vector3.down * dropDistance);

            // Invierte el movimiento de la matriz
            movingRight = !movingRight;
        }
    }

    bool AliensReachedEdge()
    {
        // Revisa si cualquier posisión de la matriz se encuentra fuera de la cámara
        foreach (Transform alien in transform)
        {
            if (alien.position.x >= 25f || alien.position.x <= -25f)
            {
                return true;
            }
        }
        return false;
    }
}
