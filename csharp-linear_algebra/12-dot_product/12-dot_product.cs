using System;

/// <summary>
/// Represents a utility class for vector math operations.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The dot product of vector1 and vector2, or -1 if either vector is not 2D or 3D, or both vectors are not the same size.</returns>
    public static double DotProduct(double[] vector1, double[] vector2){
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;

        if (dimensions1 != dimensions2 || (dimensions1 != 2 && dimensions1 != 3))
        {
            return -1;
        }

        double dotProduct = 0;

        for (int i = 0; i < dimensions1; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
