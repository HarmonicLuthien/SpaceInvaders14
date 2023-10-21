using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMatrixController : MonoBehaviour
{
    public float moveSpeed = 1.0f;       // Speed at which aliens move
    public float dropDistance = 1.0f;    // Distance to drop when reaching the screen edge

    private bool movingRight = true;     // True if aliens are moving right

    void Update()
    {
        MoveAliensHorizontally();
    }

    void MoveAliensHorizontally()
    {
        Vector3 direction = movingRight ? Vector3.right : Vector3.left;

        // Move the entire matrix
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        // Check if aliens have reached the screen edge
        if (AliensReachedEdge())
        {
            // Drop the matrix by the specified distance
            transform.Translate(Vector3.down * dropDistance);

            // Invert the movement direction
            movingRight = !movingRight;
        }
    }

    bool AliensReachedEdge()
    {
        // Check if any alien's position is outside the screen boundary
        foreach (Transform alien in transform)
        {
            if (alien.position.x >= 20f || alien.position.x <= -20f)
            {
                Debug.Log("Alien reached edge: " + alien.position.x);
                return true;
            }
        }
        return false;
    }
}

