using System;
using System.Collections;
using System.Collections.Generic;


public static class ScoreManager
{
    public static event Action<int> scoreChanged;

    private static int _score;

    public static int Score
    {
        get {return _score;}
        
        set
        {
            if (_score == value)
                return;
            _score = value;
            //Notify Score has been changed
            scoreChanged?.Invoke(_score);
        }
    }
}