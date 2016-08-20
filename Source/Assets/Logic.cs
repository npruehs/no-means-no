using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    #region Fields

    private readonly float[] values = new float[3];

    public float[] IncreaseFactors = new float[3];

    public Text[] Texts = new Text[3];

    #endregion

    #region Methods

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            for (var i = 0; i < this.values.Length; ++i)
            {
                if (this.Texts.Length <= i || this.IncreaseFactors.Length <= i)
                {
                    continue;
                }

                // Increase by random value.
                this.values[i] += Random.value * this.IncreaseFactors[i] * Time.deltaTime;

                if (this.values[i] >= 100f)
                {
                    this.values[i] = 100f;
                }

                // Update UI.
                this.Texts[i].text = string.Format("{0:0.00} %", this.values[i]);
            }
        }
    }

    #endregion
}