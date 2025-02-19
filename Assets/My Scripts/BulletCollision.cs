using UnityEngine;

namespace AG3368
{
    public class BulletCollisionScript : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            // Check if the object hit by the projectile has the "Cube" tag
            if (collision.gameObject.CompareTag("Cube"))
            {
                // Access the CubeRoll script on the collided cube
                CubeRoll cubeRoll = collision.gameObject.GetComponent<CubeRoll>();
                if (cubeRoll != null)
                {
                    cubeRoll.RollCube();  // Call the method to roll the cube
                }
            }

            // Optionally, destroy the projectile after collision
            Destroy(gameObject);
        }
    }
}

