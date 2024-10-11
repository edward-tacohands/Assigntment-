namespace assignment01;

public class Person : IPersonDetails
{
    public string FirstName { get; set; } = "";
    public string SurName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string PersonalIdentityNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public string PostCode { get; set; } = "";
    public string City { get; set; } = "";

    public override string ToString()
    {
        return $"Förnamn: {FirstName} - Efternamn: {SurName} - Personnummer: {PersonalIdentityNumber} \nTelefonnummer: {PhoneNumber} - Adress: {Address} - Postkod: {PostCode} - Stad: {City}";
    }
}