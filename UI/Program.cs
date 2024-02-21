using Model;
using MongoDB.Bson.Serialization;

namespace UI;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        BsonClassMap.RegisterClassMap<Ticket>(cm =>
        {
            cm.AutoMap();
            cm.MapMember(c => c.UserDetails).SetElementName("userDetails");
            cm.SetIgnoreExtraElements(true);
        });
        BsonClassMap.RegisterClassMap<UserDetails>(cm =>
        {
            cm.AutoMap();
            cm.MapMember(c => c.Email).SetElementName("email"); // Ensure correct mapping
            cm.SetIgnoreExtraElements(true);
        });

       
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new TicketOverview());
        Application.Run(new UserAuthentication());
    }
}