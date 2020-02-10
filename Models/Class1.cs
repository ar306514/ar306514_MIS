using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Class1
/// </summary>
namespace risner_MIS4200.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseGrade> CourseGrade { get; set; }
    }
}

 public class CourseGrade
{
    public int coursedetailID { get; set; }
    public decimal grade { get; set; }
    // the next two properties link the orderDetail to the Order
    public int courseID { get; set; }
    public virtual Course Course { get; set; }
    // the next two properties link the orderDetail to the Product
    public int professorID { get; set; }
    public virtual Professor Professor { get; set; }
}
