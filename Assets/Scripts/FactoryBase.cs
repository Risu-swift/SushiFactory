using System;
using UnityEngine;
using UnityEngine.Splines;

public abstract class FactoryBase : MonoBehaviour
{
    /// <summary>
    /// The time it takes to produce a single item
    /// </summary>
    public float TimePerElement;
    
    /// <summary>
    /// The spline conveyor belt which connects to the output
    /// </summary>
    public ConveyorBelt OutputSpline;

    /// <summary>
    /// Y-axis offset to compensate for mesh placement
    /// </summary>
    public float yOffset;
}