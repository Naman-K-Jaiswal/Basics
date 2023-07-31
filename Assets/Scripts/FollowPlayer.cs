using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform cameraPosition;
    Transform playerPosition;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform;
        cameraPosition = GetComponent<Transform>();
        offset = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition.position = playerPosition.position +offset;
    }
}
