using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Messager
{
    public static string save = "0000000000";

    public static void SetLevelCompleted(int _levelID)
    {
        save = save.Remove(_levelID, 1);
        save = save.Insert(_levelID, "1");
    }
}
