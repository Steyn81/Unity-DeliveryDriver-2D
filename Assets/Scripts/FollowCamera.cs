using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject carObject;

    //Last thing to update
    void LateUpdate()
    {
        //keep the camera's position the same as car
        transform.position = carObject.transform.position + new Vector3 (0, 0, -10);
    }
}
