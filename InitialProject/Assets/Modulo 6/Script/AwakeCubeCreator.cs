using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Modulo_6.Script
{
    public class AwakeCubeCreator : MonoBehaviour
    {
        private GameObject _objToSpawn;

        private readonly Vector3[] _vertices = {
            new(0,0,0),
            new(1,0,0),
            new(1,1,0),
            new(0,1,0),
            new(0,1,1),
            new(1,1,1),
            new(1,0,1),
            new(0,0,1)
        };

        private readonly int[] _triangles =
        {
            0, 2, 1,
            0, 3, 2,
            2, 3, 4,
            2, 4, 5,
            1, 2, 5,
            1, 5, 6,
            0, 7, 4,
            0, 4, 3,
            5, 4, 7,
            5, 7, 6,
            0, 6, 7,
            0, 1, 6
        };

        private void Awake()
        {
            _objToSpawn = new GameObject();
            _objToSpawn.AddComponent<MeshFilter>();
        
            var meshFilter = _objToSpawn.GetComponent<MeshFilter>().mesh;
            meshFilter.Clear();
            meshFilter.vertices = _vertices;
            meshFilter.triangles = _triangles;
            meshFilter.Optimize();
            meshFilter.RecalculateNormals();

            _objToSpawn.AddComponent<BoxCollider>();
            var boxCollider = _objToSpawn.GetComponent<BoxCollider>();
            boxCollider.center = new Vector3(0.5F, 0.5F, 0.5F);

            _objToSpawn.AddComponent<MeshRenderer>();
            var meshRendererMaterial = _objToSpawn.GetComponent<MeshRenderer>().material;
            meshRendererMaterial.color = Color.red;

            _objToSpawn.transform.localScale = new Vector3(5, 5, 5);
            _objToSpawn.transform.position = new Vector3(-2.5F, 1, 13);
        }
    }
}
