using car_facade_design_pattern_example.car.logic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.model
{
    public class CarData : ICarData
    {
        ICarSaver _carSaver;
        IColorChanger _colorChanger;
        IMaintenanceReporter _maintenanceReporter;
        IModificationReporter _modificationReporter;
        private int _id;
        private String _color;
        private String _lastMaintenanceDate;
        private List<CarModification> _carModifications;

        // Constructors

        public CarData(int id, String color, String lastMaintenanceDate, List<CarModification> carModifications)
        {
            _id = id;
            _color = color;
            _lastMaintenanceDate = lastMaintenanceDate;
            _carModifications = carModifications;

            _carSaver = new CarSaver();
            _colorChanger = new ColorChanger();
            _maintenanceReporter = new MaintenanceReporter();
            _modificationReporter = new ModificationReporter();
        }

        public CarData(String text)
        {
            String[] data = text.Split("/");
            foreach(String s in data)
            {
                Console.WriteLine(s);
            }

            _id = Int32.Parse(data[0]);
            _color = data[1];
            _lastMaintenanceDate = data[2];

            _carModifications = new List<CarModification>();
            for(int i = 3; i < data.Count(); i+=2)
            {
                _carModifications.Add(new CarModification(data[i], data[i + 1]));
            }

            _carSaver = new CarSaver();
            _colorChanger = new ColorChanger();
            _maintenanceReporter = new MaintenanceReporter();
            _modificationReporter = new ModificationReporter();
        }

        // Accessors

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public String Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public String LastMaintenanceDate
        {
            get { return _lastMaintenanceDate; }
            set
            {
                _lastMaintenanceDate = value;
            }
        }

        public List<CarModification> CarModifications
        {
            get { return _carModifications; }
            set
            {
                _carModifications = value;
            }
        }

        // Methods
        
        public void SaveCar()
        {
            _carSaver.SaveCar(this);
        }

        public void ChangeColor()
        {
            _colorChanger.ChangeColor(out _color);
        }

        public void ReportMaintenance()
        {
            _maintenanceReporter.ReportMaintenance(out _lastMaintenanceDate);
        }

        public void ReportModification()
        {
            CarModification carModification;
            _modificationReporter.ReportModification(out carModification);
            _carModifications.Add(carModification);
        }

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

        public override bool Equals(object? obj)
        {
            return (obj as CarData)._id == _id && (obj as CarData)._color == _color && (obj as CarData)._lastMaintenanceDate == _lastMaintenanceDate && (obj as CarData)._carModifications == _carModifications;
        }
    }
}
