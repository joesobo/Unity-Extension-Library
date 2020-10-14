using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class _2DExtensions {
        public static Vector2 Rotate(this Vector2 vector, float degree) {
            float sin = Mathf.Sin(degrees * MathF.Deg2Rad);
            float cos = Mathf.Cos(degrees * MathF.Deg2Rad);

            float tx = vector.x;
            float ty = vector.y;
            vector.x = (cos * tx) - (sin * ty);
            vector.y = (sin * tx) + (cos * ty);

            return vector;
        }

        public static float RotationNormalizedDegree(this float rotation) {
            rotation %= 360;
            if (rotation < 0) {
                rotation += 360;
            }
            return rotation;
        }
    }
}
