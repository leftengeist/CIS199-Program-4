//N5284
//Program 4
//April 30, 2019
//CIS 199-75
//Program creates and displays multiple packages to be shiped, using a GroundPackage class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class GroundPackage
    {
        private const int MIN_ZIP = 00000;              // Minimum zipcode value
        private const int MAX_ZIP = 99999;              // Maximum zipcode value
        private const int DEFAULT_ORIGIN = 40202;       // Default value for the origin zipcode
        private const int DEFAULT_DESTINATION = 90210;  // Default value for the destination zipcode
        private const int ZONE_CONVERSION = 10000;      // Get the zone from the zip code

        private const double MIN_VALUE = 0.0;           // Minimum value for length, width, height, and weight
        private const double DEFAULT_VALUE = 1.0;       // Default value for length, width, height, and weight

        private int _originZip;                         // Original zip backing field
        private int _destinationZip;                    // Destination zip backing field

        private double _length;                         // Length backing field
        private double _width;                          // Width backing field
        private double _height;                         // Height backing field
        private double _weight;                         // Weight backing field

        // Precondition:  00000 <= OriginZip      <= 99999 
        //                00000 <= DestinationZip <= 99999 
        //                  0.0 <= Length
        //                  0.0 <= Width
        //                  0.0 <= Height
        //                  0.0 <= Weight
        // Postcondition: Ground Package is initialized with set origin zip, destination zip, length, width, height, and weight
        public GroundPackage(int origin = DEFAULT_ORIGIN, int dest = DEFAULT_DESTINATION, double l = DEFAULT_VALUE, double w = DEFAULT_VALUE, double h = DEFAULT_VALUE, double lbs = DEFAULT_VALUE)
        {
            OriginZip = origin;
            DestinationZip = dest;
            Length = l;
            Width = w;
            Height = h;
            Weight = lbs;
        }

        public int OriginZip
        {
            // Precondition:  None
            // Postcondition: Origin zip is returned
            get
            {
                return _originZip;
            }

            // Precondition:  00000 <= value <= 99999
            // Postcondition: Origin zip is set
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _originZip = value;
                else
                    _originZip = DEFAULT_ORIGIN;
            }
        }

        public int DestinationZip
        {
            // Precondition:  None
            // Postcondition: Destination zip is returned
            get
            {
                return _destinationZip;
            }

            // Precondition:  00000 <= value <= 99999
            // Postcondition: Destination zip is set
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _destinationZip = value;
                else
                    _destinationZip = DEFAULT_DESTINATION;
            }
        }

        public double Length
        {
            // Precondition:  None
            // Postcondition: Length is returned
            get
            {
                return _length;
            }

            // Precondition:  0.0 <= value
            // Postcondition: Length is set
            set
            {
                if (value >= MIN_VALUE)
                    _length = value;
                else
                    _length = DEFAULT_VALUE;
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: Width is returned
            get
            {
                return _width;
            }

            // Precondition:  0.0 <= value
            // Postcondition: Width is set
            set
            {
                if (value >= MIN_VALUE)
                    _width = value;
                else
                    _width = DEFAULT_VALUE;
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: Height is returned
            get
            {
                return _height;
            }

            // Precondition:  0.0 <= value
            // Postcondition: Height is set
            set
            {
                if (value >= MIN_VALUE)
                    _height = value;
                else
                    _height = DEFAULT_VALUE;
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: Weight is returned
            get
            {
                return _weight;
            }

            // Precondition:  0.0 <= value
            // Postcondition: Weight is set
            set
            {
                if (value >= MIN_VALUE)
                    _weight = value;
                else
                    _weight = DEFAULT_VALUE;
            }
        }

        public int ZoneDistance
        {
            // Precondition: Destination and Origin zip codes
            // Postcondition: Returns the distance between the origin and destination zip codes
            get
            {
                return Math.Abs((DestinationZip/ZONE_CONVERSION)-(OriginZip/ZONE_CONVERSION));
            }
        }

        // Precondition:  None
        // Postcondition: The cost for a package is calculated and returned
        public double CalcCost()
        {
            const double SIZE_COST_FACTOR = 0.25;   // Cost for size
            const double WEIGHT_COST_FACTOR = 0.45; // Cost for weight

            return SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * (Weight);
        }

        // Precondition:  None
        // Postcondition: A string holding package information is formated and returned
        public override string ToString()
        {
            return $"Origin Zip: {OriginZip:D5}" + Environment.NewLine +
                   $"Destination Zip: {DestinationZip:D5}" + Environment.NewLine +
                   $"Length: {Length:F1}" + Environment.NewLine +
                   $"Width: {Width:F1}" + Environment.NewLine +
                   $"Height: {Height:F1}" + Environment.NewLine +
                   $"Weight: {Weight:F1}";
        }
    }
}
