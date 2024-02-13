using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCode : MonoBehaviour
{
    [SerializeField]
    int[][] scoresArr = new int[4][];

    [SerializeField]
    int[,] scoresArr2 = new int[3,3];

    [ContextMenu("Execute Test")]
    void Execute()
    {
        scoresArr[0] = new int[4] { 1,2,3,4};
        scoresArr[1] = new int[4] { 5,6,7,8};
        scoresArr[2] = new int[4] { 9,10,11,12};
        scoresArr[3] = new int[4] { 13,14,15,16};
        for (int i = 0; i < scoresArr.Length; i++) 
        {
            for (int j = 0; j < scoresArr[i].Length; j++)
            {
                Debug.LogFormat("The number is... {0} tadums!", scoresArr[i][j]);
            }
            
        }

        int numberOfRows = scoresArr.GetLength(0);
        int numberOfCols = scoresArr.GetLength(1);

        for (int i = 0; i < numberOfCols; i++) 
        {
            for (int j = 0; j < numberOfCols; j++)
            {
                Debug.LogFormat("The number is... {0} tadums!", scoresArr2[i, j]);
            }
        }
    }
}
