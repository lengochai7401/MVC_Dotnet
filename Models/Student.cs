using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DotNet.Models;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int id { get; set; }
    [StringLength(100)]
    public String? name { get; set; }
    [StringLength(250)]
    public String? address { get; set; }

    
}
