# SaveLoadSystem-Unity
To save - you need to initialize ISaveSystem _saveSys = new JsonSaveSystem(); Call _saveSys.Save(SaveData _myData);
  _myData = new SaveData()
  {
      ResetStartValidPoints = DepthData.ResetStartValidPoints,
      Size = DepthData.Size
  };
