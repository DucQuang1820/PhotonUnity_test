using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

//let camera follow target
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 10f;

    private Vector3 offset;

    private Vector3 targetPos;

    PhotonView view;

    private void Start()
    {
        if(view.IsMine)
        {
            if (target == null) return;
            offset = transform.position - target.position;
        }
        
    }

    private void Update()
    {
        if(view.IsMine)
        {
            if (target == null) return;

            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
        }
    }
}       
