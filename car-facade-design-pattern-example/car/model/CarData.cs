using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.model
{
    public class CarData
    {
        private int _id;
        private String _color;
        private DateTime _lastMaintenanceDate;
        private List<CarModification> _carModifications;

        // Constructors

        public CarData(int id, String color, DateTime lastMaintenanceDate, List<CarModification> carModifications)
        {
            _id = id;
            _color = color;
            _lastMaintenanceDate = lastMaintenanceDate;
            _carModifications = carModifications;
        }

        public CarData(String text)
        {
            String[] data = text.Split('/');

            _id = Int32.Parse(data[0]);
            _color = data[1];
            _lastMaintenanceDate = DateTime.ParseExact(data[2], "DD.MM.YYYY", CultureInfo.InvariantCulture);

            _carModifications = new List<CarModification>();
            for(int i = 3; i < data.Length; i+=2)
            {
                _carModifications[_carModifications.Count()].Modification = data[i];
                _carModifications[_carModifications.Count()].Date = DateTime.ParseExact(data[i + 1], "DD.MM.YYYY", CultureInfo.InvariantCulture);
            }
        }

        // Accessors

        // Methods

        public override string ToString()
        {
            String desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Color : {_color}\n";
            desc += $"Last Maintenance Date : {_lastMaintenanceDate}\n";
            foreach(CarModification modification in _carModifications)
            {
                desc += $"Car Modification : {modification.Modification} - {modification.Date}\n";
            }

            return desc;
        }
    }
}
