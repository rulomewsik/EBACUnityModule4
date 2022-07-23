using UnityEngine;

namespace Modulo_6.Script
{
    public class UpdateColorScript : MonoBehaviour
    {
        void Update()
        {
            var randColor = new Color(Random.value, Random.value, Random.value);
            GetComponent<MeshRenderer>().material.color = randColor;
        }
    }
}