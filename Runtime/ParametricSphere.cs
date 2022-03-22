using System;

using UnityEngine;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricSphere : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0f, 10f)]
        public float Radius = 1f;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.Sphere(
                u,
                v,
                Radius
                );
        }

        #endregion Public Methods
    }
}
