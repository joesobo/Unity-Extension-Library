using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class NumericalExtensions {
        // Remaps a value to a new range, keeping a linear value along range
        // EX: 0.5 in 0-1 gets converted to 50 in 0-100
        public static float LinearRemap(this float value, float minValue, float maxValue, float minNew, float maxNew) {
            return (value - minValue) / (maxValue - minValue) * (maxNew - minNew) + minNew;
        }

        // Gives value a random positive or negative sign
        public static int WithRandomSign(this int value, float negativeProbability = 0.5f) {
            return Random.value < negativeProbability ? -value : value;
        }

        // Gives result of a probability
        // EX: RandomProbability(33) = 33% chance of True
        public static bool RandomProbability(float percentage) {
            return (Random.Range(0, 100) < percentage);
        }

        // Returns a squared float
        public static float Squared(this float value) {
            return Mathf.Pow(value, 2);
        }

        // Returns a squared float
        public static float Squared(this int value) {
            return Mathf.Pow(value, 2);
        }

        // Returns a cubed float
        public static float Cubed(this float value) {
            return Mathf.Pow(value, 3);
        }

        // Returns a cubed float
        public static float Cubed(this int value) {
            return Mathf.Pow(value, 3);
        }
    }
}
