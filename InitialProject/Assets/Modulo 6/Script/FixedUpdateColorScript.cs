using UnityEngine;

namespace Modulo_6.Script
{
    public class FixedUpdateColorScript : MonoBehaviour
    {
        private void FixedUpdate()
        {
            var randColor = new Color(Random.value, Random.value, Random.value);
            GetComponent<MeshRenderer>().material.color = randColor;
        }
    }
}