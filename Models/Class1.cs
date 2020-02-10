using System;

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
        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}

 public class orderDetail
{
    public int coursedetailID { get; set; }
    public int  { get; set; }
    public decimal price { get; set; }
    // the next two properties link the orderDetail to the Order
    public int orderID { get; set; }
    public virtual Order Order { get; set; }
    // the next two properties link the orderDetail to the Product
    public int productID { get; set; }
    public virtual Product Product { get; set; }
}
