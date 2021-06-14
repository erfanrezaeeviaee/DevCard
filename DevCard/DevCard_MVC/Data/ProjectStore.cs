using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
       public static List<Project> GetProjects()
       {
           return new List<Project>
           {
               new Project("مشتری یکم", "این پروژه برای مشتری اول ایجاد شده است.", 1, "project-1.jpg", "پروژه یکم"),
               new Project("مشتری دوم", "این پروژه برای مشتری دوم ایجاد شده است.", 2, "project-2.jpg", "پروژه دوم"),
               new Project("مشتری سوم", "این پروژه برای مشتری سوم ایجاد شده است.", 3, "project-3.jpg", "پروژه سوم"),
               new Project("مشتری چهارم", "این پروژه برای مشتری چهارم ایجاد شده است.", 4, "project-4.jpg",
                   "پروژه چهارم"),
           };
       }

       public static Project GetProjectBy(long id)
       {
           return GetProjects().FirstOrDefault(x => x.Id == id);
       }
    }
}
