using UnityEngine;

public class TileFactory : MonoBehaviour
{
    [SerializeField] GameObject baseTilePrefab;
    [SerializeField] Transform tileParent;

    // (Optional) If you plan to have different visuals for different values later
    [SerializeField] Material[] tileMaterials; // Index 0 => value 2, Index 1 => 4, etc.

    public GameObject SpawnTile(Vector3 position, int value)
    {
        GameObject tile = Instantiate(baseTilePrefab, position, Quaternion.identity);

        tile.transform.parent = tileParent;            
        // Example: Change material based on value
        //int index = Mathf.RoundToInt(Mathf.Log(value, 2)) - 1; // 2 => 0, 4 => 1, 8 => 2, etc.
        //if (tileMaterials != null && index >= 0 && index < tileMaterials.Length)
        //{
        //    tile.GetComponent<Renderer>().material = tileMaterials[index];
        //}

        tile.name = $"Tile_{value}";
        return tile;
    }
}
