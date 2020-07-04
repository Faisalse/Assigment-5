using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InstantiationPrefab : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public Text text;
    public GameObject myPrefab;
    string[] randomStringList;
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;
    public TextMesh text4;
    public TextMesh text5;
    public TextMesh text6;
    public TextMesh text7;
    public TextMesh text8;
    public TextMesh text9;
    public TextMesh text10;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
    
     
        randomStringList = stringlist();
       // OnCollisionEnter();


    }

    void OnCollisio()
    {
        text1.text = randomStringList[0];
        text2.text = randomStringList[1];
        text3.text = randomStringList[2];
        text4.text = randomStringList[3];
        text5.text = randomStringList[4];
        text6.text = randomStringList[5];
        text7.text = randomStringList[6];
        text8.text = randomStringList[7];
        text9.text = randomStringList[8];
        text10.text = randomStringList[9];
        GameObject ab =  Instantiate(myPrefab, new Vector3(7, 0.5f, 3), Quaternion.identity);      
        Instantiate(myPrefab, new Vector3(7, 0.5f, 0), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(7, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(3, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-2, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-5, 0.5f, -2), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, 0), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(1, 0.5f, 3), Quaternion.identity);
        Destroy(ab);
    }

    // function to Generate a coupon
    public static string GenerateCoupon(int length, System.Random random)
    {
        string characters = "3FX";
        StringBuilder result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }

    static string[] stringlist()
    {
        System.Random rnd = new System.Random();
        string[] coupon = new string[10];
        for (int i = 0; i < coupon.Length; i++)
        {
            string a = GenerateCoupon(5, rnd);
            if (i < 3)
            {
                int j = a.Length - 1;
                while (j >= 0)
                {
                    a = String.Concat(a, a[j]);
                    j--;
                }
                coupon[i] = a;
            }
            else
            {
                a = String.Concat(a, a);
                coupon[i] = a;
            }
            //coupon[i] = a;
        }
        return coupon;
    }

}
