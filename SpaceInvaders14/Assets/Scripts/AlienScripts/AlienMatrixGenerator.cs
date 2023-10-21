using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMatrixGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject alienPrefab; // Referencia
    [SerializeField]
    private int rows = 5; // Número de filas
    [SerializeField]
    private int columns = 10; // Número de columnas
    [SerializeField]
    private float spacing = 1.0f; // Espaciado

    private void Awake()
    {
        GenerateAlienMatrix();
    }

    private void GenerateAlienMatrix()
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

