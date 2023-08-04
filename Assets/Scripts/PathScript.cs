using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PathScript : MonoBehaviour
{
    public List<Transform> path = new List<Transform>();


    public List<Transform> GetPath()
    {
        return path;
    }


    private void OnDrawGizmos()
    {
        for(int i = 0; i < path.Count -1 ; i++)
        {
            Gizmos.DrawLine(path[i].position, path[i + 1].position);
        }
    }
}
