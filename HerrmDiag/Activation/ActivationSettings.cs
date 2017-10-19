using System;

namespace HerrmDiag.Activation
{
    [Serializable]
    public class ActivationSettings
    {
        public DateTime ActivationTime { get; set; }
        public string GenerationCode { get; set; }
        public bool ValidActivation
        {
            get { return this.ActivationTime <= DateTime.Now; }
        }
        public ActivationSettings(string generationCode, DateTime time)
        {
            this.GenerationCode = generationCode;
            this.ActivationTime = time;
        }
    }
}
