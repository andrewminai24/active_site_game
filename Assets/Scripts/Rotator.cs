using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // TODO: also add a function that rotates in mobile
    [SerializeField] Transform rotateParent = null; // optional to rotate a different transform
    [SerializeField] bool autoRotate = true;
    [SerializeField] float autoRotateSpeed = 0.5f;

    Transform objectToRotate;

    void Start()
    {
        objectToRotate = (rotateParent == null) ? transform : rotateParent;
    }

    void Update()
    {
        if(autoRotate)
            objectToRotate.Rotate(Vector3.up * (autoRotateSpeed * Time.deltaTime));
    }

    void OnMouseDrag()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        //Vector2 mouseDeltaSpeed = new Vector2(Input.acceleration.x * mouseDelta.x, Input.acceleration.y * mouseDelta.y);

        objectToRotate.rotation = Quaternion.Euler(mouseDelta.y * mouseDelta.magnitude, -mouseDelta.x * mouseDelta.magnitude, 0) * transform.rotation;
    }
}
