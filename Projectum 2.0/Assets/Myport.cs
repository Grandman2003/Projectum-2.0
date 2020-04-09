using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myport : MonoBehaviour
{

    public Transform vrCamera;
    public bool moveForward;
    // Start is called before the first frame update
    private CharacterController cc;
    private GameObject teleport;

    // Use this for initialization
    void Start()
    {
        teleport = GetComponent<GameObject>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     

    }
    public void Teleportic()
    {
        Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
        cc.Move(forward*4);
    }
}
