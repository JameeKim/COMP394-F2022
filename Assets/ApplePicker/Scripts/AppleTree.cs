using UnityEngine;

namespace ApplePicker
{
    public class AppleTree : MonoBehaviour
    {
        [Header("Movement")]
        [Range(0.1f, 100f)]
        [Tooltip("Speed (meters per second)")]
        public float speed = 2f;

        [Range(1f, 50f)]
        public float edgeLocation = 10f;

        [Range(0f, 1f)]
        public float chanceToChangeDirection = 0.1f;

        [Header("Apple Drop")]
        public GameObject applePrefab;

        [Range(0.001f, 10f)]
        [Tooltip("Apples dropped per second")]
        public float appleDropFrequency = 2f;

        private void FixedUpdate()
        {
            float distanceToMove = speed * Time.fixedDeltaTime;
        }
    }
}
