using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmaneger : MonoBehaviour
{
    [SerializeField]
    levels[] levels1;

    public levels GetLevel(int levelsIndex)
    {
        return levels1[levelsIndex];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    public class levels
    {
        public string Name;

        public int Level;

       public levels(string _name,int _level)
        {
            Name = _name;
            Level = _level; 
        } 
    }
}
