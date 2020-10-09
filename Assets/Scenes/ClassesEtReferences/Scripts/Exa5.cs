using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exa5 : MonoBehaviour
{

    public MeshRenderer SphereMeshRenderer;
    public GameObject CylinderGameObject;
    public SpinningComponent CubeSpinningComponent;
    public Color ColorToAply;
    bool _isCylinderActive;

    void Start()
    {
        SphereMeshRenderer.material.color = ColorToAply;
        InvokeRepeating("SwitchCylinder", 0, 1);
        CubeSpinningComponent.IsSpinning = true;
    }

    void SwitchCylinder()
    {
        CylinderGameObject.SetActive(!_isCylinderActive);
        
    }

}
