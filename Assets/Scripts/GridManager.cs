using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject cardPrefab; // Assign your card prefab here
    public int rows = 4;
    public int columns = 4;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < rows * columns; i++)
        {
            GameObject card = Instantiate(cardPrefab, transform);
            card.name = $"Card_{i}";
        }
    }
}