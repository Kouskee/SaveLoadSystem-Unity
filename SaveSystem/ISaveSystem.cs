using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveSystem
{
    public void Save(SaveData data);
    public SaveData Load();
}
