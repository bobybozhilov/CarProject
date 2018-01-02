using System;
using System.Collections.Generic;

namespace CSharp7_In_A_Nutshell
{
    public class OilSystem
    {
        private int _nextOilChange = 0;
        public List<OilType> OilTypes { get; set; }
        public double Quantity { get; set; }
        public int OilChangeInterval { get; set; }
        public int NextOilChange
        {
            get { return _nextOilChange; }
            set
            {

                if (value == _nextOilChange)
                {
                    return;
                }
                var currentOilChangeInterval = NextOilChange;
                _nextOilChange = value;
                OnOilChanged(new OilChangeEventArgs(currentOilChangeInterval, _nextOilChange));
            }
        }

        public void ChangeOil(int mileage)
        {
            if (mileage + OilChangeInterval == NextOilChange)
            {
                return;
            }
            NextOilChange = mileage + OilChangeInterval;

        }
        public event EventHandler<OilChangeEventArgs> OilChanged;
        public virtual void OnOilChanged(OilChangeEventArgs e)
        {
            OilChanged?.Invoke(this, e);
        }
    }
    public class OilChangeEventArgs : EventArgs
    {
        public readonly int NextOilChange;
        public readonly int CurrentOilChange;
        public OilChangeEventArgs(int currentOilChange, int nextOilChange)
        {
            CurrentOilChange = currentOilChange;
            NextOilChange = nextOilChange;
        }
    }
    public enum OilType
    {
        Oil_0W30_Petrol,
        Oil_0W30_Diesel,
        Oil_0W30_Lpg,
        Oil_0W40_Petrol,
        Oil_0W40_Diesel,
        Oil_0W40_Lpg,

    }
}