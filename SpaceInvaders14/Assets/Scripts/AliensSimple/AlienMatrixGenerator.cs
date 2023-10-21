using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMatrixGenerator : MonoBehaviour
{
    public GameObject alienPrefab; // Reference to the alien prefab
    public int rows = 5; // Number of rows
    public int columns = 10; // Number of columns
    public float spacing = 1.0f; // Spacing between aliens

    void Start()
    {
        GenerateAlienMatrix();
    }

    void GenerateAlienMatrix()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                // Calculate the position for each alien in the matrix
                float xPos = col * spacing;
                float yPos = row * spacing;

                // Instantiate an alien prefab at the calculated position
                Vector3 position = transform.position + new Vector3(xPos, yPos, 0);
                Instantiate(alienPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}

