using UnityEngine;

namespace Modulo_7.Script
{
    public class CubeOneScript : MonoBehaviour
    {
        public bool booleanColor;

        private void FixedUpdate()
        {
            GetComponent<MeshRenderer>().material.color = booleanColor ? Color.white : Color.black;
            booleanColor = !booleanColor;
        }
    }
}