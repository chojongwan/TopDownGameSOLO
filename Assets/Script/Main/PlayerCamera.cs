using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour
{
    public GameObject Character;
    Transform AT;
    void Start()
    {
        AT = Character.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(AT.position.x, AT.position.y, transform.position.z);
    }
}