using UnityEngine;

namespace AG3368
{
    public class CubeRoll : MonoBehaviour
    {
        public float rollSpeed = 5f;

        public void RollCube()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Apply a force to roll the cube
                rb.AddForce(Vector3.right * rollSpeed, ForceMode.Impulse);
            }
        }
    }
}


