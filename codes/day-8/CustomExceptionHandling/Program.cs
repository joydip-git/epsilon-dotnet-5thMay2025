using CustomExceptionHandling;
DrivingLicenseApplication drivingLicenseApplication = null;
try
{
    drivingLicenseApplication = new DrivingLicenseApplication { Name = "anil", DatOfBirth = new DateTime(2009, 1, 1) };
}
catch (AgeLessThanEighteenException ex)
{
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    if (drivingLicenseApplication != null)
    {
        Console.WriteLine(drivingLicenseApplication.Name);
        Console.WriteLine(drivingLicenseApplication.Age);
    }
    else
    {
        Console.WriteLine("no data available since the application has been rejected");
    }
}
