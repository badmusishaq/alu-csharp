﻿using System;

/// <summary>
/// Utility class for Matrix Math.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">Matrix 1</param>
    /// <param name="matrix2">Matrix 2</param>
    /// <returns>returns the new matrix</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        if (matrix1.Length == 0 ||
            matrix2.Length == 0 ||
            matrix1.GetLength(1) != matrix2.GetLength(0)){
            return (new double[,]{{-1}});
        }

        double[,] tempResult = new double[matrix1.GetLength(0),matrix2.GetLength(1)];
        double result = 0.0;
        for (int y = 0; y < matrix1.GetLength(0); y++){
            for (int x2 = 0; x2 < matrix2.GetLength(1); x2++){
                result = 0;
                for (int x = 0; x < matrix1.GetLength(1); x++){
                    result += matrix1[y,x] * matrix2[x, x2];
                }
                tempResult[y, x2] = result;
            }
        }
        return tempResult;  
    }
}