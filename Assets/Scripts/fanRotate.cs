using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanRotate : MonoBehaviour
{
    public float speedTurn;
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * -speedTurn);
    }
}
