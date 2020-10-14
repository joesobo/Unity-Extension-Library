using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class BasicExtensions {
        public static void ResetTransform(this Transform trans) {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = Vector3.one;
        }

        public static void ResetChildTransform(this Transform trans, bool recursive = false) {
            foreach (Transform child in transform) {
                child.ResetTransform();

                if (recursive) {
                    child.ResetChildTransform(recursive);
                }
            }
        }

        public static void SetChildLayers(this Transform transform, string layerName, bool recursive = false) {
            var layer = LayerMask.NameToLayer(layerName);
            foreach (Transform child in transform)
            {
                child.gameObject.layer = layer;

                if (recursive) {
                    child.SetChildLayers(layerName, recursive);
                }
            }
        }

        public static Vector3 SetX(this Vector3 vector, float x) {
            return new Vector3(x, vector.y, vector.z);
        }

        public static Vector3 SetY(this Vector3 vector, float y) {
            return new Vector3(vector.x, y, vector.z);
        }

        public static Vector3 SetZ(this Vector3 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }

        public static bool HasComponent<T>(this GameObject gameObject) where T : Component {
            return gameObject.GetComponent<T>() != null;
        }

        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component {
            return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
        }

        public static void DestroyChildren(this GameObject parent) {
            List<Transform> children = new List<Transform>();
            for (int i = 0; i < parent.transform.childCount; i++) {
                children.Add(parent.transform.GetChild(i));
            }
            for (int i = 0; i < children.Count; i++) {
                GameObject.Destroy(children[i]);
            }
        }

        public static bool isVisibleFrom(this Renderer renderer, Camera camera) {
            var planes = GeometryUtility.CalculateFrustumPlanes(camera);
            return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
        }
    }
}
