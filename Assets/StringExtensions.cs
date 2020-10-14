using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class StringExtensions {
        // Returns a portion of the given string
        public static string Truncate(this string value, int maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
