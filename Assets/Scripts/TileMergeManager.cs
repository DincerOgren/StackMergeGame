using UnityEngine;

public class TileMergeManager : MonoBehaviour
{
    void Start()
    {
        TileDetectManager.Instance.OnTileDetectedBelow += TryMerge;
    }

    public void TryMerge(TileData currentTile, TileData belowTile)
    {
       // if (currentTile == null || belowTile == null) return;

        if (currentTile.GetTileData() == belowTile.GetTileData())
        {
            Vector3 newPosition = belowTile.transform.position;
            int newValue = currentTile.GetTileData() * 2;

            // Yeni tile oluþtur
            //GameObject newTileObj = Instantiate(tilePrefab, newPosition, Quaternion.identity);
            //TileData newTileData = newTileObj.GetComponent<TileData>();
            //newTileData.Initialize(newValue);

            // Eskileri yok et
            Destroy(currentTile.gameObject);
            Destroy(belowTile.gameObject);

            Debug.Log($"Merged {currentTile.GetTileData()} + {belowTile.GetTileData()} -> {newValue}");
        }
        else
            print("They Are Not The Same Data");
    }

}
