using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.model
{
    public class CarModification
    {
        private String _modification;
        private String _date;

        // Constructors

        public CarModification(String modification, String date)
        {
            _modification = modification;
            _date = date;
        }

        // Accessors

        public String Modification
        {
            get { return _modification; }
            set
            {
                _modification = value;
            }
        }

        public String Date
        {
            get { return _date; }
            set
            {
                _date = value;
            }
        }

        // Methods

        public override string ToString()
        {
            String desc = "";

            desc += $"Modification : {_modification}\n";
            desc += $"Date : {_date}\n";

            return desc;
        }

        public override bool Equals(object? obj)
        {
            return (obj as CarModification)._modification == _modification && (obj as CarModification)._date == _date;
        }
    }
}
