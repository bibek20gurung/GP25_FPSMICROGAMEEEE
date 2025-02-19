using UnityEngine;

namespace AG3368
{
    public class HoverUpDown : MonoBehaviour
    {
        public Transform point1;  // The first end point
        public Transform point2;  // The second end point
        public float speed = 1f;  // The speed of the hovering motion
        private float lerpTime = 0f; // Time variable for Lerp

        void Update()
        {
            // Smoothly move between point1 and point2
            lerpTime += Time.deltaTime * speed;

            // Ensure lerpTime loops between 0 and 1
            if (lerpTime > 1f)
            {
                lerpTime = 0f;  // Reset lerpTime when it exceeds 1
            }

            // Use Lerp to move the capsule between point1 and point2
            transform.position = Vector3.Lerp(point1.position, point2.position, Mathf.PingPong(lerpTime, 1));
        }
    }
}
