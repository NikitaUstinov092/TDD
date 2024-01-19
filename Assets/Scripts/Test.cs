using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        
        Debug.Log($"arr1[0]: {arr1[0]}"); // Вывод: arr1[0]: 1
        Debug.Log($"arr2[0]: {arr2[0]}"); // Вывод: arr2[0]: 1
    
        arr2[0] = 10;
    
        Debug.Log($"arr1[0] после изменения arr2: {arr1[0]}"); // Вывод: arr1[0] после изменения arr2: 10
        Debug.Log($"arr2[0] после изменения arr2: {arr2[0]}"); // Вывод: arr2[0] после изменения arr2: 10
    }
    
    // void Start()
    // {
    //     int a = 5;
    //     int b = a;
    //
    //     Debug.Log($"Значение a: {a}"); // Вывод: Значение a: 5
    //     Debug.Log($"Значение b: {b}"); // Вывод: Значение b: 5
    //
    //     b = 10;
    //
    //     Debug.Log($"Значение a после изменения b: {a}"); // Вывод: Значение a после изменения b: 5
    //     Debug.Log($"Новое значение b: {b}"); // Вывод: Новое значение b: 10
    // }
    
    
     
    
}
