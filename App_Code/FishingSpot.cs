using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FishingSpots
{
    public class FishingSpot : ObservableCollection<FishingSpot>
    {
        private string _name;
        private string _county;
        private string _latitude;
        private string _longitude;
        private string _fishSpec;
        private int _id;

        public FishingSpot(string name, string county, string latitude, string longitude, string fishSpec, int id)
        {
            _name = name;
            _county = county;
            _longitude = longitude;
            _latitude = latitude;
            _fishSpec = fishSpec;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        public string County
        {
            get { return _county; }
            set { this._county = value; }
        }

        public string Latitude
        {
            get { return _latitude; }
            set { this._latitude = value; }
        }

        public string Longitude
        {
            get { return _longitude; }
            set { this._longitude = value; }
        }

        public string FishSpec
        {
            get { return _fishSpec; }
            set { this._fishSpec = value; }
        }

        public int id
        {
            get { return _id; }
            set { this._id = value; }
        }
    }

}
