﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class ColorExtensions {
        public static readonly Color Black = new Color(0, 0, 0);
        public static readonly Color White = new Color(255, 255, 255);
        public static readonly Color Red = new Color(255, 0, 0);
        public static readonly Color Green = new Color(0, 255, 0);
        public static readonly Color Blue = new Color(0, 0, 255);
        public static readonly Color Yellow = new Color(255, 255, 0);
        public static readonly Color Purple = new Color(255, 0, 255);
        public static readonly Color Cyan = new Color(0, 255, 255);

        // Converts hex code to a color
        // EX: #000000 => RGBA(0, 0, 0, 255);
        // EX: 0x000000 => RGBA(0, 0, 0, 255);
        // EX: #000000, 0 => RGBA(0, 0, 0, 0);
        // EX: #00000000 => RGBA(0, 0, 0, 0);
        public static Color32 HexToRGBA(string hex, byte alpha = 255) {
            hex = hex.Replace("0x", "");
            hex = hex.Replace("#", "");

            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            if (hex.Length == 8) {
                alpha = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
            }

            return new Color32(r, g, b, alpha);
        }

        // Converts a color into hex code
        public static string RGBToHex(Color32 c) {
            return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", c.r, c.g, c.b, c.a);
        }

        // Easily change a colors alpha
        public static Color32 WithAlpha(this Color32 color, float alpha) {
            return new Color32(color.r, color.g, color.b, alpha);
        }
    }
}
