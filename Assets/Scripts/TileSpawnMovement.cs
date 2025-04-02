using DG.Tweening;
using DG.Tweening.Core;
using System;
using UnityEngine;

public class TileSpawnMovement : MonoBehaviour
{
    [SerializeField] Transform referencedObject;
    [SerializeField] float _xTarget = 1f;
    [SerializeField] float _moveDuration = 1f;

    Tween baseLoop = null;

    private void Start()
    {
        transform.position = new Vector3(-_xTarget, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
           MoveObject();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (baseLoop == null)
            {
                print("Base loop is empty");
            }
            else
            {
                baseLoop.Kill();
                print("Loop killed");
                GetComponent<Rigidbody>().useGravity = true;
            }
        }
        // MoveObject();
    }

    private void MoveObject()
    {

        //transform.DOMove(new Vector3(_xTarget, transform.position.y, 0), _moveDuration).SetEase(Ease.InBounce);

        
        baseLoop = transform.DOMoveX(_xTarget, _moveDuration)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.InOutSine);
    }

}   
