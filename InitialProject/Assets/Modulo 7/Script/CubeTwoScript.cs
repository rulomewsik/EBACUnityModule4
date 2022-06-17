using UnityEngine;

namespace Modulo_7.Script
{
    public class CubeTwoScript : MonoBehaviour
    {
        public bool booleanColor;

        private void FixedUpdate()
        {
            GetComponent<MeshRenderer>().material.color = booleanColor ? Color.white : Color.black;
        }
    }
}