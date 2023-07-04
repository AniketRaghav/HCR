using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class PlatformCreator : MonoBehaviour
{
    public SpriteShapeController shape;
    public int scale = 100;
    public int numofPoints = 150;
    public int distanceBwtnpoints = 3;


    private void Start()
    {
        shape = GetComponent<SpriteShapeController>();
        float distanceBwtnpoints = (float)scale/(float)numofPoints;
        shape.spline.SetPosition(index: 2, point: shape.spline.GetPosition(index: 2) + Vector3.right * 100);
        shape.spline.SetPosition(index: 3, point: shape.spline.GetPosition(index: 2) + Vector3.right * 100);

        for(int i =0; i < 150; i++)
        {
            float xPos = shape.spline.GetPosition(index: i + 1).x + distanceBwtnpoints;       
            shape.spline.InsertPointAt(index:i+2,point:new Vector3(xPos,y:10*Mathf.PerlinNoise(x:i*Random.Range(5f,15f),y:0)));
        }
        for(int i = 0;i< 152;i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i,tangent:new Vector3(x:-2,y:0,z:0));
            shape.spline.SetRightTangent(i, tangent: new Vector3(x:2, y: 0, z: 0));
        }
    }

}
