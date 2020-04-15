using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject objectToFollow;
    private Vector3 offset;   // distance between objectToFollow and camera


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - objectToFollow.transform.position;
    }

    // LateUpdate is called once per frame after all other updates
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + offset;
    }
}
