using UnityEngine;

namespace Modulo_6.Script
{
    public class AwakeColorScript : MonoBehaviour
    {
        private void Awake()
        {
            var randColor = new Color(Random.value, Random.value, Random.value);
            GetComponent<MeshRenderer>().material.color = randColor;
        }
    }
}
