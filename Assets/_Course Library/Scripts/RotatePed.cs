using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePed : MonoBehaviour
{
    public GameObject pedestal;
    public void RotatePedestal(){
        transform.Rotate(0, 1, 0, Space.Self);
    }
}
