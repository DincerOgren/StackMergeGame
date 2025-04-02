using System;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] GameObject tilePrefab;
    [SerializeField] Transform tileHeightTracker;

    [SerializeField] float yOffsetAmount=.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SpawnTile();
        }
    }

    private void SpawnTile()
    {
        var spawnedTile = Instantiate(tilePrefab, tileHeightTracker.position.y * Vector3.up,Quaternion.identity);


        //

        Vector3 temp = tileHeightTracker.position;
        temp.y += yOffsetAmount;
        tileHeightTracker.position = temp;

    }
}
