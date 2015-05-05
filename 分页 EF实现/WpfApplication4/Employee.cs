using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication4
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string pk { get; set; }
        [Display(Name="名字")]
        public Int64 EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    } 
    [Table("User")]
    public class User
    {
        public enum TestENUM : long { A, B, C };

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        [StringLength(30), Display(Name = "名称")]
        public string Name { get; set; }

        public byte[] Data { get; set; }

        public double Val { get; set; }

        public DateTime Time { get; set; }
        public TestENUM TestE { get; set; }

    }
}
