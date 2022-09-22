using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rigiBody;

    [SerializeField] float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rigiBody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rigiBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            mRenderer.enabled = true;
            rigiBody.useGravity = true;
        }
    }
}
