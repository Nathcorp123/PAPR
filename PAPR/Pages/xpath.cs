using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPR.Pages
{
    public class xpath
    {
        public static string signin = ("//a[normalize-space()='Sign in']");
        public static string gotoaccount = ("//div[@id='otherTileText']");
        public static string emaild = ("//input[@id='i0116']"); 
        public static string next = ("//input[@id='idSIButton9']");
        public static string password = ("//input[@id='passwordInput']");
        public static string clicksignin = ("//span[@id='submitButton']");
        public static string multifactorclick = ("//input[@id='continueButton']");
        public static string otp = ("//input[@id='oneTimePasscodeInput']");
        public static string authenticate = ("//input[@id='authenticateButton']");
        public static string yes = ("//input[@id='idSIButton9']");
        public static string signout = ("//a[normalize-space()='Sign out']");
        public static string selectpoweredair = ("//input[@id='cat_1']");
        public static string Finditbutton = ("//button[normalize-space()='FIND IT']");
        public static string Markitinginfo = ("//a[normalize-space()='Marketing Information']");
        public static string Basicinfo = ("//div[@data-target='#collapseOne']");
        public static string PhysicalAttribute = ("//div[@data-target='#collapseTwo']");
        public static string overview = ("//a[normalize-space()='OVERVIEW']");
    }
}
