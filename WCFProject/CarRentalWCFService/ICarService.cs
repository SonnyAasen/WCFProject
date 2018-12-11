﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void RemoveCar(string RegNr);

        [OperationContract]
        void AddCar(Car car);

        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void RemoveCustomer(Customer customer);

        [OperationContract]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        void CreateBooking(Booking booking);

        [OperationContract]
        void RemoveBooking(Booking booking);
    }
}
