using System;

/// <summary>
/// Represents a utility class for vector math operations.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two 2D or 3D vectors.
    /// </summary>
    /// <param name="vector1">The first vector to add.</param>
    /// <param name="vector2">The second vector to add.</param>
    /// <returns>The resulting vector after adding vector1 and vector2, or a vector containing -1 if either vector is not 2D or 3D, or if the vectors are not of the same size.</returns>
    public static double[] Add(double[] vector1, double[] vector2){
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;

        if (dimensions1 != dimensions2 || (dimensions1 != 2 && dimensions1 != 3))
        {
            return new double[] { -1 };
        }

        double[] result = new double[dimensions1];

        for (int i = 0; i < dimensions1; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
