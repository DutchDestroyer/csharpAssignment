using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zivver.Candidate.Assignment
{
    static class Program
    {
        /*   public static string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9." +
               "eyJ1cmwiOiJodHRwczovL3ppdnZlci5jb20vYXBpL2NzaGFycGFzc2lnbm1lbnQvIi" +
               "wiYXNzaWdubWVudCI6Ik1ha2UgdGhlIGFwaSBjYWxsLCBhbGwgaW5mb3JtYXRpb24gd2l" +
               "sbCBiZSBpbiB0aGUgcmVzcG9uc2UifQ." +
               "SbTDhmyTMlLugtGv8XLMoBRcxWDzl6zhfn7DMJwpK70";*/

        public static string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9." +
            "eyJoaW50IjoiV2UgY291bGQgc2hhcmUgc29tZSBoaW50cyBoZXJlIiwiZXhhbX" +
            "BsZSI6ImhlcmUgaXMgdGhlIGFwaSB1cmwsIHNlbmQgYW4gZW1haWwgdG8gdGhp" +
            "cyBlbWFpbGFkZHJlc3MgZm9yIG1vcmUgaW5mb3JtYXRpb24gKHdlIGNvdWxkIG" +
            "RvIHNvbWV0aGluZyB3aXRoIHRoZSBoZWFkZXIgb2YgYW4gZW1haWwpICJ9." +
            "YFxGCK3K9uJj5G5UbHZCxNeuME-cgYpMpa6PIsFcksY";

        static string nameOfParticipant;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nameOfParticipant, new List<Models.Message>()));
        }
    }
}
