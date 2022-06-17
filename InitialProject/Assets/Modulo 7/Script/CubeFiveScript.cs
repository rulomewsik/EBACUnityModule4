using UnityEngine;

namespace Modulo_7.Script
{
    public class CubeFiveScript : MonoBehaviour
    {
        public GameObject cubeThreeGo;
        public GameObject cubeFourGo;
        
        private bool _booleanColor;
        private void FixedUpdate()
        {
            _booleanColor = cubeThreeGo.GetComponent<CubeThreeScript>().booleanColor && cubeFourGo.GetComponent<CubeFourScript>().booleanColor;
            GetComponent<MeshRenderer>().material.color = _booleanColor ? Color.white : Color.black;
        }
    }
}