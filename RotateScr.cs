using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScr : MonoBehaviour
{
    public float speed = 1f;
    private bool putar;

    private string sumbu;
    // Update is called once per frame
    void Update()
    {
        if (putar)
        {
            if(sumbu.ToUpper().Equals("X"))
            {
                transform.Rotate(Vector3.right * speed);
            }
            if(sumbu.ToUpper().Equals("Y"))
                transform.Rotate(Vector3.up * speed);
            if (sumbu.ToUpper().Equals("Z"))
                transform.Rotate(Vector3.forward * speed);
        }
    }

    public void RotateCube(string sumbu)
    {
        this.sumbu = sumbu;
        putar = true;
    }
    public void StopRotation()
    {
        putar = false;
    }
}
