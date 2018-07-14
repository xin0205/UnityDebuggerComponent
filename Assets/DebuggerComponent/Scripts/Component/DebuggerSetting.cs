using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebuggerSetting {

    public static void SetBool(string key, bool value) {
        PlayerPrefs.SetInt(key, value ? 1 : 0);
    }
    public static bool GetBool(string key, bool defaultValue)
    {

        return PlayerPrefs.GetInt(key, defaultValue ? 1 : 0) != 0;
    }

    public static bool GetBool(string key) {

        return PlayerPrefs.GetInt(key) != 0;
    }

    public static int GetInt(string settingName)
    {
        return PlayerPrefs.GetInt(settingName);
    }

    public static int GetInt(string settingName, int defaultValue)
    {
        return PlayerPrefs.GetInt(settingName, defaultValue);
    }

    public static void SetInt(string settingName, int value)
    {
        PlayerPrefs.SetInt(settingName, value);
    }

    public static float GetFloat(string settingName)
    {
        return PlayerPrefs.GetFloat(settingName);
    }

    public static float GetFloat(string settingName, float defaultValue)
    {
        return PlayerPrefs.GetFloat(settingName, defaultValue);
    }

    public static void SetFloat(string settingName, float value)
    {
        PlayerPrefs.SetFloat(settingName, value);
    }

    public static string GetString(string settingName)
    {
        return PlayerPrefs.GetString(settingName);
    }

    public static string GetString(string settingName, string defaultValue)
    {
        return PlayerPrefs.GetString(settingName, defaultValue);
    }

    public static void SetString(string settingName, string value)
    {
        PlayerPrefs.SetString(settingName, value);
    }




}
