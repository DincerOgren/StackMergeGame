using UnityEngine;

public class TileData : MonoBehaviour
{
    [SerializeField] TileDataSO tileData;

    [SerializeField] int tileNum = 2;
    private void Start()
    {
        tileData.Initialize(tileNum);
    }






    public int GetTileData() => tileNum;



}
