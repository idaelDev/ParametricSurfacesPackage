using System;

using UnityEngine;

using static UnityEngine.Mathf;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricWave : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0f, 10f)]
        public float Amplitude = 1;

        [SerializeField, Range(0f, 10f)]
        public float Frequency = PI;

        [SerializeField, Range(0f, 10f)]
        public float UMultiplier = 1;

        [SerializeField, Range(0f, 10f)]
        public float VMultiplier = 1;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.Wave(
                u,
                v,
                t,
                UMultiplier,
                VMultiplier,
                Frequency,
                Amplitude
                );
        }

        #endregion Public Methods
    }
}
