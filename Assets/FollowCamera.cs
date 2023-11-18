using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform followedGameObject;
    [SerializeField] float cameraHeight;
    // we got to make this camera to follow the car with specific height
    void LateUpdate()
    {
        transform.position = new Vector3(followedGameObject.position.x, followedGameObject.position.y, -cameraHeight);
    }
}
