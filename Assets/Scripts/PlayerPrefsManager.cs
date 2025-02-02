﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";


	public static void SetMasterVolume(float volume)
    {
        if (volume>0f && volume < 1f) { PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume); }
        else                          { Debug.LogError("master volume out of range");    }
    }

    public static float GetMasterVolume() {return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);}

    public static void UnlockLevel(int level)
    {
        if (level <= Application.levelCount - 1) { PlayerPrefs.SetInt(LEVEL_KEY + level, 1); }
        else                                     { Debug.LogError("level key out of range"); }
    }

    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isLevelUnlocked = (levelValue == 1);

        if (level <= Application.levelCount - 1) {return isLevelUnlocked;}
        else
        {
            Debug.LogError("level key out of range");
            return false;
        }
    }

    public static void setDifficulty(float difficulty)
    {
        if (difficulty >= 1f && difficulty <= 3f) { PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty); }
        else                                      { Debug.LogError("difficulty not in range");        }
    }

    public static float getDifficulty() { return PlayerPrefs.GetFloat(DIFFICULTY_KEY); }
}
