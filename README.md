# SaveLoadSystem-Unity

To Save - you need to initialize 
```cs 
ISaveSystem _saveSys = new JsonSaveSystem();
_saveSys.Save(SaveData _myData);
```

![image](https://user-images.githubusercontent.com/62687243/162177141-559ff905-a3b0-4e54-b151-abaf24115ece.png)


To Load you need to initialize 
```cs
ISaveSystem _saveSys = new JsonSaveSystem(); 
Call SaveData _myData = _saveSys.Load();
```
