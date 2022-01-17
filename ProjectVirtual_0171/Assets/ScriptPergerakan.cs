using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPergerakan : MonoBehaviour
{
    public Transform cameraVR;
    public float posisiCamera = 30.0f;
    public float kecepatan = 3.0f;
    public bool pergerakan;
    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc =GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if  (cameraVR.eulerAngles.x>=posisiCamera && cameraVR.eulerAngles.x<90.0f)
        {
             pergerakan = true;
        }
        else
        {
            pergerakan = false;
        }
        if (pergerakan)
        {
            Vector3  forward=cameraVR.InverseTransformDirection(Vector3.forward);
            cc.SimpleMove(forward*kecepatan);
        }
    }
}