using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ar306514_MIS.Models //NOTE: luce_MIS4200 is the name of the sample solution
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime graduationYear { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Course> Course { get; set; }
    }

    // TODO: Add constructor logic here
    //
    // add any other fields as appropriate
    // a customer can have any number of orders, a 1:M relationship,
    // We represent this in the model with an ICollection
    // The syntax says we are creating an ICollection of Order objects,
    // (the name inside the <> is the object name),
    // and the local name of the collection will be Order
    // (the object name and the local name do not have to be the same)

    public class Course
    {
        [Key]
        public int courseID { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection

        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int studentID { get; set; }
        public virtual Student Student { get; set; }

    }


}

