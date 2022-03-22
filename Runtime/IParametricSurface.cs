using UnityEngine;

namespace IdaelLib.ParametricSurfaces
{
    public interface IParametricSurface
    {
        #region Public Methods

        /// <summary>
        /// Return the position aloing the parametric surface function
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="t">time</param>
        /// <returns></returns>
        Vector3 GetPosition(float u, float v, float t);

        #endregion Public Methods
    }
}
