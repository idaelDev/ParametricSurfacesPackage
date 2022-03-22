using System;

using UnityEngine;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricTwistedSphere : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0f, 10f)]
        public float Amplitude = 0.1f;

        [SerializeField, Range(0f, 10f)]
        public float Frequency = Mathf.PI;

        [SerializeField, Range(0f, 10f)]
        public float Radius = 0.9f;

        [SerializeField, Range(0f, 10f)]
        public float UMult = 6f;

        [SerializeField, Range(0f, 10f)]
        public float VMult = 4f;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.TwistedSphere(
                u,
                v,
                t,
                Radius,
                Amplitude,
                Frequency,
                UMult,
                VMult
                );
        }

        #endregion Public Methods
    }
}
