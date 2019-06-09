using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IAssetLoader{

    T LoadAsset<T>(string path) where T : class;

    IEnumerator LoadAssetAsync<T>(string path,UnityAction<T> callback) where T:class;
	
}
