using UnityEngine;

namespace Modulo_7.Script
{
    public class CubeFourScript : MonoBehaviour
    {
        public GameObject cubeOneGo;
        public GameObject cubeTwoGo;

        public bool booleanColor;

        private void FixedUpdate()
        {
            booleanColor = cubeOneGo.GetComponent<CubeOneScript>().booleanColor ||
                           cubeTwoGo.GetComponent<CubeTwoScript>().booleanColor;
            GetComponent<MeshRenderer>().material.color = booleanColor ? Color.white : Color.black;
        }
    }
}