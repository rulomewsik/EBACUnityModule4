using UnityEngine;

namespace Modulo_6.Script
{
    public class UpdateCubeSpawner : MonoBehaviour
    {
        public GameObject cubePrefab;
        public int cubeCounter;

        // Update is called once per frame
        private void Update()
        {
            cubeCounter++;
            var tempGameObj = Instantiate(cubePrefab);
            tempGameObj.name = "CubeNumber " + cubeCounter;

            var randColor = new Color(Random.value, Random.value, Random.value);
            tempGameObj.GetComponent<MeshRenderer>().material.color = randColor;
            tempGameObj.transform.position = Random.insideUnitSphere;
        }
    }
}
