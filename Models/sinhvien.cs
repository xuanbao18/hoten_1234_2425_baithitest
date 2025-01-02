using System.ComponentModel.DataAnnotations;

namespace hoten_1234_2425_baithitest;

public class sinhvien
{
    public string hoten { get; set; }
    [Key]
    public string mssv { get; set; }
}
