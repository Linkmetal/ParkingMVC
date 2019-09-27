using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set;}
        public string password { get; set;}
        public string name { get; set;}
        public string surename { get; set;}
        public string email{ get; set;}
        public string phone{ get; set;}
        public string model{ get; set;}
        public string licensePlate { get; set;}
        public string image { get; set;}
    }
}
