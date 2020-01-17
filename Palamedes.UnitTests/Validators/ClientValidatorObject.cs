using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace Palamedes.UnitTests.Validators
{
    public class ClientValidatorObject
    {
        public ClientValidatorObject()
        {
            this.httpclient = new HttpClient();
            this.ValidationResults = new List<ValidationResult>();
        }
        public HttpClient httpclient { get; set; }
        
        public string method { get; set; }

        public string Uri { get; set; }

        public object Data { get; set; }

        public List<ValidationResult> ValidationResults { get; set; }
    }
}
