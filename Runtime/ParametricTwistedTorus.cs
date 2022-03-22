using System;

using UnityEngine;

namespace IdaelLib.ParametricSurfaces
{
    [Serializable]
    public class ParametricTwistedTorus : IParametricSurface
    {
        #region Public Fields

        [SerializeField, Range(0f, 10f)]
        public float InsideAmplitudes = 0.05f;

        [SerializeField, Range(0f, 10f)]
        public float InsideFrequencies = Mathf.PI;

        [SerializeField, Range(0f, 10f)]
        public float InsideRadius = 0.15f;

        [SerializeField, Range(0f, 10f)]
        public float InsideUMults = 8f;

        [SerializeField, Range(0f, 10f)]
        public float InsideVMults = 4f;

        [SerializeField, Range(0f, 10f)]
        public float OutsideAmplitudes = 0.1f;

        [SerializeField, Range(0f, 10f)]
        public float OutsideFrequencies = Mathf.PI;

        [SerializeField, Range(0f, 10f)]
        public float OutsideRadius = 0.7f;

        [SerializeField, Range(0f, 10f)]
        public float OutsideUMults = 6;

        [SerializeField, Range(0f, 10f)]
        public float OutsideVMults = 0.5f;

        #endregion Public Fields

        #region Public Methods

        public Vector3 GetPosition(float u, float v, float t)
        {
            return SurfacesFunctions.TwistedTorus(
                u,
                v,
                t,
                OutsideRadius,
                InsideRadius,
                OutsideAmplitudes,
                InsideAmplitudes,
                OutsideFrequencies,
                InsideFrequencies,
                OutsideUMults,
                InsideUMults,
                OutsideVMults,
                InsideVMults
                );
        }

        #endregion Public Methods
    }
}
