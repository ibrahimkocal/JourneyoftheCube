using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseConnection : MonoBehaviour
{
    void Start()
    {
        // Database ba�lant�s�n�n yap�laca�� yer
        // Ard�ndan add value yi sql kodlar� ile de�i�tir
    }

    public static bool AddValue(string Key, int value)
    {
        try
        {
            PlayerPrefs.SetInt(Key, value);
            return true;
        }
        catch
        {
            return false;
        }

    }
    public static bool AddValue(string Key, string value)
    {
        try
        {
            PlayerPrefs.SetString(Key, value);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static bool AddValue(string Key, float value)
    {

        try
        {
            PlayerPrefs.SetFloat(Key, value);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static int GetValueINT(string Key)
    {

        try
        {
            return PlayerPrefs.GetInt(Key);
        }
        catch
        {
            return -1;
        }
    }
    public static float GetValueFloat(string Key)
    {

        try
        {
            return PlayerPrefs.GetInt(Key);
        }
        catch
        {
            return -1;
        }
    }
    public static string GetValueString(string Key)
    {

        try
        {
            return PlayerPrefs.GetString(Key);
        }
        catch
        {
            return "Empty";
        }
    }

    public static bool AddAccount(string Username, string password)
    {

        try
        {
            PlayerPrefs.SetString("username", Username);
            PlayerPrefs.SetString("password", password);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static string[] GetAccount()
    {
        try
        {
            string _Username = PlayerPrefs.GetString("username");
            string _Password = PlayerPrefs.GetString("password");
            string[] acc = { _Username, _Password };
            return acc;
        }
        catch
        {
            string[] acc = { "hata", "Hata" };
            return acc;
        }
    }
}
