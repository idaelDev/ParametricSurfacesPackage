using System;

using UnityEngine;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricTorus : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0f, 10f)]
        public float InsideRadius = 0.15f;

        [SerializeField, Range(0f, 10f)]
        public float OutsideRadius = 0.7f;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.Torus(
                u,
                v,
                OutsideRadius,
                InsideRadius
                );
        }

        #endregion Public Methods
    }
}
