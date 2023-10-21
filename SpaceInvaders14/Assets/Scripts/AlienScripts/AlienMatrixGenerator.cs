using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMatrixGenerator : MonoBehaviour
{
    public GameObject alienPrefab; // Referencia
    public int rows = 5; // Número de filas
    public int columns = 10; // Número de columnas
    public float spacing = 1.0f; // Espaciado

    void Awake()
    {
        GenerateAlienMatrix();
    }

    void GenerateAlienMatrix()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                // Calcula la posición para cada elemento en la matriz
                float xPos = col * spacing;
                float yPos = row * spacing;

                // Instancía una prefab en cada posición
                Vector3 position = transform.position + new Vector3(xPos, yPos, 0);
                Instantiate(alienPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}

