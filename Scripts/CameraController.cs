using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Start() {
        offset = transform.position - target.position;
    }
    private void Update()
    {
        transform.position = target.position + offset;
    }
}
