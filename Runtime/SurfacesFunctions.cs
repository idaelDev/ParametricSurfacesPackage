using UnityEngine;

using static UnityEngine.Mathf;

namespace IdaelLib.ParametricSurfaces
{
    /// <summary>
    /// Helper class to draw some animated parametric surfaces
    /// </summary>
    public static class SurfacesFunctions
    {
        #region Public Methods

        /// <summary>
        /// draw a surface ripple effect
        /// </summary>
        /// <param name="u">u coordinate on the surface</param>
        /// <param name="v">v coordinate on the surface</param>
        /// <param name="t">time in sec</param>
        /// <param name="frequency"></param>
        /// <param name="amplitude"></param>
        /// <param name="waveFrequency"></param>
        /// <returns></returns>
        public static Vector3 Ripple(float u, float v, float t, float frequency, float amplitude, float waveFrequency)
        {
            float d = Sqrt(u * u + v * v);
            Vector3 p;
            p.x = u;
            p.y = Sin(frequency * (waveFrequency * d - t)) / ((1f + (1 / amplitude * d)));
            p.z = v;
            return p;
        }

        /// <summary>
        /// Draw a sphere
        /// </summary>
        /// <param name="u">u coordinate on the surface</param>
        /// <param name="v">v coordinate on the surface</param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Vector3 Sphere(float u, float v, float radius)
        {
            float r = radius;
            float s = r * Cos(0.5f * PI * v);
            Vector3 p;
            p.x = s * Sin(PI * u);
            p.y = r * Sin(0.5f * PI * v);
            p.z = s * Cos(PI * u);
            return p;
        }

        /// <summary>
        /// Draw a torus
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Vector3 Torus(float u, float v, float outsideRadius, float insideRadius)
        {
            float r1 = outsideRadius;
            float r2 = insideRadius;
            float s = 0.5f + r1 + r2 * Cos(PI * v);
            Vector3 p;
            p.x = s * Sin(PI * u);
            p.y = r2 * Sin(PI * v);
            p.z = s * Cos(PI * u);
            return p;
        }

        /// <summary>
        /// Draw an animated twisted sphere
        /// </summary>
        /// <param name="u">u coordinate on the surface</param>
        /// <param name="v">v coordinate on the surface</param>
        /// <param name="radius"></param>
        /// <param name="t">time in sec</param>
        /// <param name="amplitude"></param>
        /// <param name="frequency"></param>
        /// <param name="uMult"></param>
        /// <param name="vMult"></param>
        /// <returns></returns>
        public static Vector3 TwistedSphere(float u, float v, float t, float radius, float amplitude, float frequency, float uMult, float vMult)
        {
            float r = radius + amplitude * Sin(frequency * (uMult * u + vMult * v + t));
            return Sphere(u, v, r);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="t"></param>
        /// <param name="OutsideRadius"></param>
        /// <param name="InsideRadius"></param>
        /// <param name="OutsideAmplitude"></param>
        /// <param name="InsideAmplitude"></param>
        /// <param name="OutsideFrequency"></param>
        /// <param name="InsideFrequency"></param>
        /// <param name="OutsideUMult"></param>
        /// <param name="InsideUMult"></param>
        /// <param name="OutsideVMult"></param>
        /// <param name="InsideVMult"></param>
        /// <returns></returns>
        public static Vector3 TwistedTorus(float u, float v, float t, float OutsideRadius, float InsideRadius, float OutsideAmplitude, float InsideAmplitude, float OutsideFrequency, float InsideFrequency, float OutsideUMult, float InsideUMult, float OutsideVMult, float InsideVMult)
        {
            float r1 = OutsideRadius + OutsideAmplitude * Sin(OutsideFrequency * (OutsideUMult * u + OutsideVMult * v + t));
            float r2 = InsideRadius + InsideAmplitude * Sin(InsideFrequency * (InsideUMult * u + InsideVMult * v + t));
            float s = 0.5f + r1 + r2 * Cos(PI * v);
            return Torus(u, v, r1, r2);
        }

        /// <summary>
        /// Draw a sinusoidale wave
        /// </summary>
        /// <param name="u">u coordinate on the surface</param>
        /// <param name="v">v coordinate on the surface</param>
        /// <param name="t">time in sec</param>
        /// <param name="uMult">to orient wave in U direction</param>
        /// <param name="vMult">to orient wave in V direction</param>
        /// <param name="frequency"></param>
        /// <param name="amplitude"></param>
        /// <returns>new position for surfave point</returns>
        public static Vector3 Wave(float u, float v, float t, float uMult, float vMult, float frequency, float amplitude)
        {
            Vector3 p;
            p.x = u;
            p.y = Sin(frequency * (u * uMult + v * vMult + t)) * amplitude;
            p.z = v;
            return p;
        }

        #endregion Public Methods
    }
}
