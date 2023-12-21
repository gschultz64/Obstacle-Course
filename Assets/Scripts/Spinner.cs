using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float rotateX = 1f;
    [SerializeField] private float rotateY = 1f;
    [SerializeField] private float rotateZ = 1f;

    private void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ);
    }
}
