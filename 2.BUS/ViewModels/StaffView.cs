using System.ComponentModel.DataAnnotations;

namespace _2.BUS.ViewModels;

public class StaffView
{
    public string Ma { get; set; }
    [Required(ErrorMessage = "Phải nhập Họ"), RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho Họ")]
    public string LastName { get; set; }
    [RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho tên đệm")]
    public string MiddleName { get; set; }
    [Required(ErrorMessage = "Phải nhập Tên"), RegularExpression(@"^.*[a-zA-z ]", ErrorMessage = "Hãy nhập đúng định dạng cho Tên")]
    public string FirstName { get; set; }
    public int Sex { get; set; }
    public DateTime DoB { get; set; }
    [Required(ErrorMessage = "Phải nhập địa chỉ")]
    public string Address { get; set; }

    // Regex số điện thoại bắt đầu bằng 03 05 07 08 09 và cộng thêm 8 sô
    [Required(ErrorMessage = "Phải nhập số điện thoại"), RegularExpression(@"(0(3|5|7|8|9)[0-9]{8})", ErrorMessage = "Hãy nhập đúng định dạng cho số điện thoại")]
    public string PhoneNumber { get; set; }
    [EmailAddress(ErrorMessage = "Hãy nhập đúng định dạng cho email")]
    public string Email { get; set; }

    /* Regular Expression password
     * Has minimum 8 characters in length - {8,} -> ít nhất 8 kí tự
     * At least one uppercase English letter - (?=.*?[A-Z]) -> có 1 chữ hoa
     * At least one lowercase English letter - (?=.*?[a-z]) -> có 1 chữ thường
     * At least one digit - (?=.*?[0-9]) -> có 1 số
     * At least one special character - (?=.*?[#?!@$%^&*-]) -> có 1 kí tự đặc biệt
     */
    [Required(ErrorMessage = "Phải nhập mật khẩu"), RegularExpression(@"^(?=.*?[A-Z]).{8,}$", ErrorMessage = "Mật khẩu phải ít nhất 8 kí tự và có 1 kí tự viết hoa")]
    public string Password { get; set; }
    public string? ImageDirection { get; set; }
    public int Status { get; set; }
}
