using UnityEngine;

namespace Modulo_6.Script
{
    public class DisableCubeCreator : MonoBehaviour
    {
        public GameObject cubePrefab;

        private void OnEnable()
        {
            var tempGameObj = Instantiate(cubePrefab);
            var meshRendererMaterial = tempGameObj.GetComponent<MeshRenderer>().material;
            meshRendererMaterial.color = Color.cyan;

            tempGameObj.transform.localScale = new Vector3(2, 2, 2);
            tempGameObj.transform.position = new Vector3(-2.5F, 1, 13);
        }

        private void OnDisable()
        {
            var tempGameObj = Instantiate(cubePrefab);
            var meshRendererMaterial = tempGameObj.GetComponent<MeshRenderer>().material;
            meshRendererMaterial.color = Color.green;

            tempGameObj.transform.localScale = new Vector3(2, 2, 2);
            tempGameObj.transform.position = new Vector3(-2.5F, 1, 13);
        }
    }
}