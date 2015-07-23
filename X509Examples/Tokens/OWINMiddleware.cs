using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokens
{
    //Dominic Baier Web Api v2 Security
    public class OWINMiddleware
    {
        private readonly Func<IDictionary<string, object>, Task> _next;

        public OWINMiddleware ( Func<IDictionary<string, object>, Task> next )
        {
            _next = next;

        }

        public async Task Invoke ( IDictionary<string, object> env )
        {
            // inspect env and do credential validation, the set principaal

            env["server.User"] = CreatePrincipal();
            await _next(env);
        }

        private object CreatePrincipal ()
        {
            throw new NotImplementedException();
        }
    }
}
