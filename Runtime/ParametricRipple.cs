using System;

using UnityEngine;

using static UnityEngine.Mathf;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricRipple : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0.01f, 10f)]
        public float Amplitude = 0.1f;

        [SerializeField, Range(0f, 10f)]
        public float Frequency = PI;

        [SerializeField, Range(0f, 10f)]
        public float WaveFrequency = 4;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.Ripple(
                u,
                v,
                t,
                Frequency,
                Amplitude,
                WaveFrequency
                );
        }

        #endregion Public Methods
    }
}
