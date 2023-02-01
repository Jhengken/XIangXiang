using XiangXiang.Models;

namespace XiangXiang.VIewModels
{
    public class TAdvertiseViewModel
    {
        private TAdvertise _advertise;
        public TAdvertise advertise
        {
            get { return _advertise; }
            set { _advertise = value; }
        }
        public TAdvertiseViewModel() 
        {
            _advertise= new TAdvertise();
        }
        public int AdvertiseId { get { return _advertise.AdvertiseId; } set { _advertise.AdvertiseId = value; } }
        public string Name { get { return _advertise.Name; } set { _advertise.Name = value; } }
        public decimal? DatePrice { get { return _advertise.DatePrice; } set { _advertise.DatePrice = value; } }

        public virtual ICollection<TAorder> TAorders { get { return _advertise.TAorders; } set { _advertise.TAorders = value; } }
    }
}
