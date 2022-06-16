using UnityEngine;

namespace Modulo_6.Script
{
    public class AwakeCubeCreator : MonoBehaviour
    {
        public GameObject cubePrefab;

        private void Awake()
        {
            var tempGameObj = Instantiate(cubePrefab);
            var meshRendererMaterial = tempGameObj.GetComponent<MeshRenderer>().material;
            meshRendererMaterial.color = Color.red;

            tempGameObj.transform.localScale = new Vector3(5, 5, 5);
            tempGameObj.transform.position = new Vector3(-2.5F, 1, 13);
        }
    }
}
