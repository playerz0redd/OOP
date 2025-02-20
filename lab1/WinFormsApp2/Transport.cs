using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class Transport
    {
        public string pictureURL;

        public Transport()
        {
            pictureURL = "C:\\transport-images\\transport.jpg";
        }
    }

    class Plane : Transport
    {
        public Plane()
        {
            pictureURL = "C:\\transport-images\\plane.jpg";
        }
    }

    class Car : Transport
    {
        public Car()
        {
            pictureURL = "C:\\transport-images\\car.jpg";
        }
    }

    class PassengerPlane : Plane
    {
        public PassengerPlane()
        {
            pictureURL = "C:\\transport-images\\pass-plane.jpg";
        }
    }

    class CargoPlane : Plane
    {
        public CargoPlane()
        {
            pictureURL = "C:\\transport-images\\cargo-plane.jpg";
        }
    } 

    class SportCar : Car
    {
        public SportCar()
        {
            pictureURL = "C:\\transport-images\\sport-car.jpg";
        }
    }

    class Truck : Car
    {
        public Truck()
        {
            pictureURL = "C:\\transport-images\\truck.jpg";
        }
    }
}
