/* using DataBase;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace Services.Helper;

public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions> { 

    private readonly FormDbContext _formDbContext;
    public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock,FormDbContext formDbContext) : base(options, logger, encoder, clock)
    {
        _formDbContext = formDbContext;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            return AuthenticateResult.Fail("Appropriate Header not found");
        }
        var parseHeaderContent = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
        if(parseHeaderContent is not null)
        {
            var bytes = Convert.FromBase64String(parseHeaderContent.Parameter);
            string credentials = Encoding.UTF8.GetString(bytes);
            string[] array = credentials.Split(":");
            string username = array[0];
            string password = array[1];
            var user = await this._formDbContext.admin_panel.FirstOrDefaultAsync(x => x.Password == password && x.Login == username);
            if(user is not null)
            {
                var claim = new[] { new Claim(ClaimTypes.Name, user.Login) };
                var identity = new ClaimsIdentity(claim, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return AuthenticateResult.Success(ticket);
            }
            else
            {
                return AuthenticateResult.Fail("UnAutorized");
            }
        } 
        else
        {
            return AuthenticateResult.Fail("Empty Header!");
        }
    }
} 
*/