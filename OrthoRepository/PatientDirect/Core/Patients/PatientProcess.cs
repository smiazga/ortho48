using ortho48.OrthoRepository.PatientDirect.Core.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ortho48.OrthoRepository.PatientDirect.Core.Patients
{
    public class PatientProcess
    {
        private static readonly List<PatientInfo> AllPatients = new List<PatientInfo>()
            {
                new PatientInfo { CustomerId=1,PatientInitials="JD",PatientName="John Doe",PatientEmail="j.doe@test.com",DateRegistered="Jan 2nd 2025",OrdersCount=3,SubscriptionsCount=3  },
                new PatientInfo { CustomerId=2,PatientInitials="MB",PatientName="Mike Brown",PatientEmail="m.brown@test.com",DateRegistered="Jan 3rd 2025",OrdersCount=1,SubscriptionsCount=2  },
                new PatientInfo { CustomerId=3,PatientInitials="SS",PatientName="Steve Smith",PatientEmail="s.smith@test.com",DateRegistered="Fed 4th 2025",OrdersCount=2,SubscriptionsCount=1  },
             };

        private static readonly List<PatientDetails> AllPatientDetails = new List<PatientDetails>()
            {
                new PatientDetails { CustomerId = 1, FirstName="John", LastName="Doe", Email="j.doe@test.com",Phone="+1 (908) 172 6354" },
                new PatientDetails { CustomerId = 2, FirstName="Mike", LastName="Brown", Email="m.brown@test.com",Phone= "+1 (847) 234 5263" },
                new PatientDetails { CustomerId = 3, FirstName="Steve", LastName="Smith", Email="s.smith@test.com",Phone= "+1 (951) 878 3210" },
            };

        private static readonly List<Order> AllOrders = new List<Order>()
            {
                new Order { OrderId=1,CustomerId=1,OrderDate=new DateTime(2025, 1, 2),OrderTotal=3.25m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=2,Price=10.25m},
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/151240.tmb-thumb190.png?Culture=en&sfvrsn=9f536c33_7", ProductName = "Alpha Base Capsules w/ Iron", Size="40 Capsules",OrderQuantity=3,Price=8.25m},
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/546060.tmb-thumb190.png?Culture=en&sfvrsn=46e6c73f_7", ProductName = "Cardio B", Size="20 Capsules",OrderQuantity=4,Price=18.25m},
                    },
                },
                new Order { OrderId=2,CustomerId=1,OrderDate=new DateTime(2025, 1, 3),OrderTotal=8.50m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 2, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=3,Price=13.25m},
                        new OrderLine { OrderId = 2, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/151240.tmb-thumb190.png?Culture=en&sfvrsn=9f536c33_7", ProductName = "Alpha Base Capsules w/ Iron", Size="40 Capsules",OrderQuantity=2,Price=4.25m},
                    },
                },
                new Order { OrderId=3,CustomerId=1,OrderDate=new DateTime(2025, 2, 4),OrderTotal=4.25m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 3, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=2,Price=10.25m},
                    },
                },
            };

        private static readonly List<Subscription> AllSubscriptions = new List<Subscription>()
            {
                new Subscription { ShipmentOrderId =1, CustomerId = 1, NextOrderDate=new DateTime(2025,2,2),Frequency="Monthly",OrderTotal=3.25m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=2,Price=10.25m},
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/151240.tmb-thumb190.png?Culture=en&sfvrsn=9f536c33_7", ProductName = "Alpha Base Capsules w/ Iron", Size="40 Capsules",OrderQuantity=3,Price=8.25m},
                        new OrderLine { OrderId = 1, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/546060.tmb-thumb190.png?Culture=en&sfvrsn=46e6c73f_7", ProductName = "Cardio B", Size="20 Capsules",OrderQuantity=4,Price=18.25m},
                    },
                },
                new Subscription { ShipmentOrderId = 2, CustomerId = 1, NextOrderDate=new DateTime(2025,2,3),Frequency="Monthly",OrderTotal=4.25m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 2, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=3,Price=13.25m},
                        new OrderLine { OrderId = 2, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/151240.tmb-thumb190.png?Culture=en&sfvrsn=9f536c33_7", ProductName = "Alpha Base Capsules w/ Iron", Size="40 Capsules",OrderQuantity=2,Price=4.25m},
                    },
                },
                new Subscription { ShipmentOrderId =3, CustomerId = 1, NextOrderDate=new DateTime(2025,3,4),Frequency="Monthly",OrderTotal=2.25m,
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine { OrderId = 3, ProductUrl="https://preprod.orthopacks.com/images/default-source/products/557120.tmb-thumb190.png?Culture=en&sfvrsn=3b3dc36d_7", ProductName = "4Sight", Size="60 Capsules",OrderQuantity=2,Price=10.25m},
                    },
                },
            };


        public List<PatientInfo> GetAllPatientInfo()
        {
            return AllPatients;
        }

        public PatientDetails GetPatientDetails(int customerId)
        {
            return AllPatientDetails.Find(p => p.CustomerId == customerId);
        }

        public List<Order> GetOrdersByPatient(int customerId)
        {
            var orders = AllOrders.FindAll(o => o.CustomerId == customerId);
            orders.ForEach(x => x.OrderProducts = string.Join(", ", x.OrderLines.Select(y => y.ProductName).Distinct()));
            return orders;
        }

        public List<Subscription> GetSubscriptionsByPatient(int customerId)
        {
            var orders = AllSubscriptions.FindAll(o => o.CustomerId == customerId);
            orders.ForEach(x => x.OrderProducts = string.Join(", ", x.OrderLines.Select(y => y.ProductName).Distinct()));
            return orders;
        }

        public void UpdatePatientDetails(int customerId, PatientDetails patientDetails)
        {
            var patient = AllPatientDetails.Find(p => p.CustomerId == customerId);
            if (patient != null)
            {
                patient.FirstName = patientDetails.FirstName;
                patient.LastName = patientDetails.LastName;
                patient.Email = patientDetails.Email;
                patient.Phone = patientDetails.Phone;
            }
        }
    }
}