
using AppointmentCRUD;
using EmployeeCRUD.Classes;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeCRUD
{
    class Program
    {
        Context db = new Context();
        static void Main(string[] args)
        {
            Program p = new Program();
            string? x;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter C to Create an Appointment");
                Console.WriteLine("Enter A to GetAll Appointment");
                Console.WriteLine("Enter R to GetSingle Appointment");
                Console.WriteLine("Enter U to Update Appointment");
                Console.WriteLine("Enter D to Delete anAppointment");

                string? input = Console.ReadLine();

                if (input == "C")
                {
                    p.Create();
                }

                else if (input == "A")
                {
                    p.GetAll();
                }

                else if (input == "R")
                {
                    p.GetSingle();
                }

                else if (input == "U")
                {
                    p.Update();
                }

                else if (input == "D")
                {
                    p.Delete();
                }

                Console.WriteLine("Enter Y if you want to continue\n Enter N if you want to skip");
                x = Console.ReadLine();
            } while (x == "Y");

        }



        public void GetAll()
        {
            //List Functionality
            var data = db.appointments?.ToList();
            foreach (var item in data)
            {
                
                Console.WriteLine("Registration Id " +item.RegId);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("CNIC : " + item.CNIC);
                Console.WriteLine("Contact No.: " + item.ContactNo);
                Console.WriteLine("Email ID: " + item.Email);
                Console.WriteLine("Password: " + item.Password);
                Console.WriteLine("Confirm Password: " + item.CPassword);
            }
        }


        public void Create()
        {
            Console.Clear();//FOR Clear screen
            //Insert Functionality
            Appointment ap = new Appointment();

            Console.Write("Enter Registration ID:");
            ap.RegId=Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter Name:");
            ap.Name = Console.ReadLine();
            Console.Write("Enter CNIC:");
            ap.CNIC = Console.ReadLine();
            Console.Write("Enter Employee Contact No:");
            ap.ContactNo = Console.ReadLine();
            Console.Write("Enter Email Address:");
            ap.Email = Console.ReadLine();
            Console.Write("Enter Password:");
            ap.Password = Console.ReadLine();
            Console.Write("Enter Confirm Password:");
            ap.CPassword = Console.ReadLine();


            // Command to Add Data
            db.appointments?.Add(ap);
            _ = -db.SaveChanges();  //Command to Save Data
        }


        public void Update()
        {
            Console.Write("Enter RegistrationId to Update");
            int regId = Convert.ToInt32(Console.ReadLine());

            //Get-Single Record
            var row = db.appointments?.Where(x => x.RegId == regId).FirstOrDefault();
            Console.WriteLine("Registration Id " + row.RegId);
            Console.WriteLine("Name : " + row.Name);
            Console.WriteLine("CNIC : " + row.CNIC);
            Console.WriteLine("Contact No.: " + row.ContactNo);
            Console.WriteLine("Email ID: " + row.Email);
            Console.WriteLine("Password: " + row.Password);
            Console.WriteLine("Confirm Password: " + row.CPassword);

            //Update Functionality
            Appointment ap = new Appointment();

            Console.Write("Enter Name:");
            ap.Name = Console.ReadLine();
            Console.Write("Enter CNIC:");
            ap.CNIC = Console.ReadLine();
            Console.Write("Enter Contact No:");
            ap.ContactNo = Console.ReadLine();
            Console.Write("Enter Email ID:");
            ap.Email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            ap.Password = Console.ReadLine();
            Console.WriteLine("Enter Confirm Password:");
            ap.CPassword = Console.ReadLine();




            // Command to Update Data
            _ = db.appointments?.Update(ap);
            db.SaveChanges();  //Command to Save Data
        }


        public void Delete()
        {
            Console.WriteLine("Enter Registration Id to Delete");
            int regId = Convert.ToInt32(Console.ReadLine());



            //Get-Single Record
            var row = db.appointments?.Where(x => x.RegId == regId).FirstOrDefault();
            Console.WriteLine("Registration Id " + row.RegId);
            Console.WriteLine("Name : " + row.Name);
            Console.WriteLine("CNIC : " + row.CNIC);
            Console.WriteLine("Contact No.: " + row.ContactNo);
            Console.WriteLine("Email ID: " + row.Email);
            Console.WriteLine("Password: " + row.Password);
            Console.WriteLine("Confirm Password: " + row.CPassword);

            // Command to Remove Data
            _ = db.appointments?.Remove(row);
            db.SaveChanges();  //Command to Save Data
        }


        public void GetSingle()
        {
            Console.WriteLine("Enter Id to for get single record:");
            int regId = Convert.ToInt32(Console.ReadLine());


            //Get-Single Record Code
            var row = db.appointments?.Where(x => x.RegId == regId).FirstOrDefault();
            Console.WriteLine("Registration Id " + row.RegId);
            Console.WriteLine("Name : " + row.Name);
            Console.WriteLine("CNIC : " + row.CNIC);
            Console.WriteLine("Contact No.: " + row.ContactNo);
            Console.WriteLine("Email ID: " + row.Email);
            Console.WriteLine("Password: " + row.Password);
            Console.WriteLine("Confirm Password: " + row.CPassword);
        }
    }
}
