using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }

        public Project(string client, string description, long id, string image, string name)
        {
            Id = id;
            Name = name;
            Client = client;
            Description = description;
            Image = image;
           
        }
    }
}
