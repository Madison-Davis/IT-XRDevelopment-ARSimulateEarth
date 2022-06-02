using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbiter : MonoBehaviour
{
    public Transform world;
    public float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        world.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);
    }
}
