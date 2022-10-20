using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class PlayerController : PortalableObject
{
    private bool flag1 = true;
    private CameraMove cameraMove;

    protected override void Awake()
    {
        base.Awake();

        cameraMove = GetComponent<CameraMove>();
    }

    public override void Warp()
    {   
        if (flag1 == true){
        base.Warp();
        
        //Vector3 bob = new Vector3( 5f,  0f, 5f);
        //Vector3 relativePos = inTransform.InverseTransformPoint(transform.position);
        //transform.position = outTransform.TransformPoint(relativePos+bob);

        cameraMove.ResetTargetRotation();
        flag1 = false;
        Thread.Sleep(1000);
        flag1 = false;
        }
    }
}
