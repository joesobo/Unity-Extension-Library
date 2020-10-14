using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class _3DExtensions {
        // Returns if a point is inside the radius
        public static bool IsInsideRadius(Vector3 point, float radius = 2) {
            return Mathf.Pow(point.x, 2) + Mathf.Pow(point.y, 2) + Mathf.Pow(point.z, 2) < Mathf.Pow(radius, 2);
        }

        // Returns a random position in a radius
        public static Vector3 RandomPosition(float radius = 2) {
            return Random.onUnitSphere * radius;
        }

        // Returns a random position between 2 radii
        public static Vector3 RandomPositionBetweenRadii(float minRadius, float maxRadius) {
            float rand = Random.Range(minRadius, maxRadius);
            return RandomPosition(rand);
        }

        // Sets the X value of a vector
        public static Vector3 SetX(this Vector3 vector, float x) {
            return new Vector3(x, vector.y, vector.z);
        }

        // Sets the Y value of a vector
        public static Vector3 SetY(this Vector3 vector, float y) {
            return new Vector3(vector.x, y, vector.z);
        }

        // Sets the Z value of a vector
        public static Vector3 SetZ(this Vector3 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }

        // Converts a Vector2 into a Vector3
        public static Vector3 AddZ(this Vector2 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }
    }
}
