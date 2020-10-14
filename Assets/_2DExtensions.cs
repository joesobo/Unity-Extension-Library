using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class _2DExtensions {
        // Rotates a vector bya number of degrees
        public static Vector2 Rotate(this Vector2 vector, float degrees) {
            float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
            float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

            float tx = vector.x;
            float ty = vector.y;
            vector.x = (cos * tx) - (sin * ty);
            vector.y = (sin * tx) + (cos * ty);

            return vector;
        }

        // Converts rotation to degrees
        public static float RotationNormalizedDegree(this float rotation) {
            rotation %= 360;
            if (rotation < 0) {
                rotation += 360;
            }
            return rotation;
        }

        // Converts Vector3 to Vector2
        public static Vector2 xy(this Vector3 v) {
            return new Vector2(v.x, v.y);
        }

        // Sets the X value of a vector
        public static Vector2 SetX(this Vector2 vector, float x) {
            return new Vector2(x, vector.y);
        }

        // Sets the Y value of a vector
        public static Vector2 SetY(this Vector2 vector, float y) {
            return new Vector2(vector.x, y);
        }
    }
}
