/// <summary>
/// Represents a utility class for vector math operations.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The vector to calculate the magnitude of.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector){
        int dimensions = vector.Length;
        if (dimensions != 2 && dimensions != 3) 
        {
            return -1; 
        }

        double magnitudeSquared = 0;
        for (int i = 0; i < dimensions; i++)
        {
            magnitudeSquared += vector[i] * vector[i];
        }

        double magnitude = Math.Sqrt(magnitudeSquared);
        return Math.Round(magnitude, 2);
    }
}
