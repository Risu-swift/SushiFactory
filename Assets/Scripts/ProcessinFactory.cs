using System;
using UnityEngine;
using UnityEngine.Splines;

public class ProcessinFactory : MonoBehaviour
{
    public float timePerElement;
    public Spline OutputSpline;

    private void Start()
    {
        OutputSpline = new Spline();
    }
}
