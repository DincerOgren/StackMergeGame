using System;
using UnityEngine;

public class TileDetect : MonoBehaviour
{
    [SerializeField] float downTileRaycastDist = .5f;
    [SerializeField] LayerMask tileLayer;



    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * downTileRaycastDist, Color.red, 10000f);
        CheckRaycast();
    }

    void CheckRaycast()
    {
        bool isHit = Physics.Raycast(transform.position, Vector3.down, out RaycastHit hitInfo, downTileRaycastDist, tileLayer);
        if (isHit)
        {
            print("Hitted " + hitInfo.transform.name + " in "+transform.name);
            TileData detectedTileData = hitInfo.transform.GetComponent<TileData>();
            TileDetectManager.Instance.OnTileDetectedBelow?.Invoke(GetComponent<TileData>(),detectedTileData);
        }
    }
}
