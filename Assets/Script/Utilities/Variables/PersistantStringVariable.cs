using UnityEngine;

namespace Interactive.Utilities.Variables
{
    [CreateAssetMenu(menuName = "Variables/Persistant String")]
    public class PersistantStringVariable : StringVariable
    {
        [SerializeField]
        public string PersistanceKey;

        public override void OnEnable()
        {
            if (string.IsNullOrEmpty(PersistanceKey))
            {
                PersistanceKey = name;
            }
            Value = PlayerPrefs.GetString(PersistanceKey, defaultValue);
        }

        public void OnDisable()
        {
            PlayerPrefs.SetString(PersistanceKey, Value);
        }
    }
}