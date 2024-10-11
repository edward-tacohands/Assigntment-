using System.Security.Cryptography.X509Certificates;

namespace assignment01;
public interface IPersonDetails{
    string FirstName { get; set; }
    string SurName { get; set; }
    string PhoneNumber { get; set; }
    string PersonalIdentityNumber { get; set; }
    string Address { get; set; }
    string PostCode { get; set; }
    string City { get; set; }

}