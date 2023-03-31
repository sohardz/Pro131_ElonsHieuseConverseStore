using System.ComponentModel.DataAnnotations;

namespace _2.BUS.ViewModels;

public class CustomerView
{
    public string Ma { get; set; }
    [Required(ErrorMessage = "Phải nhập Tên"), RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho Tên")]
    public string FirstName { get; set; }
    [RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho tên đệm")]
    public string MiddleName { get; set; }
    [Required(ErrorMessage = "Phải nhập Họ"),
     RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho Họ")]
    public string LastName { get; set; }
    // Regex số điện thoại bắt đầu bằng 03 05 07 08 09 và cộng thêm 8 sô
    [Required(ErrorMessage = "Phải nhập số điện thoại"), RegularExpression(@"(0(3|5|7|8|9)[0-9]{8})", ErrorMessage = "Hãy nhập đúng định dạng cho số điện thoại")]
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int Status { get; set; }
}
