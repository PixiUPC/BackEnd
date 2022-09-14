namespace PersonalWorld.API.Personal.Resources;

public class SavePersonLawyerResource
{
    public string FisrtName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Description { get; set; }
    public string UrlImage { get; set; }
    public string Type { get; set; }
    public string Specialty { get; set; }
    public int WonCases { get; set; }
    public int TotalCases { get; set; }
    public int LostCases { get; set; }
}